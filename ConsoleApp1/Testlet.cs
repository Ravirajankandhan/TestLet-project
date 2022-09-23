using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    
    public class Testlet : Item
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
            var result = Items.OrderBy(c => c.ItemType).ToList();
            foreach (var res in result)
            {
                Console.WriteLine(res.ItemType);
            }
            return result;
        }
    }
}
