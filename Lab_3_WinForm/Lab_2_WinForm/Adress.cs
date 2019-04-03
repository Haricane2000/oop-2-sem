using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_WinForm
{
    public class Adress
    {
        public string State { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public int FlatNumber { get; set; }

        public Adress() { }

        public Adress(string State, string City, string Street, string House, int FlatNumber)
        {
            this.State = State;
            this.City = City;
            this.Street = Street;
            this.House = House;
            this.FlatNumber = FlatNumber;
        }

        public static string[] ListOfSTATE = new string[2]
        {
            "Беларусь","Россия"
        };

    }
}
