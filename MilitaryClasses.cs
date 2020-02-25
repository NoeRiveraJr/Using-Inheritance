using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryClasses
{
    //this class library contains 4 base classes that I will use to show inheritance as well as applying what I have learned thorughout MSSA
    public class Personnel
    {
        public string rank;    //fields of the class
        public string quote;
        public string billet;
        public string uniformQuality;
        enum Ranks { Private = 1, Sergeant, GunnerySergeant, Lieutenant, Captain, Major }  //enums are used for both ranks and billets
        enum Billets { Rifleman = 1, PlatoonSergeant, CompanyGuns, PlatoonCommander, CompanyCommander, BattalionCommander }

        public string assignQuote(int grade) //use of a switch case where the personnel's grade is used to assign them their quote
        {
            switch (grade)
            {
                case 1:
                    this.quote = "I say I'm just a shower shoe in a boot world";
                    break;
                case 2:
                    this.quote = "I say take your hands out of your pockets";
                    break;
                case 3:
                    this.quote = "I say I told them 0600, I'll be there at 0630";
                    break;
                case 4:
                    this.quote = "I say I'm fresh out of OCS...I've done things...Been to places...";
                    break;
                case 5:
                    this.quote = "I say Company PT this Friday, but don't quote me on it";
                    break;
                case 6:
                    this.quote = "I say I may be old, but I can still outrun y'all";
                    break;
            }
            return this.quote;
        }

        public string assignRank(int grade) //using a int parameter in the assignRank and assignBillet method to be able to use the enum effectively 
        {
            Ranks rank = (Ranks)grade;
            this.rank = rank.ToString();
            return this.rank;
        }

        public string assignBillet(int grade)
        {
            Billets billet = (Billets)grade;
            this.billet = billet.ToString();
            return this.billet;
        }

        public virtual string myUniformQuality() //my first implementation of a virtual method
        {
            this.uniformQuality = "My uniform is new and clean";
            return this.uniformQuality;
        }
    }

    public class Private : Personnel //I override the myUniformQuality for every subclass of the Personnel class
    {
        public override string myUniformQuality()
        {
            this.uniformQuality = "My uniform is new becuase I'm new";
            return this.uniformQuality;
        }
    } 
    public class Sergeant : Personnel
    {
        public override string myUniformQuality()
        {
            this.uniformQuality = "My uniform is salty, I need to buy new ones";
            return this.uniformQuality;
        }
    }

    public class GunnerySergeant : Personnel
    {
        public override string myUniformQuality()
        {
            this.uniformQuality = "My uniform is old, and I need to buy new ones, but I'm about to retire";
            return this.uniformQuality;
        }
    }
    public class Lieutenant : Personnel
    {
        public override string myUniformQuality()
        {
            this.uniformQuality = "My uniform is new, but I've been to places";
            return this.uniformQuality;
        }
    }
    public class Captain : Personnel
    {
        public override string myUniformQuality()
        {
            this.uniformQuality = "My uniform always looks good to set the right example";
            return this.uniformQuality;
        }
    }
    public class Major : Personnel
    {
        public override string myUniformQuality()
        {
            this.uniformQuality = "My uniform is old and salty, just like me";
            return this.uniformQuality;
        }
    }

    public class Weapons 
    {
        enum weaponName { Rifle = 1, Howitzer, Pistol} //fields of this class, with another enum to show how they can be utilized
        public string fireNoise;
        public string load;
        public string personnelAmount;

        public string assignName(int x)
        {
            weaponName name = (weaponName)x;
            return name.ToString();

        }
        public virtual string assignFireNoise()
        {
            this.fireNoise = "Pew Pew Pew";
            return this.fireNoise;
        }

        public string assignLoadType(int round) //use of a nested-if statements
        {
            if (round == 1)
            {
                this.load = "Loading a magazine into your rifle";
            }
            else if (round == 2)
            {
                this.load = "Loading an artillery round into the tube";
            }
            else
            {
                this.load = "Loading a magizine into your pistol";
            }
            return this.load;
        }

        public string assignPersonnelAmount(int personnel)
        {
            this.personnelAmount = ($"It takes {personnel} unit members to fire this weapon");
            return this.personnelAmount;
        }
    }

    public class Rifle : Weapons //I override the assignFireNoise for the Rifle and Howitzer subclasses, but utilize the base.assignFireNoise() for the pistol
    {
        public override string assignFireNoise()
        {
            return this.fireNoise = "Bang Bang Bang";
        }
    }

    public class Howitzer : Weapons
    {
        public override string assignFireNoise()
        {
            return this.fireNoise = "Boom Boom Boom";
        }
    }

    public class Pistol : Weapons
    {
        public override string assignFireNoise()
        {
            return base.assignFireNoise(); //this uses the original base class method which would assign "Pew Pew Pew" to this.fireNoise
        }
    }

    public class Vehicles
    {
        enum VehicleName { Humvee=1, Helicopter, Ship } //fields of the Vehicles class
        enum TerrainType {Water = 1, Air, Ground }
        public string ammountOfPersonnel;
        public string startNoise;
        public string driveNoise;
        public string stopNoise;

        public string vehicleName(int x)
        {
            VehicleName vehicle = (VehicleName)x;
            return vehicle.ToString();
        }
        public string vehicleTerrain(int x)
        {
            TerrainType terrain = (TerrainType)x;
            return terrain.ToString();
        }

        public virtual int amtOfPersonnel()
        {
            int x = 1;
            return x;
        }

        public virtual string strNoise()
        {
            return this.startNoise = "Vrm";
        }

        public virtual string driNoise()
        {
            return this.driveNoise = "Raahh";
        }
        
        public virtual string stoNoise()
        {
            return this.stopNoise = "skrrt";
        }
    }

    public class Humvee : Vehicles //I will use the base class Noise methods for the Humvee, but I overrided the amtOfPersonnel() method
    {
        public override int amtOfPersonnel()
        {
            int x = 4;
            return x;
        }
    }

    public class Helicopter: Vehicles //for the Helicopter and Ship subclass, I override the amtOfPersonnel(),strNoise(),driNoise(), and stoNoise() methods
    {
        public override int amtOfPersonnel()
        {
            int x = 6;
            return x;
        }

        public override string strNoise()
        {
            return this.startNoise = "Flop Flop Slop";
        }

        public override string driNoise()
        {
            return this.startNoise = "Thump Thump Thump";
        }

        public override string stoNoise()
        {
            return this.stopNoise = "Wack Wack Wack";
        }
    }

    public class Ship : Vehicles
    {
        public override int amtOfPersonnel()
        {
            int x = 300;
            return x;
        }

        public override string strNoise()
        {
            return this.startNoise = "Whirl Whirl Whirl";
        }

        public override string driNoise()
        {
            return this.driveNoise = "Brrrrrrrrr";
        }

        public override string stoNoise()
        {
            return this.stopNoise = "Sppssshhh";
        }
    }
    
    public class Missions
    {
        public int[] amountOfPersonnel; //fields for the Missions class, here I use 2 arrays to utilize when I save the values of a params array in the amtAndTypePersonnel and amtAndTypeVehicles
        public int[] amountOfVehicles;
        public string missionStatement;
        public string execution;
        public string missionFinish;

        public Array amtAndTypeOfPersonnel(params int[] amtAndTypeOfPersonnel) //indexes will be utilizied to show index 0 as Rifleman, 1 as Platoon Sergeant, etc.
        {
            this.amountOfPersonnel = amtAndTypeOfPersonnel;
            return this.amountOfPersonnel;
        }
        
        public Array amtAndTypeOfVehicles(params int[] amtAndTypeOfVehicles) //indexs will be utilized as 0 for humvees, 1 for helicopters, 2 for ships
        {
            this.amountOfVehicles = amtAndTypeOfVehicles;
            return this.amountOfVehicles;
        }

        public virtual string missStatement()
        {
            this.missionStatement = "This mission requires you to invade a foreign country and regain control of the capital of the country!";
            return this.missionStatement;
        }

        public virtual string exec()
        {
            this.execution = "You begin by entering through the border with your personnel and vehicles! The long fight ahead begins.";
            return this.execution;
        }
        
        public virtual string missFinish()
        {
            this.missionFinish = "Your unit has successfully regained control of capital and the battle is won.";
            return this.missionFinish;
        }
    }

    public class Defend : Missions //both missions override the 3 methods that are used as dialouge for each mission
    {
        public override string missStatement()
        {
            this.missionStatement = "Your mission is to defend the United States from an attack on the White House!";
            return this.missionStatement;
        }

        public override string exec()
        {
            this.execution = "Your unit has baracaded itself in the White House! Enemeys are being entering from all directions";
            return this.execution;
        }

        public override string missFinish()
        {
            this.missionFinish = "After a long night, the White House has been saved and your unit is praised for its heroic effort.";
            return this.missionFinish;
        }
    }
    public class Attack : Missions
    {
        public override string missStatement()
        {
            return base.missStatement();
        }

        public override string exec()
        {
            return base.exec();
        }

        public override string missFinish()
        {
            return base.missFinish();
        }
    }


}
