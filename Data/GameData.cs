using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelGame.Models;

namespace TravelGame.Data
{
    public static class GameData
    {
        public static Player PlayerData()
        {
            return new Player()
            {
                StartDate = DateTime.Now,
                //Name = "GNB",
                Experience = 0,
                Bestscore = 1977,
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
            // taskstate list (each city to visit and the results of tasks to complete at each one)
            // locationitems (each city to visit and the actors, their role, and choices to drive interaction)
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

            gameMap.CurrentLocation = gameMap.LocationList[0];

            //
            // Load the list of Npcs which hold key words for each city/type
            //
            Npc npc = new Npc();
            npc.Id = 1000;
            npc.Name = "John";
            npc.Language = "English";
            npc.ActorType = Npc.NpcType.Driver;
            npc.City = "London";
            npc.KeyWords = new string[] { "drive", "motor", "take", "ride", "lift" };
            npc.IdPoints = 75;
            npc.CompletionPoints = 100;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);

            npc = new Npc();
            npc.Id = 1010;
            npc.Name = "Paul";
            npc.Language = "English";
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
            npc.City = "London";
            npc.KeyWords = new string[] { "mix", "poor", "set up", "have", "drink", "sip" };
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
            npc.City = "London";
            npc.KeyWords = new string[] { "battle", "war", "attack" };
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
            npc.City = "London";
            npc.KeyWords = new string[] { "battle", "war", "attack" };
            npc.IdPoints = 125;
            npc.CompletionPoints = 230;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);
            //
            // actors for next city
            //
            npc = new Npc();
            npc.Id = 2000;
            npc.Name = "Astrid";
            npc.Language = "English";
            npc.ActorType = Npc.NpcType.Driver;
            npc.City = "Frankfort";
            npc.KeyWords = new string[] { "drive", "motor", "take", "ride", "lift" };
            npc.IdPoints = 75;
            npc.CompletionPoints = 100;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);

