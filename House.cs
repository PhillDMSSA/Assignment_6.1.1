using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6._1._1
{
    public enum HouseStyle
    {
        Ranch, Colonial, Victorian, Modern
    }
    public class House
    {
        public int HouseId {  get; set; }
        public int HouseNumber { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public HouseStyle HouseType { get; set; }
       
        

    }
}
