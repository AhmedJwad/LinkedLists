using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists.Logic
{
    public class Fruit
    {
        public string? Name { get; set; }

        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Price:C2}";
        }
    }
}
