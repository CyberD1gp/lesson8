using System.Xml.Linq;
using System;


namespace WorkLesson8._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Введите ФИО:");
            string Name = Console.ReadLine();

            Console.WriteLine("Введите Улицу:");
            string Street = Console.ReadLine();

            Console.WriteLine("Введите Номера дома:");
            int Housenumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите Номер квартиры:");
            int FlatNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите Мобильный телефон:");
            int MobilePhone = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите домашний телефон");
            int FlatPhone = Convert.ToInt32(Console.ReadLine());

            #region XElement
            XElement MYPerson = new XElement("Person");
            XElement MYAdress = new XElement("Adress");
            XElement MYStreet = new XElement("Street");
            XElement MYHouseNumber = new XElement("HouseNumber");
            XElement MYFlatNumber = new XElement("FlatNumber");
            XElement MYPhones = new XElement("Phones");
            XElement MYMobilePhone = new XElement("MobilePhone");
            XElement MyFlatPhone = new XElement("FlatPhone");

            XAttribute FName = new XAttribute("name", Name);
            
            MYStreet.Add(Street);
            MYHouseNumber.Add(Housenumber);
            MYFlatNumber.Add(FlatNumber);
            MYMobilePhone.Add(MobilePhone);
            MyFlatPhone.Add(FlatPhone);

            MYAdress.Add(MYStreet, MYHouseNumber, MYFlatNumber);
            MYPhones.Add(MYMobilePhone, MyFlatPhone);

            MYPerson.Add(MYAdress, MYPhones, FName);

            MYPerson.Save("person.xml");
            #endregion

        }
    }
}
