﻿using System;

namespace AdressBookSystem
{
    class Program
    {
        public String FirstName { get; set; }
        public String Adress { get; set; }
        public String LastName { get; set; }
        public string CityName { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public Double MobileNum { get; set; }
        public string email { get; set; }

        public void DisplayContact()
        {
            Console.WriteLine("First name: " + FirstName + " Last name: " + LastName + " Adress: " + Adress + " city name: " + CityName+" state: "+State + " email Id: " + email);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("enter the first name ,last name,adress, city name,state,zip code,mobile number,email Id");
            Program objProgram = new Program()
            {
                FirstName = Console.ReadLine(),
                LastName = Console.ReadLine(),
                Adress = Console.ReadLine(),
                CityName = Console.ReadLine(),
                State = Console.ReadLine(),
                ZipCode = int.Parse(Console.ReadLine()),
                MobileNum = Double.Parse(Console.ReadLine()),
                email = Console.ReadLine()
            };
            objProgram.DisplayContact();
           
        }
    }
}
