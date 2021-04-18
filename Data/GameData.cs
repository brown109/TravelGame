using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelGame.Models;

namespace TravelGame.Data
{
    //
    // GameData is everything needed to play the game
    //
    public static class GameData
    {
        public static Player PlayerData()
        {
            //
            // Initiate Player data
            //
            return new Player()
            {
                StartDate = DateTime.Now,
                Experience = 0,
                Bestscore = 1000,
                Visits = 0,
                Tasks = 0,
                Liveslost = 0,
                Totalscore = 1000,
                CurrentCity = "blank"
            };
        }
        public static GameMap GameMap()
        {
            GameMap gameMap = new GameMap();
            //
            // load location list (each city to visit and where you can go from there)
            //
            Location _location = new Location();
            _location.City = "New York";
            _location.NCity = "";
            _location.SCity = "";
            _location.ECity = "London";
            _location.WCity = "";
            _location.NECity = "";
            _location.NWCity = "";
            _location.SECity = "";
            _location.SWCity = "";
            gameMap.LocationList.Add(_location);
            
            _location = new Location();
            _location.City = "London";
            _location.NCity = "";
            _location.SCity = "";
            _location.ECity = "Frankfort";
            _location.WCity = "New York";
            _location.NECity = "";
            _location.NWCity = "";
            _location.SECity = "Paris";
            _location.SWCity = "";
            gameMap.LocationList.Add(_location);
            
            _location = new Location();
            _location.City = "Frankfort";
            _location.NCity = "";
            _location.SCity = "Rome";
            _location.ECity = "Warsaw";
            _location.WCity = "London";
            _location.NECity = "";
            _location.NWCity = "";
            _location.SECity = "";
            _location.SWCity = "Paris";
            gameMap.LocationList.Add(_location);

            _location = new Location();
            _location.City = "Paris";
            _location.NCity = "";
            _location.SCity = "";
            _location.ECity = "";
            _location.WCity = "";
            _location.NECity = "Frankfort";
            _location.NWCity = "London";
            _location.SECity = "Rome";
            _location.SWCity = "";
            gameMap.LocationList.Add(_location);

            _location = new Location();
            _location.City = "Rome";
            _location.NCity = "Frankfort";
            _location.SCity = "";
            _location.ECity = "";
            _location.WCity = "";
            _location.NECity = "Warsaw";
            _location.NWCity = "Paris";
            _location.SECity = "Athens";
            _location.SWCity = "";
            gameMap.LocationList.Add(_location);

            _location = new Location();
            _location.City = "Warsaw";
            _location.NCity = "";
            _location.SCity = "Athens";
            _location.ECity = "";
            _location.WCity = "Frankfort";
            _location.NECity = "";
            _location.NWCity = "";
            _location.SECity = "";
            _location.SWCity = "Rome";
            gameMap.LocationList.Add(_location);

            _location = new Location();
            _location.City = "Athens";
            _location.NCity = "Warsaw";
            _location.SCity = "";
            _location.ECity = "";
            _location.WCity = "";
            _location.NECity = "";
            _location.NWCity = "Rome";
            _location.SECity = "";
            _location.SWCity = "";
            gameMap.LocationList.Add(_location);
            //
            // CurrentLocation holds the Location of where the player is currently at so you don't have to look it up in the list
            // while processing commands and button clicks
            //
            gameMap.CurrentLocation = gameMap.LocationList[0];
            //
            // Load the list of Npcs which hold key words for each city/type
            //
            Npc npc = new Npc();
            npc.Id = 1000;
            npc.Name = "John";
            npc.Language = "English";
            npc.ActorType = Npc.NpcType.Driver;
            npc.Hint = "Jaunt";
            npc.City = "London";
            npc.KeyWords = new string[] { "drive", "motor", "take", "ride", "lift", "see" };
            npc.IdPoints = 75;
            npc.CompletionPoints = 100;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);

            npc = new Npc();
            npc.Id = 1010;
            npc.Name = "Paul";
            npc.Language = "English";
            npc.Hint = "Peckish";
            npc.ActorType = Npc.NpcType.Chef;
            npc.City = "London";
            npc.KeyWords = new string[] { "cook", "feed", "prepare", "eat", "dine", "taste" };
            npc.IdPoints = 85;
            npc.CompletionPoints = 110;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);

