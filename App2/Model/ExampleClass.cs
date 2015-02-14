using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2.Model
{
    public class Players
    {
        public int id { get; set; }
        public string img { get; set; }
        public string playername { get; set; }
        public string playertitle { get; set; }
        public string primary_secondary { get; set; }
        public int IP { get; set; }
        public int RP { get; set; }
        public string imgBig { get; set; }
    }

    public class Abilities
    {
        public string imgAbility { get; set; }
        public string ability { get; set; }
        public string abilityDesc { get; set; }
    }

    public class Items
    {
        public string itemName { get; set; }
        public string itemCost { get; set; }
        public string itemBonuses { get; set; }
        public string itemImg { get; set; }
        public string active { get; set; }
        public string passive { get; set; }
    }

    public class GroupInfoList : ObservableCollection<Players>
    {

        public object Key { get; set; }

        public new IEnumerator<Players> GetEnumerator()
        {
            return (IEnumerator<Players>)base.GetEnumerator();
        }
    }
}
