using System;
using System.Collections.Generic;
using System.Text;

namespace uc5_addContactList
{
    class AddressBook
    {
        List<Address> addresses;

        public AddressBook()
        {
            addresses = new List<Address>();
        }

        public bool add(string name, string lastName, string address, string city, string state, int zipCode, double mobileNum, string mailId)
        {
            Address addr = new Address(name, lastName, address, city, state, zipCode, mobileNum, mailId);
            Address result = find(name);

            if (result == null)
            {
                addresses.Add(addr);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool remove(string name)
        {
            Address addr = find(name);

            if (addr != null)
            {
                addresses.Remove(addr);
                return true;
            }
            else
            {
                return false;
            }
        }
        public void list(Action<Address> action)
        {
            addresses.ForEach(action);
        }
        public Address find(string name)
        {
            Address addr = addresses.Find((a) => a.name == name);
            return addr;
        }

    }
}
