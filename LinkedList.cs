using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6._1._1
{
    public class LinkedList 
    {
        //start of with a property 
        internal Node Head {  get; set; }
        public int Length { get; set; }

       

        public House FindElement(int houseNumnber)
        {
            House house = LinkedList.Head;
            for (int i = 0; i < Length; i++)
            {
                if (house.HouseNumber == houseNumnber)
                {
                    return house;
                }
            }
            return house;
        }

    }
}