            npc = new Npc();
            npc.Id = 2010;
            npc.Name = "Gretel";
            npc.Language = "English";
            npc.ActorType = Npc.NpcType.Chef;
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
            npc.Language = "English";
            npc.ActorType = Npc.NpcType.Bartender;
            npc.City = "Frankfort";
            npc.KeyWords = new string[] { "mix", "poor", "set up", "have", "drink", "sip" };
            npc.IdPoints = 95;
            npc.CompletionPoints = 120;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);

            npc = new Npc();
            npc.Id = 2030;
            npc.Name = "Hans";
            npc.Language = "English";
            npc.ActorType = Npc.NpcType.InterloperMinor;
            npc.City = "Frankfort";
            npc.KeyWords = new string[] { "battle", "war", "attack" };
            npc.IdPoints = 105;
            npc.CompletionPoints = 200;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);

            npc = new Npc();
            npc.Id = 2040;
            npc.Name = "Adolph";
            npc.Language = "English";
            npc.ActorType = Npc.NpcType.InterloperMajor;
            npc.City = "Frankfort";
            npc.KeyWords = new string[] { "battle", "war", "attack" };
            npc.IdPoints = 125;
            npc.CompletionPoints = 230;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);
            //
            // actors for next city
            //
            npc = new Npc();
            npc.Id = 1000;
            npc.Name = "Pohn";
            npc.Language = "English";
            npc.ActorType = Npc.NpcType.Driver;
            npc.City = "Paris";
            npc.KeyWords = new string[] { "drive", "motor", "take", "ride", "lift" };
            npc.IdPoints = 75;
            npc.CompletionPoints = 100;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);

            npc = new Npc();
            npc.Id = 1010;
            npc.Name = "PPul";
            npc.Language = "English";
            npc.ActorType = Npc.NpcType.Chef;
            npc.City = "Paris";
            npc.KeyWords = new string[] { "cook", "feed", "prepare", "eat", "dine", "taste" };
            npc.IdPoints = 85;
            npc.CompletionPoints = 110;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);

            npc = new Npc();
            npc.Id = 1020;
            npc.Name = "Peorge";
            npc.Language = "English";
            npc.ActorType = Npc.NpcType.Bartender;
            npc.City = "Paris";
            npc.KeyWords = new string[] { "mix", "poor", "set up", "have", "drink", "sip" };
            npc.IdPoints = 95;
            npc.CompletionPoints = 120;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);

            npc = new Npc();
            npc.Id = 1030;
            npc.Name = "Pingo";
            npc.Language = "English";
            npc.ActorType = Npc.NpcType.InterloperMinor;
            npc.City = "Paris";
            npc.KeyWords = new string[] { "battle", "war", "attack" };
            npc.IdPoints = 105;
            npc.CompletionPoints = 200;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);

            npc = new Npc();
            npc.Id = 1040;
            npc.Name = "Prian";
            npc.Language = "English";
            npc.ActorType = Npc.NpcType.InterloperMajor;
            npc.City = "Paris";
            npc.KeyWords = new string[] { "battle", "war", "attack" };
            npc.IdPoints = 125;
            npc.CompletionPoints = 230;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);
            //
            // actors for next city
            //
            npc = new Npc();
            npc.Id = 1000;
            npc.Name = "Rohn";
            npc.Language = "English";
            npc.ActorType = Npc.NpcType.Driver;
            npc.City = "Rome";
            npc.KeyWords = new string[] { "drive", "motor", "take", "ride", "lift" };
            npc.IdPoints = 75;
            npc.CompletionPoints = 100;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);

            npc = new Npc();
            npc.Id = 1010;
            npc.Name = "Raul";
            npc.Language = "English";
            npc.ActorType = Npc.NpcType.Chef;
            npc.City = "Rome";
            npc.KeyWords = new string[] { "cook", "feed", "prepare", "eat", "dine", "taste" };
            npc.IdPoints = 85;
            npc.CompletionPoints = 110;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);

            npc = new Npc();
            npc.Id = 1020;
            npc.Name = "Reorge";
            npc.Language = "English";
            npc.ActorType = Npc.NpcType.Bartender;
            npc.City = "Rome";
            npc.KeyWords = new string[] { "mix", "poor", "set up", "have", "drink", "sip" };
            npc.IdPoints = 95;
            npc.CompletionPoints = 120;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);

            npc = new Npc();
            npc.Id = 1030;
            npc.Name = "RPingo";
            npc.Language = "English";
            npc.ActorType = Npc.NpcType.InterloperMinor;
            npc.City = "Rome";
            npc.KeyWords = new string[] { "battle", "war", "attack" };
            npc.IdPoints = 105;
            npc.CompletionPoints = 200;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);

            npc = new Npc();
            npc.Id = 1040;
            npc.Name = "Rrian";
            npc.Language = "English";
            npc.ActorType = Npc.NpcType.InterloperMajor;
            npc.City = "Rome";
            npc.KeyWords = new string[] { "battle", "war", "attack" };
            npc.IdPoints = 125;
            npc.CompletionPoints = 230;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);
            //
            // actors for next city
            //
            npc = new Npc();
            npc.Id = 1000;
            npc.Name = "Wohn";
            npc.Language = "English";
            npc.ActorType = Npc.NpcType.Driver;
            npc.City = "Warsaw";
            npc.KeyWords = new string[] { "drive", "motor", "take", "ride", "lift" };
            npc.IdPoints = 75;
            npc.CompletionPoints = 100;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);

            npc = new Npc();
            npc.Id = 1010;
            npc.Name = "Waul";
            npc.Language = "English";
            npc.ActorType = Npc.NpcType.Chef;
            npc.City = "Warsaw";
            npc.KeyWords = new string[] { "cook", "feed", "prepare", "eat", "dine", "taste" };
            npc.IdPoints = 85;
            npc.CompletionPoints = 110;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);

            npc = new Npc();
            npc.Id = 1020;
            npc.Name = "Weorge";
            npc.Language = "English";
            npc.ActorType = Npc.NpcType.Bartender;
            npc.City = "Warsaw";
            npc.KeyWords = new string[] { "mix", "poor", "set up", "have", "drink", "sip" };
            npc.IdPoints = 95;
            npc.CompletionPoints = 120;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);

            npc = new Npc();
            npc.Id = 1030;
            npc.Name = "Wingo";
            npc.Language = "English";
            npc.ActorType = Npc.NpcType.InterloperMinor;
            npc.City = "Warsaw";
            npc.KeyWords = new string[] { "battle", "war", "attack" };
            npc.IdPoints = 105;
            npc.CompletionPoints = 200;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);

            npc = new Npc();
            npc.Id = 1040;
            npc.Name = "Wrian";
            npc.Language = "English";
            npc.ActorType = Npc.NpcType.InterloperMajor;
            npc.City = "Warsaw";
            npc.KeyWords = new string[] { "battle", "war", "attack" };
            npc.IdPoints = 125;
            npc.CompletionPoints = 230;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);
            //
            // actors for next city
            //
            npc = new Npc();
            npc.Id = 1000;
            npc.Name = "Aohn";
            npc.Language = "English";
            npc.ActorType = Npc.NpcType.Driver;
            npc.City = "Athens";
            npc.KeyWords = new string[] { "drive", "motor", "take", "ride", "lift" };
            npc.IdPoints = 75;
            npc.CompletionPoints = 100;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);

            npc = new Npc();
            npc.Id = 1010;
            npc.Name = "Aaul";
            npc.Language = "English";
            npc.ActorType = Npc.NpcType.Chef;
            npc.City = "Athens";
            npc.KeyWords = new string[] { "cook", "feed", "prepare", "eat", "dine", "taste" };
            npc.IdPoints = 85;
            npc.CompletionPoints = 110;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);

            npc = new Npc();
            npc.Id = 1020;
            npc.Name = "Aeorge";
            npc.Language = "English";
            npc.ActorType = Npc.NpcType.Bartender;
            npc.City = "Athens";
            npc.KeyWords = new string[] { "mix", "poor", "set up", "have", "drink", "sip" };
            npc.IdPoints = 95;
            npc.CompletionPoints = 120;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);

            npc = new Npc();
            npc.Id = 1030;
            npc.Name = "Aingo";
            npc.Language = "English";
            npc.ActorType = Npc.NpcType.InterloperMinor;
            npc.City = "Athens";
            npc.KeyWords = new string[] { "battle", "war", "attack" };
            npc.IdPoints = 105;
            npc.CompletionPoints = 200;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);

            npc = new Npc();
            npc.Id = 1040;
            npc.Name = "Arian";
            npc.Language = "English";
            npc.ActorType = Npc.NpcType.InterloperMajor;
            npc.City = "Athens";
            npc.KeyWords = new string[] { "battle", "war", "attack" };
            npc.IdPoints = 125;
            npc.CompletionPoints = 230;
            npc.IsIded = false;
            npc.IsComplete = false;
            gameMap.Npcs.Add(npc);
            //
            // Load Items - Foods, Drinks, Sites, and Battles
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
            item.Name = "Loudspeaker";
            item.Type = Item.ItemType.BattleMinor;
            item.City = "London";
            item.KeyWords = new string[] { "loudspeaker", "speaker", "yell", "raise your voice", "protest" };
            item.Points = 175;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Knife";
            item.Type = Item.ItemType.BattleMajor;
            item.City = "London";
            item.KeyWords = new string[] { "knife", "sharp", "shiv", "dagger", "sword" };
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
            item.Name = "Loudspeaker";
            item.Type = Item.ItemType.BattleMinor;
            item.City = "Frankfort";
            item.KeyWords = new string[] { "loudspeaker", "speaker", "yell", "raise your voice", "protest" };
            item.Points = 175;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "Knife";
            item.Type = Item.ItemType.BattleMajor;
            item.City = "Frankfort";
            item.KeyWords = new string[] { "knife", "sharp", "shiv", "dagger", "sword" };
            item.Points = 275;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            //
            // add items for next city
            //
            item = new Item();
            item.Name = "pBratwurst";
            item.Type = Item.ItemType.Food;
            item.City = "Paris";
            item.KeyWords = new string[] { "brats", "sausage", "Brats", "Sausage" };
            item.Points = 50;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "pWiener Schnitzel";
            item.Type = Item.ItemType.Food;
            item.City = "Paris";
            item.KeyWords = new string[] { "veal", "wiener", "weiner", "schnitzel", "snitzel" };
            item.Points = 60;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "ppretzel";
            item.Type = Item.ItemType.Food;
            item.City = "Paris";
            item.KeyWords = new string[] { "pretzel" };
            item.Points = 70;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "pChristmas Market";
            item.Type = Item.ItemType.Site;
            item.City = "Paris";
            item.KeyWords = new string[] { "market", "christmas", "xmas" };
            item.Points = 61;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "pRomerberg";
            item.Type = Item.ItemType.Site;
            item.City = "Paris";
            item.KeyWords = new string[] { "romerberg", "old town", "center", "square" };
            item.Points = 71;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "pStadel";
            item.Type = Item.ItemType.Site;
            item.City = "Paris";
            item.KeyWords = new string[] { "stadel", "museum", "art" };
            item.Points = 81;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "pPilsner";
            item.Type = Item.ItemType.Drink;
            item.City = "Paris";
            item.KeyWords = new string[] { "pilsner", "beer", "pils", "lager" };
            item.Points = 72;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "pSpezi";
            item.Type = Item.ItemType.Drink;
            item.City = "Paris";
            item.KeyWords = new string[] { "spezi", "orange", "cola" };
            item.Points = 82;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "pRiesling";
            item.Type = Item.ItemType.Drink;
            item.City = "Paris";
            item.KeyWords = new string[] { "riesling", "sweet wine", "white wine" };
            item.Points = 92;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "pLoudspeaker";
            item.Type = Item.ItemType.BattleMinor;
            item.City = "Paris";
            item.KeyWords = new string[] { "loudspeaker", "speaker", "yell", "raise your voice", "protest" };
            item.Points = 175;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "pKnife";
            item.Type = Item.ItemType.BattleMajor;
            item.City = "Paris";
            item.KeyWords = new string[] { "knife", "sharp", "shiv", "dagger", "sword" };
            item.Points = 275;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            //
            // add items for next city
            //
            item = new Item();
            item.Name = "rBratwurst";
            item.Type = Item.ItemType.Food;
            item.City = "Rome";
            item.KeyWords = new string[] { "brats", "sausage", "Brats", "Sausage" };
            item.Points = 50;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "rWiener Schnitzel";
            item.Type = Item.ItemType.Food;
            item.City = "Rome";
            item.KeyWords = new string[] { "veal", "wiener", "weiner", "schnitzel", "snitzel" };
            item.Points = 60;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "rpretzel";
            item.Type = Item.ItemType.Food;
            item.City = "Rome";
            item.KeyWords = new string[] { "pretzel" };
            item.Points = 70;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "rChristmas Market";
            item.Type = Item.ItemType.Site;
            item.City = "Rome";
            item.KeyWords = new string[] { "market", "christmas", "xmas" };
            item.Points = 61;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "rRomerberg";
            item.Type = Item.ItemType.Site;
            item.City = "Rome";
            item.KeyWords = new string[] { "romerberg", "old town", "center", "square" };
            item.Points = 71;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "rStadel";
            item.Type = Item.ItemType.Site;
            item.City = "Rome";
            item.KeyWords = new string[] { "stadel", "museum", "art" };
            item.Points = 81;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "rPilsner";
            item.Type = Item.ItemType.Drink;
            item.City = "Rome";
            item.KeyWords = new string[] { "pilsner", "beer", "pils", "lager" };
            item.Points = 72;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "rSpezi";
            item.Type = Item.ItemType.Drink;
            item.City = "Rome";
            item.KeyWords = new string[] { "spezi", "orange", "cola" };
            item.Points = 82;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "rRiesling";
            item.Type = Item.ItemType.Drink;
            item.City = "Rome";
            item.KeyWords = new string[] { "riesling", "sweet wine", "white wine" };
            item.Points = 92;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "rLoudspeaker";
            item.Type = Item.ItemType.BattleMinor;
            item.City = "Rome";
            item.KeyWords = new string[] { "loudspeaker", "speaker", "yell", "raise your voice", "protest" };
            item.Points = 175;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "rKnife";
            item.Type = Item.ItemType.BattleMajor;
            item.City = "Rome";
            item.KeyWords = new string[] { "knife", "sharp", "shiv", "dagger", "sword" };
            item.Points = 275;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            //
            // add items for next city
            //
            item = new Item();
            item.Name = "wBratwurst";
            item.Type = Item.ItemType.Food;
            item.City = "Warsaw";
            item.KeyWords = new string[] { "brats", "sausage", "Brats", "Sausage" };
            item.Points = 50;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "wWiener Schnitzel";
            item.Type = Item.ItemType.Food;
            item.City = "Warsaw";
            item.KeyWords = new string[] { "veal", "wiener", "weiner", "schnitzel", "snitzel" };
            item.Points = 60;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "wpretzel";
            item.Type = Item.ItemType.Food;
            item.City = "Warsaw";
            item.KeyWords = new string[] { "pretzel" };
            item.Points = 70;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "wChristmas Market";
            item.Type = Item.ItemType.Site;
            item.City = "Warsaw";
            item.KeyWords = new string[] { "market", "christmas", "xmas" };
            item.Points = 61;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "wRomerberg";
            item.Type = Item.ItemType.Site;
            item.City = "Warsaw";
            item.KeyWords = new string[] { "romerberg", "old town", "center", "square" };
            item.Points = 71;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "wStadel";
            item.Type = Item.ItemType.Site;
            item.City = "Warsaw";
            item.KeyWords = new string[] { "stadel", "museum", "art" };
            item.Points = 81;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "wPilsner";
            item.Type = Item.ItemType.Drink;
            item.City = "Warsaw";
            item.KeyWords = new string[] { "pilsner", "beer", "pils", "lager" };
            item.Points = 72;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "wSpezi";
            item.Type = Item.ItemType.Drink;
            item.City = "Warsaw";
            item.KeyWords = new string[] { "spezi", "orange", "cola" };
            item.Points = 82;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "wRiesling";
            item.Type = Item.ItemType.Drink;
            item.City = "Warsaw";
            item.KeyWords = new string[] { "riesling", "sweet wine", "white wine" };
            item.Points = 92;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "wLoudspeaker";
            item.Type = Item.ItemType.BattleMinor;
            item.City = "Warsaw";
            item.KeyWords = new string[] { "loudspeaker", "speaker", "yell", "raise your voice", "protest" };
            item.Points = 175;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "wKnife";
            item.Type = Item.ItemType.BattleMajor;
            item.City = "Warsaw";
            item.KeyWords = new string[] { "knife", "sharp", "shiv", "dagger", "sword" };
            item.Points = 275;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            //
            // add items for next city
            //
            item = new Item();
            item.Name = "aBratwurst";
            item.Type = Item.ItemType.Food;
            item.City = "Athens";
            item.KeyWords = new string[] { "brats", "sausage", "Brats", "Sausage" };
            item.Points = 50;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "aWiener Schnitzel";
            item.Type = Item.ItemType.Food;
            item.City = "Athens";
            item.KeyWords = new string[] { "veal", "wiener", "weiner", "schnitzel", "snitzel" };
            item.Points = 60;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "apretzel";
            item.Type = Item.ItemType.Food;
            item.City = "Athens";
            item.KeyWords = new string[] { "pretzel" };
            item.Points = 70;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "aChristmas Market";
            item.Type = Item.ItemType.Site;
            item.City = "Athens";
            item.KeyWords = new string[] { "market", "christmas", "xmas" };
            item.Points = 61;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "aRomerberg";
            item.Type = Item.ItemType.Site;
            item.City = "Athens";
            item.KeyWords = new string[] { "romerberg", "old town", "center", "square" };
            item.Points = 71;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "aStadel";
            item.Type = Item.ItemType.Site;
            item.City = "Athens";
            item.KeyWords = new string[] { "stadel", "museum", "art" };
            item.Points = 81;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "aPilsner";
            item.Type = Item.ItemType.Drink;
            item.City = "Athens";
            item.KeyWords = new string[] { "pilsner", "beer", "pils", "lager" };
            item.Points = 72;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "aSpezi";
            item.Type = Item.ItemType.Drink;
            item.City = "Athens";
            item.KeyWords = new string[] { "spezi", "orange", "cola" };
            item.Points = 82;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "aRiesling";
            item.Type = Item.ItemType.Drink;
            item.City = "Athens";
            item.KeyWords = new string[] { "riesling", "sweet wine", "white wine" };
            item.Points = 92;
            item.Servings = 0;
            item.Limit = 3;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "aLoudspeaker";
            item.Type = Item.ItemType.BattleMinor;
            item.City = "Athens";
            item.KeyWords = new string[] { "loudspeaker", "speaker", "yell", "raise your voice", "protest" };
            item.Points = 175;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);

            item = new Item();
            item.Name = "aKnife";
            item.Type = Item.ItemType.BattleMajor;
            item.City = "Athens";
            item.KeyWords = new string[] { "knife", "sharp", "shiv", "dagger", "sword" };
            item.Points = 275;
            item.Servings = 0;
            item.Limit = 1;
            item.Diminish = .9;
            gameMap.Items.Add(item);

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
