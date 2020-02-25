using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilitaryClasses;

namespace MilitaryUnit
{
    class Unit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here are the enlisted personnel in your military unit!\n");
            Private pvt = new Private();
            Console.WriteLine(pvt.assignRank(1));
            Console.WriteLine(pvt.assignQuote(1));
            Console.WriteLine($"My billet is {pvt.assignBillet(1)}");
            Console.WriteLine(pvt.myUniformQuality());
            Console.Write("\n");
            Sergeant sgt = new Sergeant();
            Console.WriteLine(sgt.assignRank(2));
            Console.WriteLine(sgt.assignQuote(2));
            Console.WriteLine($"My billet is {sgt.assignBillet(2)}");
            Console.WriteLine(sgt.myUniformQuality());
            Console.Write("\n");
            GunnerySergeant gysgt = new GunnerySergeant();
            Console.WriteLine(gysgt.assignRank(3));
            Console.WriteLine(gysgt.assignQuote(3));
            Console.WriteLine($"My billet is {gysgt.assignBillet(3)}");
            Console.WriteLine(gysgt.myUniformQuality());
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Here are the officer personnel in your military unit!\n");
            Lieutenant lt = new Lieutenant();
            Console.WriteLine(lt.assignRank(4));
            Console.WriteLine(lt.assignQuote(4));
            Console.WriteLine($"My billet is {lt.assignBillet(4)}");
            Console.WriteLine(lt.myUniformQuality());
            Console.Write("\n");
            Captain capt = new Captain();
            Console.WriteLine(capt.assignRank(5));
            Console.WriteLine(capt.assignQuote(5));
            Console.WriteLine($"My billet is {capt.assignBillet(5)}");
            Console.WriteLine(capt.myUniformQuality());
            Console.Write("\n");
            Major maj = new Major();
            Console.WriteLine(maj.assignRank(6));
            Console.WriteLine(maj.assignQuote(6));
            Console.WriteLine($"My billet is {maj.assignBillet(6)}");
            Console.WriteLine(maj.myUniformQuality());
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Here are the avalible vehicles in your unit");
            Console.Write("\n");
            Humvee humvee = new Humvee();
            Console.WriteLine(humvee.vehicleName(1));
            Console.WriteLine($"The amount of personnel required is {humvee.amtOfPersonnel()}");
            Console.WriteLine($"The {humvee.vehicleName(1)} operates on {humvee.vehicleTerrain(3)}.");
            Console.WriteLine($"The start noise is {humvee.strNoise()}.\nThe drive noise is {humvee.driNoise()}.\nThe stop noise is {humvee.stoNoise()}.");
            Console.Write("\n");
            Helicopter helicopter = new Helicopter();
            Console.WriteLine(helicopter.vehicleName(2));
            Console.WriteLine($"The amount of personnel required is {helicopter.amtOfPersonnel()}");
            Console.WriteLine($"The {helicopter.vehicleName(1)} operates on {helicopter.vehicleTerrain(2)}.");
            Console.WriteLine($"The start noise is {helicopter.strNoise()}.\nThe drive noise is {helicopter.driNoise()}.\nThe stop noise is {helicopter.stoNoise()}.");
            Console.Write("\n");
            Ship ship = new Ship();
            Console.WriteLine(ship.vehicleName(3));
            Console.WriteLine($"The amount of personnel required is {ship.amtOfPersonnel()}");
            Console.WriteLine($"The {ship.vehicleName(3)} operates on {ship.vehicleTerrain(1)}.");
            Console.WriteLine($"The start noise is {ship.strNoise()}.\nThe drive noise is {ship.driNoise()}.\nThe stop noise is {ship.stoNoise()}.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Here are the weapons your unit uses!");
            Rifle rifle = new Rifle();
            Console.WriteLine(rifle.assignName(1));
            Console.WriteLine(rifle.assignPersonnelAmount(1));
            Console.WriteLine($"Time to load your rifle...{rifle.assignLoadType(1)}");
            Console.Write("\n");
            Pistol pistol = new Pistol();
            Console.WriteLine(pistol.assignName(3));
            Console.WriteLine(rifle.assignPersonnelAmount(1));
            Console.WriteLine($"Time to load your pistol...{pistol.assignLoadType(3)}");
            Console.Write("\n");
            Howitzer howitzer = new Howitzer();
            Console.WriteLine(howitzer.assignName(2));
            Console.WriteLine(rifle.assignPersonnelAmount(4));
            Console.WriteLine($"Time to load your howitzer...{howitzer.assignLoadType(2)}");
            Console.ReadKey();
            Console.Clear();

