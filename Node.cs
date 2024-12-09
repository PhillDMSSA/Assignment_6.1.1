using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6._1._1
{
    public class Node
    {
        internal House Data { get; set; } //Data of type house
        internal Node Next {  get; set; } 
        public Node(House house)
        {
            Data = house;
            Next = null;
        }
    }
}
