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
                if (!AddressBooks[AddressBookName].ContainsKey($"{firstname} {lastname}"))
                {
                    AddressBooks[$"{AddressBookName}"].Add($"{firstname} {lastname}", new ContactDetails(firstname, lastname, email, phone, address, city, state, zip));
                    Console.WriteLine($"the contact details is added successfully in {AddressBookName}");
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
                    Console.WriteLine($"the contact details is added successfully {AddressBookName}");

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
                    if (pair.Value.city.Equals(city) )
                    {
                        Console.WriteLine($"city :{city} , person :  {pair.Key}");
                    }
                    if (pair.Value.state.Equals(state))
                    {
                        Console.WriteLine($"state : {state} , person:  {pair.Key}");
                    }
                }
            }
            else
            {
                Console.WriteLine("please enter the corresct addressbook name ");
            }
        }
        public void displayNameByCityandState()
        {
            Console.WriteLine("enter the name of the city to display the person ");
            string city = Console.ReadLine();

            Console.WriteLine("enter the name of the state to display the person");
            string state = Console.ReadLine();

            foreach (KeyValuePair<string, Dictionary<string, ContactDetails>> pair in AddressBooks)
            {
                Console.WriteLine("the address book {0}", pair.Key);
                foreach (KeyValuePair<string, ContactDetails> keyValuePair in pair.Value)
                {

                    if (keyValuePair.Value.state.Equals(state) && keyValuePair.Value.city.Equals(city))
                    {
                        Console.WriteLine($"state : {state}, city : {city}, persons name :{keyValuePair.Key}");
                    }

                    else if (keyValuePair.Value.state.Equals(state))
                    {
                        Console.WriteLine($"state : {state}, persons name :{keyValuePair.Key}");
                    }
                    else if (keyValuePair.Value.city.Equals(city))
                    {
                        Console.WriteLine($"city : {city}, persons name :{keyValuePair.Key}");
                    }

                    else
                    {
                        Console.WriteLine("no person is present in the city or state");
                    }
                }
            }
        }
        public void countPersonByCityAndState()
        {
            foreach (KeyValuePair<string, Dictionary<string, ContactDetails>> pair in AddressBooks)
            {
                Console.WriteLine($" in address book {pair.Key}");

                Console.WriteLine("enter the city name for which you want the count ");
                string city = Console.ReadLine();

                Console.WriteLine("enter the city name for which you want the count ");
                string state = Console.ReadLine();

                int countBystate = pair.Value.Values.Count(e => e.state.Equals(state));
                int countBycity = pair.Value.Values.Count(e => e.city.Equals(city));

                Console.WriteLine($"the number of pepole in the city is {countBycity}");
                Console.WriteLine($"the number of the pepole in the state is {countBystate}");
            }
        }
    }
}
