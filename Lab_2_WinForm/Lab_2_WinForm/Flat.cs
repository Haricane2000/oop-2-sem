using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_WinForm
{
    public class Flat
    {
        public int Metr { get; set; }
        public int CountOfRooms { get; set; }
        public int Floor { get; set; }
        public string Year { get; set; }
        public string rooms = "Квартира содержит следующие комнаты: ";
        public Adress adress { get; set; }

        public Flat() { }

        public Flat(int Metr, int CountOfRooms, int Floor, string Year, Adress adress)
        {
            this.Metr = Metr;
            this.CountOfRooms = CountOfRooms;
            this.Floor = Floor;
            this.Year = Year;
            this.adress = adress;
        }

        public static string[] ListOfMetr = new string[5]
        {
            "25","27", "29", "31", "33"
        };

        public string ShowAllInf()
        {
            return "\r Кол-во комнат: " + this.CountOfRooms +
                "\r\n Метраж: " + this.Metr +
                "\r\n Дата постройки: " + this.Year +
                "\r\n Этаж: " + this.Floor +
                "\r\n " + rooms + "\r\n" +
                "\r\n Адрес:" + "\r\n" +
                "\r\n Страна: " + this.adress.State +
                "\r\n Город: " + this.adress.City +
                "\r\n Улица: " + this.adress.Street +
                "\r\n Номер квартиры: " + this.adress.FlatNumber
                ;
        }
    }
}
