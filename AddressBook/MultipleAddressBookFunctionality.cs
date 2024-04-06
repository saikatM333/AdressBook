﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public  class MultipleAddressBookFunctionality
    {
        public static Dictionary<string, Dictionary<string, ContactDetails>> AddressBooks = new Dictionary<string, Dictionary<string, ContactDetails>>();
        public void addContactToExsistingAddressBook()
        {
            Console.WriteLine("enter in which address book you Want to enter the contact details ");
            string AddressBookName = Console.ReadLine();
            //AddressBooks["Adress"] = new Dictionary<string, ArrayList> ();

            Console.WriteLine("enter the firstname");
            string firstname = Console.ReadLine();

            Console.WriteLine("enter the lastname");
            string lastname = Console.ReadLine();
            Console.WriteLine("enter the email");
            string email = Console.ReadLine();
            Console.WriteLine("enter the phone");
            string phone = Console.ReadLine();
            Console.WriteLine("enter the address");
            string address = Console.ReadLine();
            Console.WriteLine("enter the city ");
            string city = Console.ReadLine();
            Console.WriteLine("enter the state");
            string state = Console.ReadLine();
            Console.WriteLine("enter the zip");
            string zip = Console.ReadLine();

            // IEnumerable<string> key = AddressBooks[AddressBookName].Keys;
            if (AddressBooks.ContainsKey(AddressBookName))

            {
                if (AddressBooks[AddressBookName].ContainsKey($"{firstname} {lastname}"))
                {
                    AddressBooks[$"{AddressBookName}"].Add($"{firstname} {lastname}", new ContactDetails(firstname, lastname, email, phone, address, city, state, zip));
                }

                else
                {
                    Console.WriteLine("the user already exist");
                }
            }

            else
            {
                try
                {
                    Console.WriteLine("new address book is maintened");
                    Dictionary<string, ContactDetails> value = new Dictionary<string, ContactDetails>();
                    value.Add($"{firstname} {lastname}", new ContactDetails(firstname, lastname, email, phone, address, city, state, zip));
                    AddressBooks.Add(AddressBookName, value);

                }
                catch (Exception ex)
                {
                    if (ex is CustomException cx)
                    {
                        Console.WriteLine(cx);
                    }
                }
            }
        }
        public void searchByCityAndState()
        {
            Console.WriteLine("enter the city name from which you want to search the person");
            string city = Console.ReadLine();

            Console.WriteLine("enter the state name from which you want to search the person ");

            string state = Console.ReadLine();

            Console.WriteLine("enter the address book from which you want to search");
            string addressBookName = Console.ReadLine();
            IEnumerable<string> key = AddressBooks.Keys;
            if (key.Contains(addressBookName))
            {
                foreach (KeyValuePair<string, ContactDetails> pair in AddressBooks[addressBookName])
                {
                    if (pair.Value.city.Equals(city) || pair.Value.state.Equals(state))
                    {
                        Console.WriteLine(pair.Key);
                    }
                }
            }

            else
            {
                Console.WriteLine("please enter the corresct addressbook name ");
            }

        }
        }
}