            Attack attack = new Attack();
            Defend defend = new Defend();
            string test;
            int check;
            int[] personnel;
            int[] vehicles;

            do
            {
                Console.WriteLine("Please enter the number of the mission you would like to conduct or exit the program!\n1. Attack\n2. Defend\n3. Exit the Program");
                test = Console.ReadLine();
                while (Int32.TryParse(test, out check) == false || check != 1 && check != 2 && check != 3)
                {
                    Console.WriteLine("You have not entered a valid menu option, please try again.");
                    test = Console.ReadLine();
                }
                switch (check)
                {
                    case 1:
                        personnel = (int[])attack.amtAndTypeOfPersonnel(15, 5, 1, 3, 1, 1).Clone(); //using the billet structure as indexs where Riflemen starts at 0
                        Console.WriteLine($"The amount of Riflemen used in this is mission is : {personnel[0]}");
                        Console.WriteLine($"The amount of Platoon Sergeants used in this is mission is : {personnel[1]}");
                        Console.WriteLine($"The amount of Company Guns used in this is mission is : {personnel[2]}");
                        Console.WriteLine($"The amount of Lieutenants used in this is mission is : {personnel[3]}");
                        Console.WriteLine($"The amount of Company Comdaners used in this is mission is : {personnel[4]}");
                        Console.WriteLine($"The amount of Battalion Commanders used in this is mission is : {personnel[5]}\n");
                        vehicles = (int[])defend.amtAndTypeOfVehicles(5, 10, 2).Clone(); //using index 0 as Humvees, 1 as Helicopters, 2 as Ships
                        Console.WriteLine($"The amount of Humvees used in this mission is : {vehicles[0]}");
                        Console.WriteLine($"The amount of Helicopters used in this mission is : {vehicles[1]}");
                        Console.WriteLine($"The amount of Ships used in this mission is : {vehicles[2]}");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine(attack.missStatement());
                        Console.Write("\n");
                        Console.ReadKey();
                        Console.WriteLine(attack.exec());
                        Console.Write("\n");
                        Console.ReadKey();
                        Console.WriteLine(attack.missFinish());
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        personnel = (int[])defend.amtAndTypeOfPersonnel(30, 5, 2, 5, 2, 1).Clone();
                        Console.WriteLine($"The amount of Riflemen used in this is mission is : {personnel[0]}");
                        Console.WriteLine($"The amount of Platoon Sergeants used in this is mission is : {personnel[1]}");
                        Console.WriteLine($"The amount of Company Guns used in this is mission is : {personnel[2]}");
                        Console.WriteLine($"The amount of Lieutenants used in this is mission is : {personnel[3]}");
                        Console.WriteLine($"The amount of Company Comdaners used in this is mission is : {personnel[4]}");
                        Console.WriteLine($"The amount of Battalion Commanders used in this is mission is : {personnel[5]}\n");
                        vehicles = (int[])defend.amtAndTypeOfVehicles(10, 20, 4).Clone(); //using index 0 as Humvees, 1 as Helicopters, 2 as Ships
                        Console.WriteLine($"The amount of Humvees used in this mission is : {vehicles[0]}");
                        Console.WriteLine($"The amount of Helicopters used in this mission is : {vehicles[1]}");
                        Console.WriteLine($"The amount of Ships used in this mission is : {vehicles[2]}");
                        Console.ReadKey();
                        Console.Clear();
                        Console.ReadKey();
                        Console.WriteLine(defend.missStatement());
                        Console.ReadKey();
                        Console.Write("\n");
                        Console.WriteLine(defend.exec());
                        Console.ReadKey();
                        Console.Write("\n");
                        Console.WriteLine(defend.missFinish());
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (check != 3);
            Console.WriteLine("Thanks for learning about inheritance with me :) Goodbye!");
        }
    }
}