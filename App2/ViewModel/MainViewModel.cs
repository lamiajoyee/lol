using App2.Model;
using GalaSoft.MvvmLight;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Collections.ObjectModel;
using App2.Helper;
using GalaSoft.MvvmLight.Command;

namespace App2.ViewModel
{

    public class MainViewModel : ViewModelBase, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
       
        public MainViewModel()
        {
            GiveDetails = new RelayCommand<object>(DoSomething);
            this.AllPlayers = new ObservableCollection<Players>();
            this.AllAbilities = new ObservableCollection<Abilities>();

            this.AllItems = new ObservableCollection<Items>();
            this.AllBuildsInto = new ObservableCollection<Items>();
            this.AllEnchantments = new ObservableCollection<Items>();
            this.AllRecipes = new ObservableCollection<Items>();
            
            if (IsInDesignMode)
            {
                // Code runs in Blend --> create design time data.
               // LoadData();
            }
            else
            {
                // Code runs "for real"
                LoadData();
            }
        }
        public RelayCommand<object> GiveDetails { get; private set; }
        private void DoSomething(object param)
        {
            int i = 0;
            //var hehe = this.ID;
            //var rootFrame = (App.Current as App).RootFrame;
            //rootFrame.Navigate(new System.Uri("/Details.xaml?ID=" + hehe.ToString(), System.UriKind.Relative));
        }
        public ObservableCollection<Players> AllPlayers { get; private set; }
        public ObservableCollection<Abilities> AllAbilities { get; private set; }
        
        public ObservableCollection<Items> AllItems { get; private set; }
        public ObservableCollection<Items> AllBuildsInto { get; private set; }
        public ObservableCollection<Items> AllEnchantments { get; private set; }
        public ObservableCollection<Items> AllRecipes { get; private set; }

        private ObservableCollection<GroupInfoList> groupedExemple;
        public ObservableCollection<GroupInfoList> GroupedExemple
        {
            get { return groupedExemple; }
            set { groupedExemple = value; RaisePropertyChanged(); }
        }

