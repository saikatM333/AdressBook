using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddEditDeleteContact
    {
        public void AddContactDetails()
        {   // writing the logic to add contact in address
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
            ContactList.Add(new ContactDetails(firstname, lastname, email, phone, address, city, state, zip));
        }
        public void EditContactDetails()
        { // logic for the editing the user data 
            Console.WriteLine("enter your firstname ");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter the lastname");
            string lastname = Console.ReadLine();
            Boolean flag = true;
            while (flag)
            {
                Console.WriteLine("enter 1 for changing the firstname\nenter 2 change the lastname\n enter 3 for changing the email\nenter 4 to change the address\nenter the 5 for changing the city\nenter the 6 for changing the state\nenter 7 for changing the zip\n enter 8 for changing phone");
                int choice = Convert.ToInt32(Console.ReadLine());
                foreach (ContactDetails contact in ContactList)
                {
                    if (contact.firstName.Equals(firstname) && contact.lastName.Equals(lastname))
                    {
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("enter to update the firstname ");
                                contact.firstName = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("enter to update the ");
                                contact.firstName = Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine("enter to update the ");
                                contact.firstName = Console.ReadLine();
                                break;
                            case 4:
                                Console.WriteLine("enter to update the ");
                                contact.firstName = Console.ReadLine(); ;
                                break;
                            case 5:
                                Console.WriteLine("enter to update the ");
                                contact.firstName = Console.ReadLine();
                                break;
                            case 6:
                                Console.WriteLine("enter to update the ");
                                contact.firstName = Console.ReadLine();
                                break;
                            case 7:
                                Console.WriteLine("enter to update the ");
                                contact.firstName = Console.ReadLine(); ;
                                break;
                            case 8:
                                Console.WriteLine("enter to update the ");
                                contact.firstName = Console.ReadLine();
                                break;
                            default:
                                flag = false;
                                break;
                        }
                    }
                }
            }
        }
        public void DeleteContactDetails()
        {   // logic for deleting the a contact detail of user 
            Console.WriteLine("enter your firstname ");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter the lastname");
            string lastname = Console.ReadLine();
            bool flag = true;
            while (flag == true)
            {
                foreach (ContactDetails contact in ContactList)
                {
                    if (contact.firstName.Equals(firstname) && contact.lastName.Equals(lastname))
                    {
                        ContactListRemove.Add(contact);
                    }
                }
                foreach (ContactDetails contact in ContactListRemove)
                {
                    ContactList.Remove(contact);
                }
                Console.WriteLine("contact details removed succefully ");

                Console.WriteLine("if you want to  delete more number of contact details press 1 else 0");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 0)
                {
                    flag = false; break;
                }
            }
        }
        static ArrayList ContactList = new ArrayList();
        static ArrayList ContactListRemove = new ArrayList();
    }
}
