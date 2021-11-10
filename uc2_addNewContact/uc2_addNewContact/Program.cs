using System;

namespace uc2_addNewContact
{
    class Program
    {
        static void Main(string[] args) 
        {
            contactPerson objBook = new contactPerson();
             char check = 'y';
            while (check == 'y')
            {
                objBook.addContact();
                Console.WriteLine("do you want to add more members.....y/n");
                check = char.Parse(Console.ReadLine());
            } 
        }
    }
}