        public void LoadData()
        {
            this.AllPlayers.Add(new Players()
            {
                id = 1,
                img = "/SampleData/SampleDataSource/SampleDataSource_Files/image01.png",
                imgBig = "/SampleData/SampleDataSource/SampleDataSource_Files/aatrox.png",
                playername = "Aatrox",
                playertitle = "the Judicator",
                primary_secondary = "Fighter/Support",
                IP = 2350,
                RP = 326, 
            });    

            this.AllPlayers.Add(new Players() { 
                id = 2, 
                img = "/SampleData/SampleDataSource/SampleDataSource_Files/image02.png", 
                imgBig = "/SampleData/SampleDataSource/SampleDataSource_Files/mordekaiser.png", 
                playername = "Mordekaiser", 
                playertitle = "the Master of Metal", 
                primary_secondary = "Fighter/Support", 
                IP = 3243, 
                RP = 325
            });
            
            this.AllPlayers.Add(new Players() { 
                id = 3, 
                img = "/SampleData/SampleDataSource/SampleDataSource_Files/image03.png", 
                imgBig = "/SampleData/SampleDataSource/SampleDataSource_Files/alistar.png", 
                playername = "Tryndamere", 
                playertitle = "the Barbarian King", 
                primary_secondary = "Fighter/Support", 
                IP = 2344, 
                RP = 532
            });
            
            this.AllPlayers.Add(new Players() { 
                id = 4, 
                img = "/SampleData/SampleDataSource/SampleDataSource_Files/image04.png", 
                imgBig = "/SampleData/SampleDataSource/SampleDataSource_Files/fiddlesticks.png", 
                playername = "Twisted Fate", 
                playertitle = "the Card Master", 
                primary_secondary = "Fighter/Support", 
                IP = 2123, 
                RP = 320 
            });
            
            this.AllPlayers.Add(new Players() { 
                id = 5, 
                img = "/SampleData/SampleDataSource/SampleDataSource_Files/image05.png", 
                imgBig = "/SampleData/SampleDataSource/SampleDataSource_Files/gangplank.png", 
                playername = "Gangplank", 
                playertitle = "the Saltwater Scourge", 
                primary_secondary = "Fighter/Support", 
                IP = 4423, 
                RP = 432 
            });
            
            this.AllPlayers.Add(new Players() { 
                id = 6, 
                img = "/SampleData/SampleDataSource/SampleDataSource_Files/image06.png", 
                imgBig = "/SampleData/SampleDataSource/SampleDataSource_Files/janna.png", 
                playername = "Soraka", 
                playertitle = "the Starchild", 
                primary_secondary = "Fighter/Support", 
                IP = 4523, 
                RP = 732 
            });
            
            this.AllPlayers.Add(new Players() { 
                id = 7, 
                img = "/SampleData/SampleDataSource/SampleDataSource_Files/image07.png", 
                imgBig = "/SampleData/SampleDataSource/SampleDataSource_Files/kayle.png", 
                playername = "Katarina", 
                playertitle = "the Judicator", 
                primary_secondary = "Fighter/Support", 
                IP = 4523, 
                RP = 324 
            });
            
            this.AllPlayers.Add(new Players() { 
                id = 8, 
                img = "/SampleData/SampleDataSource/SampleDataSource_Files/image08.png", 
                imgBig = "/SampleData/SampleDataSource/SampleDataSource_Files/rayze.png", 
                playername = "Fiddlesticks", 
                playertitle = "the Judicator", 
                primary_secondary = "Fighter/Support", 
                IP = 2453, 
                RP = 342 
            });
            
            this.AllPlayers.Add(new Players() { 
                id = 9, 
                img = "/SampleData/SampleDataSource/SampleDataSource_Files/image09.png", 
                imgBig = "/SampleData/SampleDataSource/SampleDataSource_Files/sona.png", 
                playername = "Sejuani", 
                playertitle = "the Judicator", 
                primary_secondary = "Fighter/Support", 
                IP = 234, 
                RP = 322 
            });
            
            this.AllPlayers.Add(new Players() { 
                id = 10, 
                img = "/SampleData/SampleDataSource/SampleDataSource_Files/image10.png", 
                imgBig = "/SampleData/SampleDataSource/SampleDataSource_Files/aatrox.png", 
                playername = "Annie", 
                playertitle = "the Judicator",
                primary_secondary = "Fighter/Support", 
                IP = 243, 
                RP = 332 
            });
           
            // Abilities
            this.AllAbilities.Add(new Abilities()
            {
                ability="Blood Well",
                imgAbility = "/SampleData/SampleDataSource/SampleDataSource_Files/Blood_Well.jpg",
                abilityDesc = "Aatrox's attack speed is increased by 0.6 / 0.7 / 0.8 / 0.9 / 1 / 1.1% for every 2% in his Blood Well, up to a maximum of 30 / 35 / 40 / 45 / 50 / 55% bonus attack speed."
            });

            this.AllAbilities.Add(new Abilities()
            {
                ability = "Blood Price",
                imgAbility = "/SampleData/SampleDataSource/SampleDataSource_Files/Blood_Price.jpg",
                abilityDesc = "ACTIVE: Aatrox takes flight and slams down at the target area after a brief delay, dealing physical damage to nearby enemies upon landing and Airborne icon knocking up enemies in the epicenter for 1 second."
            });

            this.AllAbilities.Add(new Abilities()
            {
                ability = "Blood Thirst",
                imgAbility = "/SampleData/SampleDataSource/SampleDataSource_Files/Blood_Thirst.jpg",
                abilityDesc = "TOGGLE OFF: On every third basic attack, Aatrox heals himself. When Aatrox is below 50% of his maximum health, the amount of health restored is tripled."
            });

            this.AllAbilities.Add(new Abilities()
            {
                ability = "Dark Flight",
                imgAbility = "/SampleData/SampleDataSource/SampleDataSource_Files/Dark_Flight.jpg",
                abilityDesc = "TOGGLE ON: On every third basic attack, Aatrox deals additional physical damage at the expense of health"
            });

            this.AllAbilities.Add(new Abilities()
            {
                ability = "Blades of Torment",
                imgAbility = "/SampleData/SampleDataSource/SampleDataSource_Files/Blades_of_Torment.jpg",
                abilityDesc = "ACTIVE: Aatrox unleashes two energy waves that converge in the target direction, dealing magic damage and Slow icon slowing enemies by 40% for several seconds"
            });

            this.AllAbilities.Add(new Abilities()
            {
                ability = "Massacre",
                imgAbility = "/SampleData/SampleDataSource/SampleDataSource_Files/Massacre.jpg",
                abilityDesc = "ACTIVE: Aatrox draws in the blood of his foes, dealing magic damage to all nearby enemy champions and gaining bonus attack speed and 175 attack range (325 total range) for 12 seconds."
            });

            // Items
            this.AllItems.Add(new Items()
            {
                itemName="Ancient Tome",
                itemImg = "/SampleData/SampleDataSource/SampleDataSource_Files/Amplifying_Tome_item.png",
                itemBonuses = "+20 Ability Power",
                itemCost = "435g",
                active = "Unique: Grants a shield that absorbs up to 30 + (10 per level) damage. This shield refreshes after 9 seconds without receiving damage.",
                passive = "Refreshes after 9 seconds without receiving damage"

            });

            this.AllItems.Add(new Items()
            {
                itemName = "Ancient Coin",
                itemImg = "/SampleData/SampleDataSource/SampleDataSource_Files/Ancient_coin_item.png",
                itemBonuses = "+25% Mana Regen per 5 seconds",
                itemCost = "365g",
                active = "Unique: Grants a shield that absorbs up to 30 + (10 per level) damage. This shield refreshes after 9 seconds without receiving damage.",
                passive = "Refreshes after 9 seconds without receiving damage"

            });

            this.AllItems.Add(new Items()
            {
                itemName = "B.F. Sword",
                itemImg = "/SampleData/SampleDataSource/SampleDataSource_Files/B._F._Sword_item.png",
                itemBonuses = "+50 Attack Damage",
                itemCost = "1550g",
                active = "Unique: Grants a shield that absorbs up to 30 + (10 per level) damage. This shield refreshes after 9 seconds without receiving damage.",
                passive = "Refreshes after 9 seconds without receiving damage"

            });

            this.AllItems.Add(new Items()
            {
                itemName = "Blasting Wand",
                itemImg = "/SampleData/SampleDataSource/SampleDataSource_Files/Blasting_Wand_item.png",
                itemBonuses = "+40 Ability Power",
                itemCost = "860g",
                active = "Unique: Grants a shield that absorbs up to 30 + (10 per level) damage. This shield refreshes after 9 seconds without receiving damage.",
                passive = "Refreshes after 9 seconds without receiving damage"

            });

            this.AllItems.Add(new Items()
            {
                itemName = "Boots of Speed",
                itemImg = "/SampleData/SampleDataSource/SampleDataSource_Files/Boots_of_Speed_item.png",
                itemBonuses = "N/A",
                itemCost = "325g",
                active = "Unique: Grants a shield that absorbs up to 30 + (10 per level) damage. This shield refreshes after 9 seconds without receiving damage.",
                passive = "Refreshes after 9 seconds without receiving damage"

            });

            this.AllItems.Add(new Items()
            {
                itemName = "Brawler's Gloves",
                itemImg = "/SampleData/SampleDataSource/SampleDataSource_Files/Brawler's_Gloves_item.png",
                itemBonuses = "+8% Critical Strike Chance",
                itemCost = "400g",
                active = "Unique: Grants a shield that absorbs up to 30 + (10 per level) damage. This shield refreshes after 9 seconds without receiving damage.",
                passive = "Refreshes after 9 seconds without receiving damage"

            });

            this.AllItems.Add(new Items()
            {
                itemName = "Cloak of Agility",
                itemImg = "/SampleData/SampleDataSource/SampleDataSource_Files/Cloak_of_Agility_item.png",
                itemBonuses = "+15% Critical Strike Chance",
                itemCost = "535g",
                active = "Unique: Grants a shield that absorbs up to 30 + (10 per level) damage. This shield refreshes after 9 seconds without receiving damage.",
                passive = "Refreshes after 9 seconds without receiving damage"

            });

            this.AllItems.Add(new Items()
            {
                itemName = "Cloth Armor",
                itemImg = "/SampleData/SampleDataSource/SampleDataSource_Files/Cloth_Armor_item.png",
                itemBonuses = "+15 Armor",
                itemCost = "300g",
                active = "Unique: Grants a shield that absorbs up to 30 + (10 per level) damage. This shield refreshes after 9 seconds without receiving damage.",
                passive = "Refreshes after 9 seconds without receiving damage"

            });

            this.AllItems.Add(new Items()
            {
                itemName = "Dagger Item",
                itemImg = "/SampleData/SampleDataSource/SampleDataSource_Files/Dagger_item.png",
                itemBonuses = "+50 Attack Damage",
                itemCost = "1550g",
                active = "Unique: Grants a shield that absorbs up to 30 + (10 per level) damage. This shield refreshes after 9 seconds without receiving damage.",
                passive = "Refreshes after 9 seconds without receiving damage"

            });

            this.AllItems.Add(new Items()
            {
                itemName = "Doran's Blade",
                itemImg = "/SampleData/SampleDataSource/SampleDataSource_Files/Doran's_Blade_item.png",
                itemBonuses = "+70 Health +7 Attack Damage  +3% Lifesteal",
                itemCost = "440g",
                active = "Unique: Grants a shield that absorbs up to 30 + (10 per level) damage. This shield refreshes after 9 seconds without receiving damage.",
                passive = "Refreshes after 9 seconds without receiving damage"

            });

            this.AllItems.Add(new Items()
            {
                itemName = "Doran's Ring",
                itemImg = "/SampleData/SampleDataSource/SampleDataSource_Files/Doran's_Ring_item.png",
                itemBonuses = "N/A",
                itemCost = "325g",
                active = "Unique: Grants a shield that absorbs up to 30 + (10 per level) damage. This shield refreshes after 9 seconds without receiving damage.",
                passive = "Refreshes after 9 seconds without receiving damage"

            });

            this.AllItems.Add(new Items()
            {
                itemName = "Doran's Shield",
                itemImg = "/SampleData/SampleDataSource/SampleDataSource_Files/Doran's_Shield_item.png",
                itemBonuses = "+8% Critical Strike Chance",
                itemCost = "700g",
                active = "Unique: Grants a shield that absorbs up to 30 + (10 per level) damage. This shield refreshes after 9 seconds without receiving damage.",
                passive = "Refreshes after 9 seconds without receiving damage"

            });

            this.AllItems.Add(new Items()
            {
                itemName = "Faerie Charm",
                itemImg = "/SampleData/SampleDataSource/SampleDataSource_Files/Faerie_Charm_item.png",
                itemBonuses = "N/A",
                itemCost = "325g",
                active = "Unique: Grants a shield that absorbs up to 30 + (10 per level) damage. This shield refreshes after 9 seconds without receiving damage.",
                passive = "Refreshes after 9 seconds without receiving damage"

            });

            this.AllItems.Add(new Items()
            {
                itemName = "Hunter's Machete",
                itemImg = "/SampleData/SampleDataSource/SampleDataSource_Files/Hunter's_Machete_item.png",
                itemBonuses = "+8% Critical Strike Chance",
                itemCost = "700g",
                active = "Unique: Grants a shield that absorbs up to 30 + (10 per level) damage. This shield refreshes after 9 seconds without receiving damage.",
                passive = "Refreshes after 9 seconds without receiving damage"
            });


            // Builds Into
            this.AllBuildsInto.Add(new Items()
            {
                itemName = "Ancient Tome",
                itemImg = "/SampleData/SampleDataSource/SampleDataSource_Files/Aegis_of_the_Legion_item.png",
                itemBonuses = "+20 Ability Power",
                itemCost = "435g",
                active = "Unique: Grants a shield that absorbs up to 30 + (10 per level) damage. This shield refreshes after 9 seconds without receiving damage.",
                passive = "Refreshes after 9 seconds without receiving damage"

            });

            this.AllBuildsInto.Add(new Items()
            {
                itemName = "Chalice of Harmony",
                itemImg = "/SampleData/SampleDataSource/SampleDataSource_Files/Chalice_of_Harmony_item.png",
                itemBonuses = "+25% Mana Regen per 5 seconds",
                itemCost = "365g",
                active = "Unique: Grants a shield that absorbs up to 30 + (10 per level) damage. This shield refreshes after 9 seconds without receiving damage.",
                passive = "Refreshes after 9 seconds without receiving damage"

            });

            this.AllBuildsInto.Add(new Items()
            {
                itemName = "Long Sword",
                itemImg = "/SampleData/SampleDataSource/SampleDataSource_Files/Long_Sword_item.png",
                itemBonuses = "+50 Attack Damage",
                itemCost = "1550g",
                active = "Unique: Grants a shield that absorbs up to 30 + (10 per level) damage. This shield refreshes after 9 seconds without receiving damage.",
                passive = "Refreshes after 9 seconds without receiving damage"

            });

            this.AllBuildsInto.Add(new Items()
            {
                itemName = "Mercury's Treads",
                itemImg = "/SampleData/SampleDataSource/SampleDataSource_Files/Mercury's_Treads_item.png",
                itemBonuses = "+40 Ability Power",
                itemCost = "860g",
                active = "Unique: Grants a shield that absorbs up to 30 + (10 per level) damage. This shield refreshes after 9 seconds without receiving damage.",
                passive = "Refreshes after 9 seconds without receiving damage"

            });

            this.AllBuildsInto.Add(new Items()
            {
                itemName = "Moonflair",
                itemImg = "/SampleData/SampleDataSource/SampleDataSource_Files/Moonflair_Spellblade_item.png",
                itemBonuses = "N/A",
                itemCost = "325g",
                active = "Unique: Grants a shield that absorbs up to 30 + (10 per level) damage. This shield refreshes after 9 seconds without receiving damage.",
                passive = "Refreshes after 9 seconds without receiving damage"

            });

            this.AllBuildsInto.Add(new Items()
            {
                itemName = "Needlessly Large Rod",
                itemImg = "/SampleData/SampleDataSource/SampleDataSource_Files/Needlessly_Large_Rod_item.png",
                itemBonuses = "+8% Critical Strike Chance",
                itemCost = "400g",
                active = "Unique: Grants a shield that absorbs up to 30 + (10 per level) damage. This shield refreshes after 9 seconds without receiving damage.",
                passive = "Refreshes after 9 seconds without receiving damage"

            });

            this.AllBuildsInto.Add(new Items()
            {
                itemName = "Negatron Cloak",
                itemImg = "/SampleData/SampleDataSource/SampleDataSource_Files/Negatron_Cloak_item.png",
                itemBonuses = "+15% Critical Strike Chance",
                itemCost = "535g",
                active = "Unique: Grants a shield that absorbs up to 30 + (10 per level) damage. This shield refreshes after 9 seconds without receiving damage.",
                passive = "Refreshes after 9 seconds without receiving damage"

            });

            this.AllBuildsInto.Add(new Items()
            {
                itemName = "Null Magic Mantle",
                itemImg = "/SampleData/SampleDataSource/SampleDataSource_Files/Null-Magic_Mantle_item.png",
                itemBonuses = "+15 Armor",
                itemCost = "300g",
                active = "Unique: Grants a shield that absorbs up to 30 + (10 per level) damage. This shield refreshes after 9 seconds without receiving damage.",
                passive = "Refreshes after 9 seconds without receiving damage"

            });

            this.AllBuildsInto.Add(new Items()
            {
                itemName = "Pickaxe",
                itemImg = "/SampleData/SampleDataSource/SampleDataSource_Files/Pickaxe_item.png",
                itemBonuses = "+50 Attack Damage",
                itemCost = "1550g",
                active = "Unique: Grants a shield that absorbs up to 30 + (10 per level) damage. This shield refreshes after 9 seconds without receiving damage.",
                passive = "Refreshes after 9 seconds without receiving damage"

            });

            this.AllBuildsInto.Add(new Items()
            {
                itemName = "Prospector's Ring",
                itemImg = "/SampleData/SampleDataSource/SampleDataSource_Files/Prospector's_Ring_item.png",
                itemBonuses = "+70 Health +7 Attack Damage  +3% Lifesteal",
                itemCost = "440g",
                active = "Unique: Grants a shield that absorbs up to 30 + (10 per level) damage. This shield refreshes after 9 seconds without receiving damage.",
                passive = "Refreshes after 9 seconds without receiving damage"

            });

            // Enchantments
            this.AllEnchantments.Add(new Items()
            {
                itemName = "Alacrity",
                itemImg = "/SampleData/SampleDataSource/SampleDataSource_Files/Alacrity_item.png",
                itemBonuses = "+20 Ability Power",
                itemCost = "435g",
                active = "Unique: Grants a shield that absorbs up to 30 + (10 per level) damage. This shield refreshes after 9 seconds without receiving damage.",
                passive = "Refreshes after 9 seconds without receiving damage"

            });

            this.AllEnchantments.Add(new Items()
            {
                itemName = "Captain",
                itemImg = "/SampleData/SampleDataSource/SampleDataSource_Files/Captain_item.png",
                itemBonuses = "+25% Mana Regen per 5 seconds",
                itemCost = "365g",
                active = "Unique: Grants a shield that absorbs up to 30 + (10 per level) damage. This shield refreshes after 9 seconds without receiving damage.",
                passive = "Refreshes after 9 seconds without receiving damage"

            });

            this.AllEnchantments.Add(new Items()
            {
                itemName = "Distortion",
                itemImg = "/SampleData/SampleDataSource/SampleDataSource_Files/Distortion_item.png",
                itemBonuses = "+50 Attack Damage",
                itemCost = "1550g",
                active = "Unique: Grants a shield that absorbs up to 30 + (10 per level) damage. This shield refreshes after 9 seconds without receiving damage.",
                passive = "Refreshes after 9 seconds without receiving damage"

            });

            this.AllEnchantments.Add(new Items()
            {
                itemName = "Furor",
                itemImg = "/SampleData/SampleDataSource/SampleDataSource_Files/Furor_item.png",
                itemBonuses = "+40 Ability Power",
                itemCost = "860g",
                active = "Unique: Grants a shield that absorbs up to 30 + (10 per level) damage. This shield refreshes after 9 seconds without receiving damage.",
                passive = "Refreshes after 9 seconds without receiving damage"

            });

            this.AllEnchantments.Add(new Items()
            {
                itemName = "HomeGuard",
                itemImg = "/SampleData/SampleDataSource/SampleDataSource_Files/HomeGuard_item.png",
                itemBonuses = "N/A",
                itemCost = "325g",
                active = "Unique: Grants a shield that absorbs up to 30 + (10 per level) damage. This shield refreshes after 9 seconds without receiving damage.",
                passive = "Refreshes after 9 seconds without receiving damage"

            });


            this.AllRecipes.Add(new Items()
            {
                itemName = "Furor",
                itemImg = "/SampleData/SampleDataSource/SampleDataSource_Files/Doran's_Ring_item.png",
                itemBonuses = "+40 Ability Power",
                itemCost = "860g",
                active = "Unique: Grants a shield that absorbs up to 30 + (10 per level) damage. This shield refreshes after 9 seconds without receiving damage.",
                passive = "Refreshes after 9 seconds without receiving damage"

            });

            this.AllRecipes.Add(new Items()
            {
                itemName = "HomeGuard",
                itemImg = "/SampleData/SampleDataSource/SampleDataSource_Files/Boots_of_Speed_item.png",
                itemBonuses = "N/A",
                itemCost = "325g",
                active = "Unique: Grants a shield that absorbs up to 30 + (10 per level) damage. This shield refreshes after 9 seconds without receiving damage.",
                passive = "Refreshes after 9 seconds without receiving damage"

            });

            this.AllRecipes.Add(new Items()
            {
                itemName = "HomeGuard",
                itemImg = "/SampleData/SampleDataSource/SampleDataSource_Files/Blades_of_Torment.jpg",
                itemBonuses = "N/A",
                itemCost = "325g",
                active = "Unique: Grants a shield that absorbs up to 30 + (10 per level) damage. This shield refreshes after 9 seconds without receiving damage.",
                passive = "Refreshes after 9 seconds without receiving damage"

            });
            
            
        }

        public event PropertyChangedEventHandler PropertyChanged;

        // Used to notify the app that a property has changed.
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
    
