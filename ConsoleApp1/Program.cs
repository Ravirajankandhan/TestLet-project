using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testlet Project!");
            

            var testlet = new List<Item>() {
                new Item(){ ItemId = "1", ItemType = ItemTypeEnum.Pretest},
                new Item(){ ItemId = "2", ItemType = ItemTypeEnum.Pretest},
                new Item(){ ItemId = "3", ItemType = ItemTypeEnum.Operational},
                new Item(){ ItemId = "4", ItemType = ItemTypeEnum.Pretest},
                new Item(){ ItemId = "5", ItemType = ItemTypeEnum.Operational},
                new Item(){ ItemId = "6", ItemType = ItemTypeEnum.Pretest},
                new Item(){ ItemId = "7", ItemType = ItemTypeEnum.Operational},
                new Item(){ ItemId = "8", ItemType = ItemTypeEnum.Pretest},
                new Item(){ ItemId = "9", ItemType = ItemTypeEnum.Operational},
                new Item(){ ItemId = "10", ItemType = ItemTypeEnum.Pretest}
            };
            Testlet ob = new Testlet("1",testlet);
            ob.Randomize();
        }
    }

    public class Testlet
    {
        public string TestletId;
        private List<Item> Items;

        public Testlet()
        {

        }

        public Testlet(string testletId, List<Item> items)
        {
            TestletId = testletId;
            Items = items;
        }
        public List<Item> Randomize()
        {  
            var  result = Items.OrderBy(c => c.ItemType).ToList();
            foreach(var res in result)
            {
                Console.WriteLine(res.ItemType);
            }
            return result;
        }
    }
    public class Item
    {
        public string ItemId;
        public ItemTypeEnum ItemType;
    }
    public enum ItemTypeEnum
    {
        Pretest = 0,
        Operational = 1
    }
}
