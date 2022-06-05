using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Lab4
{
    public class Program
    {
        public static void WirteToConsoleWithColor(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void Main(string[] args)
        {
            AbstractNotifyingSystem notifyingSystem = new NotifyingSystem();
            var clientPlants = new List<AbstractPlant>();

            Console.Title = "Greenhouse";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to our greenhouse!");
            Console.ForegroundColor = ConsoleColor.White;

            WirteToConsoleWithColor("Hello dear customer! We are happy to see you here! Please enter your name:", ConsoleColor.White);
            var name = Console.ReadLine();
            Client client = new Client(1, name);
            notifyingSystem.Attach(client);

            WirteToConsoleWithColor($"Welcome, {name}. Let's sit your first plant! What does it type of? ", ConsoleColor.White);
            var plant = CreatePlant(client.Id);
            clientPlants.Add(plant);

            WirteToConsoleWithColor("Great we are ready to be carefull of them", ConsoleColor.Green);

            var runningProgram = true;
            while(runningProgram)
            {
                WirteToConsoleWithColor(
                    "\nWhat's you would like to do?\n1. How is your plant?\n2. Just watching for his state\n3. Add a new plant\n0. Quit",
                    ConsoleColor.White
                    );

                bool correct = true;
                while(correct)
                {
                    correct = false;
                    var responce = Console.ReadLine();
                    switch(responce)
                    {
                        case "0": runningProgram = false; break;
                        case "1": stateOfClientPlants(client, clientPlants); break;
                        case "2":
                            if(clientPlants.Count > 0)
                            {
                                simulateGreenhouseWork(clientPlants, notifyingSystem);
                            }
                            else
                            {
                                WirteToConsoleWithColor("\nPlease add another plant\n", ConsoleColor.Magenta);
                            }
                            break;

                        case "3":
                            Console.WriteLine("Lets add another plant! What does it type of?");
                            var p = CreatePlant(client.Id);
                            clientPlants.Add(p);
                            break;

                        default: correct = true; break;
                    }
                    if(correct)
                    {
                        Console.WriteLine("Try again");
                    }
                }
            }
        }

        private static AbstractPlant CreatePlant(int clientId)
        {
            var plantType = Console.ReadLine();
            WirteToConsoleWithColor("Is it health ok? (Good or bad)", ConsoleColor.White);
            bool correct = true;

            Health health = Health.Die;
            while(correct)
            {
                var stringHealth = Console.ReadLine();
                stringHealth = stringHealth.ToLower();
                correct = false;

                switch(stringHealth)
                {
                    case "good":
                        health = Health.Good;
                        break;

                    case "bad":
                        health = Health.Bad;
                        break;

                    default:
                        correct = true;
                        break;
                }
                if(correct)
                {
                    WirteToConsoleWithColor("Please write existing state (Good or Bad)", ConsoleColor.Yellow);
                }
            }

            WirteToConsoleWithColor("What's comfortable air temperature for it?", ConsoleColor.White);
            float airTemperature = float.Parse(Console.ReadLine());
            WirteToConsoleWithColor("What's comfortable soil temperature for it?", ConsoleColor.White);
            float soilTemperature = float.Parse(Console.ReadLine());
            return new Plant(clientId, plantType, health, airTemperature, soilTemperature);
        }

        private static void simulateGreenhouseWork(List<AbstractPlant> clientPlants, AbstractNotifyingSystem notifyingSystem)
        {
            var randomTime = new Random().Next(1, 3);
            Stopwatch timer = new Stopwatch();
            timer.Start();
            bool breakInDeadCase = true;
            while(timer.Elapsed.TotalSeconds < randomTime && breakInDeadCase)
            {
                var itemPosition = new Random().Next(0, clientPlants.Count);
                Decorator staff = new Random().Next(0, 2) == 0 ? new AgronomistsDecorator(notifyingSystem) :
                    new StuffDecorator(notifyingSystem);

                staff.SetPlant(clientPlants[itemPosition]);

                var variant = new Random().Next(0, 4);
                switch(variant)
                {
                    case 0:
                        staff.ChangeAirTemperature();
                        break;

                    case 1:
                        staff.TrimPlant();
                        break;

                    case 2:
                        staff.ChangeAirTemperature();
                        break;

                    case 3:
                        staff.RemoveLeaves();
                        break;

                    default:
                        break;
                }

                WirteToConsoleWithColor("Your plant health is: " + clientPlants[itemPosition].Health, clientPlants[itemPosition].Health == Health.Good ? ConsoleColor.Green : ConsoleColor.Red);
                if(clientPlants[itemPosition].Health == Health.Bad || clientPlants[itemPosition].Health == Health.Die)
                {
                    WirteToConsoleWithColor("Calling agronomist on your problem", ConsoleColor.Yellow);
                    var ag = new AgronomistsDecorator(notifyingSystem);
                    ag.SetPlant(clientPlants[itemPosition]);
                    ag.HealingPlant();
                }

                if(clientPlants[itemPosition].Health == Health.Die)
                {
                    staff.DeletePlant();
                    clientPlants.Remove(clientPlants[itemPosition]);
                    breakInDeadCase = false;
                    break;
                }
            }
            timer.Stop();
        }

        private static void stateOfClientPlants(Client client, List<AbstractPlant> abstractPlants)
        {
            foreach(var plant in abstractPlants)
            {
                client.GetResponce(plant);
            }
        }
    }
}