            npc = new Npc();
            npc.Id = 1020;
            npc.Name = "George";
            npc.Language = "English";
            npc.ActorType = Npc.NpcType.Bartender;
            npc.Hint = "Parched";
            npc.City = "London";
            npc.KeyWords = new string[] { "mix", "pour", "set me up", "set up", "have", "drink", "sip" };
            npc.IdPoints = 95;
            npc.CompletionPoints = 120;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);

            npc = new Npc();
            npc.Id = 1030;
            npc.Name = "Ringo";
            npc.Language = "English";
            npc.ActorType = Npc.NpcType.InterloperMinor;
            npc.Hint = "Take heed";
            npc.City = "London";
            npc.KeyWords = new string[] { "Mugger", "defend" };
            npc.HintPhrase = "Your money should be hidden in something or just run away";
            npc.IdPoints = 105;
            npc.CompletionPoints = 200;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);

            npc = new Npc();
            npc.Id = 1040;
            npc.Name = "Brian";
            npc.Language = "English";
            npc.ActorType = Npc.NpcType.InterloperMajor;
            npc.Hint = "Take heed";
            npc.City = "London";
            npc.KeyWords = new string[] { "Spy", "attack" };
            npc.HintPhrase = "You need to slip something in his drink, hire a hit man, or use a hypodermic needle";
            npc.IdPoints = 125;
            npc.CompletionPoints = 230;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);
            //
            // actors(Npcs) for next city
            //
            npc = new Npc();
            npc.Id = 2010;
            npc.Name = "Gretel";
            npc.Language = "German";
            npc.ActorType = Npc.NpcType.Chef;
            npc.Hint = "Hungrig";
            npc.City = "Frankfort";
            npc.KeyWords = new string[] { "cook", "feed", "prepare", "eat", "dine", "taste" };
            npc.IdPoints = 85;
            npc.CompletionPoints = 110;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);

            npc = new Npc();
            npc.Id = 2020;
            npc.Name = "Jurgen";
            npc.Language = "German";
            npc.ActorType = Npc.NpcType.Bartender;
            npc.Hint = "Durstig";
            npc.City = "Frankfort";
            npc.KeyWords = new string[] { "mix", "pour", "set me up", "set up", "have", "drink", "sip" };
            npc.IdPoints = 95;
            npc.CompletionPoints = 120;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);

            npc = new Npc();
            npc.Id = 2040;
            npc.Name = "Adolph";
            npc.Language = "German";
            npc.ActorType = Npc.NpcType.InterloperMajor;
            npc.Hint = "Sei vorsichtig";
            npc.City = "Frankfort";
            npc.KeyWords = new string[] { "Killer", "attack"  };
            npc.HintPhrase = "Best just use a serious weapon";
            npc.IdPoints = 125;
            npc.CompletionPoints = 230;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc); 
            
            npc = new Npc();
            npc.Id = 2000;
            npc.Name = "Astrid";
            npc.Language = "German";
            npc.ActorType = Npc.NpcType.Driver;
            npc.Hint = "Rundgang";
            npc.City = "Frankfort";
            npc.KeyWords = new string[] { "drive", "motor", "take", "ride", "lift", "see" };
            npc.IdPoints = 75;
            npc.CompletionPoints = 100;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);
            
            npc = new Npc();
            npc.Id = 2030;
            npc.Name = "Hans";
            npc.Language = "German";
            npc.ActorType = Npc.NpcType.InterloperMinor;
            npc.Hint = "Sei vorsichtig";
            npc.City = "Frankfort";
            npc.KeyWords = new string[] { "Pickpocket", "defend" };
            npc.HintPhrase = "Make sure your money is hidden, or in a pocket that makes noise when opened, or just get out of there";
            npc.IdPoints = 105;
            npc.CompletionPoints = 200;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);
            //
            // actors for next city
            //
            npc = new Npc();
            npc.Id = 1040;
            npc.Name = "Andre";
            npc.Language = "French";
            npc.ActorType = Npc.NpcType.InterloperMajor;
            npc.Hint = "Fais attention";
            npc.City = "Paris";
            npc.KeyWords = new string[] { "Arsonist", "attack" };
            npc.HintPhrase = "I'd just put out the fire";
            npc.IdPoints = 125;
            npc.CompletionPoints = 230;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);

            npc = new Npc();
            npc.Id = 1020;
            npc.Name = "Elise";
            npc.Language = "French";
            npc.ActorType = Npc.NpcType.Bartender;
            npc.Hint = "Assoiffe";
            npc.City = "Paris";
            npc.KeyWords = new string[] { "mix", "pour", "set me up", "set up", "have", "drink", "sip" };
            npc.IdPoints = 95;
            npc.CompletionPoints = 120;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);

            npc = new Npc();
            npc.Id = 1000;
            npc.Name = "Remi";
            npc.Language = "French";
            npc.ActorType = Npc.NpcType.Driver;
            npc.Hint = "Visiter";
            npc.City = "Paris";
            npc.KeyWords = new string[] { "drive", "motor", "take", "ride", "lift", "see" };
            npc.IdPoints = 75;
            npc.CompletionPoints = 100;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);

            npc = new Npc();
            npc.Id = 1010;
            npc.Name = "Luis";
            npc.Language = "French";
            npc.ActorType = Npc.NpcType.Chef;
            npc.Hint = "Affame";
            npc.City = "Paris";
            npc.KeyWords = new string[] { "cook", "feed", "prepare", "eat", "dine", "taste" };
            npc.IdPoints = 85;
            npc.CompletionPoints = 110;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);

            npc = new Npc();
            npc.Id = 1030;
            npc.Name = "Beau";
            npc.Language = "French";
            npc.ActorType = Npc.NpcType.InterloperMinor;
            npc.Hint = "Fais attention";
            npc.City = "Paris";
            npc.KeyWords = new string[] { "Protestor", "defend" };
            npc.HintPhrase = "Do something to block out the noise, or do the same thing";
            npc.IdPoints = 105;
            npc.CompletionPoints = 200;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);
            //
            // actors for next city
            //
            npc = new Npc();
            npc.Id = 1030;
            npc.Name = "Tony";
            npc.Language = "Italian";
            npc.ActorType = Npc.NpcType.InterloperMinor;
            npc.Hint = "Stai attento";
            npc.City = "Rome";
            npc.KeyWords = new string[] { "Joker", "defend" };
            npc.HintPhrase = "Just go along with him";
            npc.IdPoints = 105;
            npc.CompletionPoints = 200;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);

            npc = new Npc();
            npc.Id = 1020;
            npc.Name = "Lucia";
            npc.Language = "Italian";
            npc.ActorType = Npc.NpcType.Bartender;
            npc.Hint = "Assetato";
            npc.City = "Rome";
            npc.KeyWords = new string[] { "mix", "pour", "set me up", "set up", "have", "drink", "sip" };
            npc.IdPoints = 95;
            npc.CompletionPoints = 120;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);

            npc = new Npc();
            npc.Id = 1010;
            npc.Name = "Mia";
            npc.Language = "Italian";
            npc.ActorType = Npc.NpcType.Chef;
            npc.Hint = "Affamato";
            npc.City = "Rome";
            npc.KeyWords = new string[] { "cook", "feed", "prepare", "eat", "dine", "taste" };
            npc.IdPoints = 85;
            npc.CompletionPoints = 110;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);

            npc = new Npc();
            npc.Id = 1000;
            npc.Name = "Dante";
            npc.Language = "Italian";
            npc.ActorType = Npc.NpcType.Driver;
            npc.Hint = "Girarla";
            npc.City = "Rome";
            npc.KeyWords = new string[] { "drive", "motor", "take", "ride", "lift", "see" };
            npc.IdPoints = 75;
            npc.CompletionPoints = 100;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);
            
            npc = new Npc();
            npc.Id = 1040;
            npc.Name = "Luna";
            npc.Language = "Italian";
            npc.ActorType = Npc.NpcType.InterloperMajor;
            npc.Hint = "Stai attento";
            npc.City = "Rome";
            npc.KeyWords = new string[] { "Kidnapper", "attack" };
            npc.HintPhrase = "Do something so you can't be caught or meet the demands";
            npc.IdPoints = 125;
            npc.CompletionPoints = 230;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);
            //
            // actors for next city
            //
            npc = new Npc();
            npc.Id = 1010;
            npc.Name = "Ivan";
            npc.Language = "Polish";
            npc.ActorType = Npc.NpcType.Chef;
            npc.Hint = "Glodny";
            npc.City = "Warsaw";
            npc.KeyWords = new string[] { "cook", "feed", "prepare", "eat", "dine", "taste" };
            npc.IdPoints = 85;
            npc.CompletionPoints = 110;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);

            npc = new Npc();
            npc.Id = 1040;
            npc.Name = "Walter";
            npc.Language = "Polish";
            npc.ActorType = Npc.NpcType.InterloperMajor;
            npc.Hint = "Ostroznie";
            npc.City = "Warsaw";
            npc.KeyWords = new string[] { "Guerilla", "attack" };
            npc.HintPhrase = "Toss something, drop something on them or use a serious weapon";
            npc.IdPoints = 125;
            npc.CompletionPoints = 230;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);

            npc = new Npc();
            npc.Id = 1020;
            npc.Name = "Cosmo";
            npc.Language = "Polish";
            npc.ActorType = Npc.NpcType.Bartender;
            npc.Hint = "Spragniony";
            npc.City = "Warsaw";
            npc.KeyWords = new string[] { "mix", "pour", "set me up", "set up", "have", "drink", "sip" };
            npc.IdPoints = 95;
            npc.CompletionPoints = 120;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);

            npc = new Npc();
            npc.Id = 1030;
            npc.Name = "Hilary";
            npc.Language = "Polish";
            npc.ActorType = Npc.NpcType.InterloperMinor;
            npc.Hint = "Ostroznie";
            npc.City = "Warsaw";
            npc.KeyWords = new string[] { "Con Man", "defend" };
            npc.HintPhrase = "Report them to the ..., pay no attention, or follow the phrase that if it's ... to be true, it probably is";
            npc.IdPoints = 105;
            npc.CompletionPoints = 200;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);

            npc = new Npc();
            npc.Id = 1000;
            npc.Name = "Boris";
            npc.Language = "Polish";
            npc.ActorType = Npc.NpcType.Driver;
            npc.Hint = "Zwiedzanie";
            npc.City = "Warsaw";
            npc.KeyWords = new string[] { "drive", "motor", "take", "ride", "lift", "see" };
            npc.IdPoints = 75;
            npc.CompletionPoints = 100;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);
            //
            // actors for next city
            //
            npc = new Npc();
            npc.Id = 1020;
            npc.Name = "Yasmin";
            npc.Language = "Greek";
            npc.ActorType = Npc.NpcType.Bartender;
            npc.Hint = "Dipsasmenos";
            npc.City = "Athens";
            npc.KeyWords = new string[] { "mix", "pour", "set me up", "set up", "have", "drink", "sip" };
            npc.IdPoints = 95;
            npc.CompletionPoints = 120;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);
                        
            npc = new Npc();
            npc.Id = 1010;
            npc.Name = "Telly";
            npc.Language = "Greek";
            npc.ActorType = Npc.NpcType.Chef;
            npc.Hint = "Pinasmenoi";
            npc.City = "Athens";
            npc.KeyWords = new string[] { "cook", "feed", "prepare", "eat", "dine", "taste" };
            npc.IdPoints = 85;
            npc.CompletionPoints = 110;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);

            npc = new Npc();
            npc.Id = 1040;
            npc.Name = "Pam";
            npc.Language = "Greek";
            npc.ActorType = Npc.NpcType.InterloperMajor;
            npc.Hint = "Prosexe";
            npc.City = "Athens";
            npc.KeyWords = new string[] { "Politician", "attack"  };
            npc.HintPhrase = "Cast ... for his opponent, send a message on social media, or threaten him with what you know";
            npc.IdPoints = 125;
            npc.CompletionPoints = 230;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);

            npc = new Npc();
            npc.Id = 1000;
            npc.Name = "Theo";
            npc.Language = "Greek";
            npc.ActorType = Npc.NpcType.Driver;
            npc.Hint = "Ayiotheta";
            npc.City = "Athens";
            npc.KeyWords = new string[] { "drive", "motor", "take", "ride", "lift", "see" };
            npc.IdPoints = 75;
            npc.CompletionPoints = 100;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);

            npc = new Npc();
            npc.Id = 1030;
            npc.Name = "Ales";
            npc.Language = "Greek";
            npc.ActorType = Npc.NpcType.InterloperMinor;
            npc.Hint = "Prosexe";
            npc.City = "Athens";
            npc.KeyWords = new string[] { "Obnoxious Tourist", "defend" };
            npc.HintPhrase = "create a ..., pull out your own ... and ask questions, or just ... along";
            npc.IdPoints = 105;
            npc.CompletionPoints = 200;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);
            //
            // Load Items - Foods, Drinks, Sites, and Interlopers
            //
            Item item = new Item();
            item.Name = "Bangers and Mash";
            item.Type = Item.ItemType.Food;
            item.City = "London";
            item.KeyWords = new string[] { "bangers", "mash", "sausage", "mashed potatoes", "potatoes" };
            item.Points = 73;
            item.Servings = 0;
            item.Limit = 2;
            item.Diminish = .75;
            gameMap.Items.Add(item);
           
            item = new Item();
            item.Name = "Fish and Chips";
            item.Type = Item.ItemType.Food;
            item.City = "London";
            item.KeyWords = new string[] { "fish", "chips", "fries", "frites", "cod" };
            item.Points = 83;
            item.Servings = 0;
            item.Limit = 2;
            item.Diminish = .75;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Figgy Pudding";
            item.Type = Item.ItemType.Food;
            item.City = "London";
            item.KeyWords = new string[] { "fig", "pudding" };
            item.Points = 93;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Big Ben";
            item.Type = Item.ItemType.Site;
            item.City = "London";
            item.KeyWords = new string[] { "ben", "clock" };
            item.Points = 74;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Buckingham Palace";
            item.Type = Item.ItemType.Site;
            item.City = "London";
            item.KeyWords = new string[] { "Buckingham", "buckingham", "palace", "castle", "queen lives", "soldier", "guard"};
            item.Points = 84;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Abbey Road";
            item.Type = Item.ItemType.Site;
            item.City = "London";
            item.KeyWords = new string[] { "Abbey", "Beatles", "beatles", "album" };
            item.Points = 94;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Gin and Tonic";
            item.Type = Item.ItemType.Drink;
            item.City = "London";
            item.KeyWords = new string[] { "gin and tonic", "gin", "Beefeaters", "Tanqueray" };
            item.Points = 77;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Guinness";
            item.Type = Item.ItemType.Drink;
            item.City = "London";
            item.KeyWords = new string[] { "guinness", "dark beer", "stout", "pint" };
            item.Points = 87;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Jellied Eel";
            item.Type = Item.ItemType.Drink;
            item.City = "London";
            item.KeyWords = new string[] { "jellied", "eel", };
            item.Points = 107;
            item.Servings = 0;
            item.Limit = 2;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Money Belt";
            item.Type = Item.ItemType.BattleMinor;
            item.City = "London";
            item.KeyWords = new string[] { "money belt", "moneybelt", "hide", "run", "away" };
            item.Points = 175;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Lethal Injection";
            item.Type = Item.ItemType.BattleMajor;
            item.City = "London";
            item.KeyWords = new string[] { "poison", "injection", "assasinate", "contract", "kill" };
            item.Points = 275;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);
            //
            // add items for next city
            //
            item = new Item();
            item.Name = "Bratwurst";
            item.Type = Item.ItemType.Food;
            item.City = "Frankfort";
            item.KeyWords = new string[] { "brats", "sausage", "Brats", "Sausage" };
            item.Points = 50;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Wiener Schnitzel";
            item.Type = Item.ItemType.Food;
            item.City = "Frankfort";
            item.KeyWords = new string[] { "veal", "wiener", "weiner", "schnitzel", "snitzel" };
            item.Points = 60;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "pretzel";
            item.Type = Item.ItemType.Food;
            item.City = "Frankfort";
            item.KeyWords = new string[] { "pretzel"};
            item.Points = 70;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Christmas Market";
            item.Type = Item.ItemType.Site;
            item.City = "Frankfort";
            item.KeyWords = new string[] { "market", "christmas", "xmas" };
            item.Points = 61;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Romerberg";
            item.Type = Item.ItemType.Site;
            item.City = "Frankfort";
            item.KeyWords = new string[] { "romerberg", "old town", "center", "square"};
            item.Points = 71;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Stadel";
            item.Type = Item.ItemType.Site;
            item.City = "Frankfort";
            item.KeyWords = new string[] { "stadel", "museum", "art" };
            item.Points = 81;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Pilsner";
            item.Type = Item.ItemType.Drink;
            item.City = "Frankfort";
            item.KeyWords = new string[] { "pilsner", "beer", "pils", "lager" };
            item.Points = 72;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Spezi";
            item.Type = Item.ItemType.Drink;
            item.City = "Frankfort";
            item.KeyWords = new string[] { "spezi", "orange", "cola" };
            item.Points = 82;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Riesling";
            item.Type = Item.ItemType.Drink;
            item.City = "Frankfort";
            item.KeyWords = new string[] { "riesling", "sweet wine", "white wine" };
            item.Points = 92;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Velcro";
            item.Type = Item.ItemType.BattleMinor;
            item.City = "Frankfort";
            item.KeyWords = new string[] { "velcro", "fanny pack", "hide", "run", "away" };
            item.Points = 175;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Knife";
            item.Type = Item.ItemType.BattleMajor;
            item.City = "Frankfort";
            item.KeyWords = new string[] { "knife", "bullet", "shoot", "dagger", "sword", "gun" };
            item.Points = 275;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);
            //
            // add items for next city
            //
            item = new Item();
            item.Name = "Croissant";
            item.Type = Item.ItemType.Food;
            item.City = "Paris";
            item.KeyWords = new string[] { "bread", "croissant", "roll" };
            item.Points = 50;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Crepe";
            item.Type = Item.ItemType.Food;
            item.City = "Paris";
            item.KeyWords = new string[] { "crepe", "pancake", "thin cake", "suzette", "Suzette" };
            item.Points = 60;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "fries";
            item.Type = Item.ItemType.Food;
            item.City = "Paris";
            item.KeyWords = new string[] { "French Fries", "fried potatoes" };
            item.Points = 70;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Eiffel Tower";
            item.Type = Item.ItemType.Site;
            item.City = "Paris";
            item.KeyWords = new string[] { "tower", "eiffel" };
            item.Points = 61;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Louvre";
            item.Type = Item.ItemType.Site;
            item.City = "Paris";
            item.KeyWords = new string[] { "Art Museum", "art museum", "artwork" };
            item.Points = 71;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Notre Dame";
            item.Type = Item.ItemType.Site;
            item.City = "Paris";
            item.KeyWords = new string[] { "Notre-Dame", "catholic church", "church that burned" };
            item.Points = 81;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Kir";
            item.Type = Item.ItemType.Drink;
            item.City = "Paris";
            item.KeyWords = new string[] { "kir", "blackcurrant" };
            item.Points = 72;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Champagne";
            item.Type = Item.ItemType.Drink;
            item.City = "Paris";
            item.KeyWords = new string[] { "champagne", "sparkling wine", "fizzy" };
            item.Points = 82;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Absinthe";
            item.Type = Item.ItemType.Drink;
            item.City = "Paris";
            item.KeyWords = new string[] { "absinthe", "anise", "forbidden" };
            item.Points = 92;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Earplug";
            item.Type = Item.ItemType.BattleMinor;
            item.City = "Paris";
            item.KeyWords = new string[] { "earplug", "ignore", "away", "counter", "protest", "shout" };
            item.Points = 175;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Water";
            item.Type = Item.ItemType.BattleMajor;
            item.City = "Paris";
            item.KeyWords = new string[] { "water", "douse", "hose", "extinguisher"};
            item.Points = 275;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);
            //
            // add items for next city
            //
            item = new Item();
            item.Name = "Tiramisu";
            item.Type = Item.ItemType.Food;
            item.City = "Rome";
            item.KeyWords = new string[] { "tiramisu", "ladyfingers", "cake" };
            item.Points = 50;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Pizza";
            item.Type = Item.ItemType.Food;
            item.City = "Rome";
            item.KeyWords = new string[] { "pizza" };
            item.Points = 60;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Carbonera";
            item.Type = Item.ItemType.Food;
            item.City = "Rome";
            item.KeyWords = new string[] { "carbonera", "pasta", "pork" };
            item.Points = 70;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Colosseum";
            item.Type = Item.ItemType.Site;
            item.City = "Rome";
            item.KeyWords = new string[] { "colosseum", "arena", "stadium" };
            item.Points = 61;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Trevi Fountain";
            item.Type = Item.ItemType.Site;
            item.City = "Rome";
            item.KeyWords = new string[] { "trevi", "fountain" };
            item.Points = 71;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Vatican";
            item.Type = Item.ItemType.Site;
            item.City = "Rome";
            item.KeyWords = new string[] { "vatican", "pope", "catholic", "church" };
            item.Points = 81;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Wine";
            item.Type = Item.ItemType.Drink;
            item.City = "Rome";
            item.KeyWords = new string[] { "grapes", "wine", "vino" };
            item.Points = 72;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Grappa";
            item.Type = Item.ItemType.Drink;
            item.City = "Rome";
            item.KeyWords = new string[] { "grappa", "moonshine" };
            item.Points = 82;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Limoncello";
            item.Type = Item.ItemType.Drink;
            item.City = "Rome";
            item.KeyWords = new string[] { "limoncello", "lemon", "vodka" };
            item.Points = 92;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Laugh";
            item.Type = Item.ItemType.BattleMinor;
            item.City = "Rome";
            item.KeyWords = new string[] { "laugh", "joke", "pun", "groan", "chuckle" };
            item.Points = 175;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Hide";
            item.Type = Item.ItemType.BattleMajor;
            item.City = "Rome";
            item.KeyWords = new string[] { "hide", "pay", "ransom", "fake"  };
            item.Points = 275;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);
            //
            // add items for next city
            //
            item = new Item();
            item.Name = "Pierogi";
            item.Type = Item.ItemType.Food;
            item.City = "Warsaw";
            item.KeyWords = new string[] { "pierogi", "dumpling" };
            item.Points = 50;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Golabki";
            item.Type = Item.ItemType.Food;
            item.City = "Warsaw";
            item.KeyWords = new string[] { "golabki", "cabbage", "minced meat" };
            item.Points = 60;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Paczki";
            item.Type = Item.ItemType.Food;
            item.City = "Warsaw";
            item.KeyWords = new string[] { "paczki", "doughnut", "donut" };
            item.Points = 70;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Wilanow";
            item.Type = Item.ItemType.Site;
            item.City = "Warsaw";
            item.KeyWords = new string[] { "wilanow", "palace", "monument" };
            item.Points = 61;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Nowy Swict";
            item.Type = Item.ItemType.Site;
            item.City = "Warsaw";
            item.KeyWords = new string[] { "nowy", "historic", "street" };
            item.Points = 71;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Lazienki";
            item.Type = Item.ItemType.Site;
            item.City = "Warsaw";
            item.KeyWords = new string[] { "lazienki", "park", "Royal Baths" };
            item.Points = 81;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Kvass";
            item.Type = Item.ItemType.Drink;
            item.City = "Warsaw";
            item.KeyWords = new string[] { "kvass", "malt", "rye", "black bread" };
            item.Points = 72;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Goldwasser";
            item.Type = Item.ItemType.Drink;
            item.City = "Warsaw";
            item.KeyWords = new string[] { "goldwasser", "liquor", "herb" };
            item.Points = 82;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Kawa";
            item.Type = Item.ItemType.Drink;
            item.City = "Warsaw";
            item.KeyWords = new string[] { "kawa", "coffee", "java", "joe" };
            item.Points = 92;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Ignore";
            item.Type = Item.ItemType.BattleMinor;
            item.City = "Warsaw";
            item.KeyWords = new string[] { "ignore", "see through", "BBB", "too good" };
            item.Points = 175;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Grenade";
            item.Type = Item.ItemType.BattleMajor;
            item.City = "Warsaw";
            item.KeyWords = new string[] { "grenade", "rifle", "bomb", "gun" };
            item.Points = 275;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);
            //
            // add items for next city
            //
            item = new Item();
            item.Name = "Baklava";
            item.Type = Item.ItemType.Food;
            item.City = "Athens";
            item.KeyWords = new string[] { "baklava", "nutty", "phyllo", "pastry" };
            item.Points = 50;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Dolmadakia";
            item.Type = Item.ItemType.Food;
            item.City = "Athens";
            item.KeyWords = new string[] { "dolmadakia", "grape leaves", "stuffed" };
            item.Points = 60;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Tomatokeftedes";
            item.Type = Item.ItemType.Food;
            item.City = "Athens";
            item.KeyWords = new string[] { "tomato", "fritter" };
            item.Points = 70;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Acropolis";
            item.Type = Item.ItemType.Site;
            item.City = "Athens";
            item.KeyWords = new string[] { "acropolis", "ancient", "ruins", "high city" };
            item.Points = 61;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Parthenon";
            item.Type = Item.ItemType.Site;
            item.City = "Athens";
            item.KeyWords = new string[] { "parthenon", "marble", "columns", "square" };
            item.Points = 71;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Santorini";
            item.Type = Item.ItemType.Site;
            item.City = "Athens";
            item.KeyWords = new string[] { "Greek Isle", "isle", "islands", "blue domes" };
            item.Points = 81;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Ouzo";
            item.Type = Item.ItemType.Drink;
            item.City = "Athens";
            item.KeyWords = new string[] { "ouzo", "licorice", "black", "anise" };
            item.Points = 72;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Raki";
            item.Type = Item.ItemType.Drink;
            item.City = "Athens";
            item.KeyWords = new string[] { "raki", "brandy" };
            item.Points = 82;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Tsipouro";
            item.Type = Item.ItemType.Drink;
            item.City = "Athens";
            item.KeyWords = new string[] { "tsipouro", "grape stems", "seeds", "peels" };
            item.Points = 92;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Play dumb";
            item.Type = Item.ItemType.BattleMinor;
            item.City = "Athens";
            item.KeyWords = new string[] { "play", "ignore", "map", "diversion"  };
            item.Points = 175;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Vote";
            item.Type = Item.ItemType.BattleMajor;
            item.City = "Athens";
            item.KeyWords = new string[] { "vote", "tweet", "shutdown", "blackmail"  };
            item.Points = 275;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);
            //
            // Add list of GameStat which holds completed games
            //
            GameStat gameStat = new GameStat();
            gameStat.Name = "GNB";
            gameStat.Startdate = new DateTime(2021, 03, 01, 08, 01, 02);
            gameStat.Enddate = new DateTime(2021, 03, 01, 09, 01, 02);
            gameStat.Score = 1015;
            gameStat.Liveslost = 2;
            gameMap.GameStats.Add(gameStat);

            gameStat = new GameStat();
            gameStat.Name = "GNB";
            gameStat.Startdate = new DateTime(2021, 03, 02, 09, 01, 02);
            gameStat.Enddate = new DateTime(2021, 03, 02, 10, 01, 02);
            gameStat.Score = 1027;
            gameStat.Liveslost = 2;
            gameMap.GameStats.Add(gameStat);

            gameStat = new GameStat();
            gameStat.Name = "HAK";
            gameStat.Startdate = new DateTime(2021, 03, 01, 11, 01, 02);
            gameStat.Enddate = new DateTime(2021, 03, 01, 12, 01, 02);
            gameStat.Score = 850;
            gameStat.Liveslost = 3;
            gameMap.GameStats.Add(gameStat);

            gameStat = new GameStat();
            gameStat.Name = "GNB";
            gameStat.Startdate = new DateTime(2021, 03, 03, 09, 31, 02);
            gameStat.Enddate = new DateTime(2021, 03, 03, 10, 41, 02);
            gameStat.Score = 905;
            gameStat.Liveslost = 4;
            gameMap.GameStats.Add(gameStat);

            gameStat = new GameStat();
            gameStat.Name = "HAK";
            gameStat.Startdate = new DateTime(2021, 03, 04, 11, 01, 02);
            gameStat.Enddate = new DateTime(2021, 03, 04, 11, 59, 02);
            gameStat.Score = 1999;
            gameStat.Liveslost = 1;
            gameMap.GameStats.Add(gameStat);

            gameStat = new GameStat();
            gameStat.Name = "GNB";
            gameStat.Startdate = new DateTime(2021, 03, 05, 06, 01, 02);
            gameStat.Enddate = new DateTime(2021, 03, 05, 07, 01, 02);
            gameStat.Score = 1158;
            gameStat.Liveslost = 1;
            gameMap.GameStats.Add(gameStat);

            return gameMap;
        }
        //
        // This is actually redundant code that was identified after the code was frozen in build 6. It will be eliminated in the next build.
        //
        public static GameHistory PlayerHistory()
        {
            GameHistory gameHistory = new GameHistory();
            //
            // load game history list by force for now. Later, need to read it in from a data file
            //
            GameStat _gameStat = new GameStat();
            _gameStat.Name = "GNB";
            _gameStat.Startdate = new DateTime(2021, 03, 01, 08, 01, 02);
            _gameStat.Enddate = new DateTime(2021, 03, 01, 09, 01, 02);
            _gameStat.Score = 1015;
            _gameStat.Liveslost = 2;
            gameHistory.GameStats.Add(_gameStat);
            
            _gameStat = new GameStat();
            _gameStat.Name = "GNB";
            _gameStat.Startdate = new DateTime(2021, 03, 02, 09, 01, 02);
            _gameStat.Enddate = new DateTime(2021, 03, 02, 10, 01, 02);
            _gameStat.Score = 1027;
            _gameStat.Liveslost = 2;
            gameHistory.GameStats.Add(_gameStat);

            _gameStat = new GameStat();
            _gameStat.Name = "HAK";
            _gameStat.Startdate = new DateTime(2021, 03, 01, 11, 01, 02);
            _gameStat.Enddate = new DateTime(2021, 03, 01, 12, 01, 02);
            _gameStat.Score = 850;
            _gameStat.Liveslost = 3;
            gameHistory.GameStats.Add(_gameStat);

            _gameStat = new GameStat();
            _gameStat.Name = "GNB";
            _gameStat.Startdate = new DateTime(2021, 03, 03, 09, 31, 02);
            _gameStat.Enddate = new DateTime(2021, 03, 03, 10, 41, 02);
            _gameStat.Score = 905;
            _gameStat.Liveslost = 4;
            gameHistory.GameStats.Add(_gameStat);

            _gameStat = new GameStat();
            _gameStat.Name = "HAK";
            _gameStat.Startdate = new DateTime(2021, 03, 04, 11, 01, 02);
            _gameStat.Enddate = new DateTime(2021, 03, 04, 11, 59, 02);
            _gameStat.Score = 1999;
            _gameStat.Liveslost = 1;
            gameHistory.GameStats.Add(_gameStat);

            _gameStat = new GameStat();
            _gameStat.Name = "GNB";
            _gameStat.Startdate = new DateTime(2021, 03, 05, 06, 01, 02);
            _gameStat.Enddate = new DateTime(2021, 03, 05, 07, 01, 02);
            _gameStat.Score = 1158;
            _gameStat.Liveslost = 1;
            gameHistory.GameStats.Add(_gameStat);
 
            return gameHistory;
        }
    }
}
