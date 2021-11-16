using System;

namespace uc4_delete
{
    class Program
    {
        class AddressPrompt
        {
            AddressBook book;

            public AddressPrompt()
            {
                book = new AddressBook();
            }

            static void Main(string[] args)
            {
                string selection = "";
                AddressPrompt prompt = new AddressPrompt();

                prompt.displayMenu();
                while (!selection.ToUpper().Equals("Q"))
                {
                    Console.WriteLine("Selection: ");
                    selection = Console.ReadLine();
                    prompt.performAction(selection);
                }
            }

            void displayMenu()
            {
                Console.WriteLine("A - Add an Data");
                Console.WriteLine("E - Edit an Data");
                Console.WriteLine("D - Delete an Data");
                Console.WriteLine("Q - Quit");
            }

            void performAction(string selection)
            {
                string name = "";
                string lastName = "";
                string address = "";
                string city = "";
                string state = "";
                int zipCode;
                double mobileNum;
                string mailId = "";

                switch (selection.ToUpper())
                {
                    case "A":
                        Console.WriteLine("Enter First Name:,Last Name:,adress:,city:,state:,zip cod:,mobile number:,Mail Id: ");

                        name = Console.ReadLine();
                        lastName = Console.ReadLine();
                        address = Console.ReadLine();
                        city = Console.ReadLine();
                        state = Console.ReadLine();
                        zipCode = int.Parse(Console.ReadLine());
                        mobileNum = double.Parse(Console.ReadLine());
                        mailId = Console.ReadLine();

                        book.add(name, lastName, address, city, state, zipCode, mobileNum, mailId);
                        Console.WriteLine("Address successfully added!");

                        break;
                    case "D":
                        Console.WriteLine("Enter Name to Delete: ");
                        name = Console.ReadLine();
                        book.remove(name);
                        Console.WriteLine("Data successfully removed");

                        break;
                    case "E":
                        Console.WriteLine("Enter Name to Edit: ");
                        name = Console.ReadLine();
                        Address addr = book.find(name);
                        if (addr != null)
                        {
                            Console.WriteLine("Enter new Address,city,state,zip code,mobile number,mail id");
                            addr.address = Console.ReadLine();
                            addr.city = Console.ReadLine();
                            addr.state = Console.ReadLine();
                            addr.code = int.Parse(Console.ReadLine());
                            addr.mobilenum = double.Parse(Console.ReadLine());
                            addr.MailId = Console.ReadLine();
                            Console.WriteLine("Data updated for {0}", name);
                        }
                        break;
                }
           
            }
        }
    }
}