﻿using Grpc.Core;
using Grpc.Net.Client;
using Microsoft.Extensions.DependencyInjection;
using Shared.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public abstract class NodeBase
    {
        public virtual GrpcChannel? mainChannel { get; set; }
        public virtual SeedNodeService.SeedNodeServiceClient? seedClient { get; set; }
        public virtual BroadcastService.BroadcastServiceClient? broadcastClient { get; set; }
        public virtual AuctionService.AuctionServiceClient? auctionClient { get; set; }

        public virtual int MainChannelPort => 50055;
        public virtual IAuctionCache auctionCache { get; set; }
        public virtual string NodeId { get; set; }
        public virtual string NodeHost { get; set; }
        public virtual int NodePort { get; set; }

        public NodeBase()
        {

        }

        public virtual void RunPeer()
        {
            mainChannel = GrpcChannel.ForAddress($"http://localhost:{MainChannelPort}");
            seedClient = new SeedNodeService.SeedNodeServiceClient(mainChannel);
            broadcastClient = new BroadcastService.BroadcastServiceClient(mainChannel);
            NodeId = Guid.NewGuid().ToString();

            Server server = RegisterServices();
            RegisterClientAndStart(NodePort, NodeId, server, NodeHost);
            StartListeningBroadcastMessages();
            ShowMenu();
            GetInput();
            server.ShutdownAsync().Wait();
        }

        protected virtual void ShowMenu()
        {
            Console.Clear();
            var nodeAddress = $"http://{NodeHost}:{NodePort}";

            Console.WriteLine($"Current Node Adress: {nodeAddress}, Node Id:{NodeId}");
            Console.WriteLine("\n\n\n");
            Console.WriteLine("                    P2p bidder ");
            Console.WriteLine("============================================================");
            Console.WriteLine("============================================================");
            Console.WriteLine("                    1. Get All Auctions");
            Console.WriteLine("                    2. Make a Bid for an auction");
            Console.WriteLine("                    3. Create Auction");
            Console.WriteLine("                    4. My Auctions");
            Console.WriteLine("                    5. Accept the bid");
            Console.WriteLine("                    6. Exit");
            Console.WriteLine("------------------------------------------------------------");
        }

        protected virtual void GetInput()
        {
            while (true)
            {
                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        GetAllAuctions();
                        break;
                    case "2":
                        MakeBid();
                        break;

                    case "3":
                        CreateAuction();
                        break;

                    case "4":
                        MyAuctions();
                        break;

                    case "5":
                        AcceptTheBid();
                        break;

                    case "6":
                        DoExit();
                        break;
                }
            }

        }

        protected void AcceptTheBid()
        {
            Console.WriteLine("type Auction Id to be selected");

            var auctionId = Console.ReadLine();

            Console.WriteLine("Type 'Y' to accept or 'N' to decline it");

            var acceptOrNot = Console.ReadLine();

            switch (acceptOrNot)
            {
                case "Y":
                    AcceptTheBidbyId(auctionId);

                    break;
                case "N":
                    //Decline();
                    break;
            }

            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("-------------------------Main Menu--------------------------");
        }

        /// <summary>
        /// check if bid is your or not. Dont allow your node to accept the auction which it doesnt own.
        /// </summary>
        /// <param name="auctionId"></param>
        /// <exception cref="NotImplementedException"></exception>
        protected virtual void AcceptTheBidbyId(string? auctionId)
        {

            var auction = auctionCache.GetAuctions().Where(a => a.AuctionId == auctionId).FirstOrDefault();

            if (auction == null)
            {
                Console.WriteLine("There is no auction with this Id.");
                return;
            }

            if (auction.OwnerNodeId != NodeId)
            {
                Console.WriteLine("You can not accpet the bid for an auction you dont own!");
                return;
            }

            var auctionAddress = auction.Address;
            var bidderadress = auction.BidderAdress;

            var channel = GrpcChannel.ForAddress(bidderadress);
            auctionClient = new AuctionService.AuctionServiceClient(channel);
            auctionClient.FinalizeAuction(auction);

            Console.WriteLine("Bid is accepted!");
        }

        protected virtual void CreateAuction()
        {
            Console.WriteLine("Write Item Name");
            var ItemName = Console.ReadLine();

            Console.WriteLine("Write Starting Price");
            var startingPrice = Console.ReadLine();

            var auctionId = Guid.NewGuid().ToString();

            var request = new BroadcastMessage
            {
                Text = "add",
                AuctionId = auctionId,
                OwnerId = NodeId,
                Address = $"http://{NodeHost}:{NodePort}",
                ItemName = ItemName,
                StartingPrice = Convert.ToDouble(startingPrice),
                Bidder = string.Empty,
                BidderAddress = string.Empty,
            };
            _ = broadcastClient?.Broadcast(request);
            Console.WriteLine($"Auction is sent the the network! {auctionId} is created");

            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("-------------------------Main Menu--------------------------");
        }

        protected static void DoExit()
        {
            Environment.Exit(0);
        }

        protected virtual void GetAllAuctions()
        {
            var getAllAuctions = auctionCache.GetAuctions();

            foreach (var auction in getAllAuctions)
            {
                Console.WriteLine($"AuctionId: {auction.AuctionId} Item Name: {auction.AuctionRequest.ItemName}, with a starting price of {auction.AuctionRequest.StartingPrice}");
            }

            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("-------------------------Main Menu--------------------------");

            return;
        }

        protected virtual void MakeBid()
        {
            Console.WriteLine("Pls enter auctionId to be selected");

            var auctionSelection = Console.ReadLine();

            Console.WriteLine("pls enter your bid amount");

            var bidAmount = Console.ReadLine();

            auctionSelection = auctionSelection.Replace(" ", "");

            var auction = auctionCache.GetAuctions().Where(a => a.AuctionId == auctionSelection).FirstOrDefault();

            if (auction == null)
            {
                Console.WriteLine("There is no auction with this Id.");
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("-------------------------Main Menu--------------------------");
                return;
            }
                
            if (auction.OwnerNodeId == NodeId)
            {
                Console.WriteLine("you can not make a bid for your own auction!");
                return;
            }
            var bidderAddress = $"http://{NodeHost}:{NodePort}";

            var auctionAddress = auction.Address;

            var channel = GrpcChannel.ForAddress(auctionAddress);
            auctionClient = new AuctionService.AuctionServiceClient(channel);

            var bidReq = new PlaceBidRequest { AuctionId = auction.AuctionId, BidAmount = Convert.ToDouble(bidAmount), Bidder = NodeId, BidderAdress = bidderAddress };

            var response = auctionClient.PlaceBid(bidReq);

            if (response.Accepted)
                Console.WriteLine("Congrats, your bid is currently the highest one!.Pls don't forget, owner of the auction still needs to end the auction");
            else
                Console.WriteLine("your bid is below the current bid amount");

            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("-------------------------Main Menu--------------------------");
        }

        protected virtual void MyAuctions()
        {
            var getMyAuctions = auctionCache.GetAuctions().Where(p => p.OwnerNodeId == NodeId).ToList();

            foreach (var auction in getMyAuctions)
            {
                Console.WriteLine($"AuctionId: {auction.AuctionId} Item Name: {auction.AuctionRequest.ItemName}, with a current bid is{auction.AuctionRequest.StartingPrice}");
            }
            return;
        }

        protected virtual void RegisterClientAndStart(int NodePort, string nodeId, Server server, string NodeHost)
        {
            server.Start();
            const int MainChannelPort = 50055;

            Console.WriteLine($"Server listening on port {NodePort}");

            var mainChannel = GrpcChannel.ForAddress($"http://localhost:{MainChannelPort}");

            var seedClient = new SeedNodeService.SeedNodeServiceClient(mainChannel);

            var nodeAddress = $"http://{NodeHost}:{NodePort}";

            var registerRequest = new RegisterRequest { NodeId = nodeId, NodeAddress = nodeAddress };

            var response = seedClient.RegisterNode(registerRequest);

            Console.WriteLine($"Registration response: {response}");

            mainChannel.ShutdownAsync().Wait();
        }

        protected virtual void StartListeningBroadcastMessages()
        {
            var cancellationTokenSource = new CancellationTokenSource();

            var call = broadcastClient?.ReceiveBroadcast(new BroadcastEmpty());

            var messageHandlerTask = Task.Run(async () =>
            {
                try
                {
                    await foreach (var message in call.ResponseStream.ReadAllAsync(cancellationTokenSource.Token))
                    {
                        if (!string.IsNullOrEmpty(message.Text) && !string.IsNullOrEmpty(message.AuctionId) && !string.IsNullOrEmpty(message.OwnerId))
                        {
                            switch (message.Text)
                            {
                                case "add":

                                    AddToCache(message);
                                    break;
                                case "update":

                                    UpdateCache(message);
                                    break;

                                case "delete":
                                    // inform the channel about bid is ended and send messages about who won the auction
                                    DeleteFromCache(message);
                                    break;
                            }
                            Console.WriteLine("-------------------------Main Menu--------------------------");
                        }
                    }
                }
                catch (RpcException ex) when (ex.StatusCode == StatusCode.Cancelled)
                {
                    Console.WriteLine("Broadcast subscription canceled.");
                }
            });

            return;
        }

        protected virtual void DeleteFromCache(BroadcastMessage? message)
        {
            Console.WriteLine($"Auction is  ended on the channel: Item Name:  {message.ItemName}, new bid:{message.StartingPrice} ");
            Console.WriteLine($"Winning bidder Id is {message.Bidder}, bidder address:  {message.Address}");
            var auctionResponse3 = new AuctionResponse
            {
                AuctionId = message.AuctionId,
                OwnerNodeId = message.OwnerId,
                Address = message.Address,
                AuctionRequest = new InitiateAuctionRequest
                {
                    StartingPrice = message.StartingPrice,
                    ItemName = message.ItemName
                },
                Bidder = message.Bidder,
                BidderAdress = message.BidderAddress
            };
            auctionCache.DeleteAuction(auctionResponse3);
        }

        protected virtual void UpdateCache(BroadcastMessage? message)
        {
            Console.WriteLine($"Auction is  updated on the channel: Item Name:  {message.ItemName}, new bid:{message.StartingPrice} ");
            var auctionResponse2 = new AuctionResponse
            {
                AuctionId = message.AuctionId,
                OwnerNodeId = message.OwnerId,
                Address = message.Address,
                AuctionRequest = new InitiateAuctionRequest
                {
                    StartingPrice = message.StartingPrice,
                    ItemName = message.ItemName
                },
                Bidder = message.Bidder,
                BidderAdress = message.BidderAddress
            };
            auctionCache.UpdateAuction(auctionResponse2);
        }

        protected virtual void AddToCache(BroadcastMessage? message)
        {
            Console.WriteLine($"New Auction added to the channel: Item Name:  {message.ItemName}, current price:{message.StartingPrice} ");
            var auctionResponse = new AuctionResponse
            {
                AuctionId = message.AuctionId,
                OwnerNodeId = message.OwnerId,
                Address = message.Address,
                AuctionRequest = new InitiateAuctionRequest
                {
                    StartingPrice = message.StartingPrice,
                    ItemName = message.ItemName
                },
                Bidder = message.Bidder,
                BidderAdress = message.BidderAddress

            };
            auctionCache.AddAuction(auctionResponse);
        }

        protected virtual Server RegisterServices()
        {
            var serviceProvider = new ServiceCollection()
                    .AddSingleton<IAuctionCache, AuctionCache>()
                    .AddSingleton<Dictionary<string, AuctionResponse>>()// Register your local service implementation.
                    .BuildServiceProvider();


            var serviceCache = serviceProvider.GetRequiredService<IAuctionCache>();
            auctionCache = serviceCache;

            var server = new Server
            {
                Services = { AuctionService.BindService(new AutionServiceImpl(serviceCache)) },
                Ports = { new ServerPort(NodeHost, NodePort, ServerCredentials.Insecure) }
            };
            return server;
        }
    }
}
