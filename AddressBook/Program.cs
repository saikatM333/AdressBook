using AddressBook;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("address book ");
        AddEditDeleteContact addEditDeleteContact = new AddEditDeleteContact();
        MultipleAddressBookFunctionality multipleAddressBookFunctionality = new MultipleAddressBookFunctionality();

        while (true)

        {
            Console.WriteLine("enter 1 for multiple address book functionality");
            int multipleFunctinality = Convert.ToInt32(Console.ReadLine());
            if (multipleFunctinality != 1)
            {
                Console.WriteLine("this is single address book functionality");
                Console.WriteLine("press 0 for add contact details\npress 1 for editing details\n press 2 for deleting  ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 0: addEditDeleteContact.AddContactDetails(); break;
                    case 1: addEditDeleteContact.EditContactDetails(); break;
                    case 2: addEditDeleteContact.DeleteContactDetails(); break;
                }
            }
            else
            {
                Console.WriteLine("this is multiple address book cointaining multiple contact in each address book functionality");
                try
                {
                    while (true)
                    {
                        Console.WriteLine("press 0 for add contact details in exsisting or new address book\npress 1 for display of name \n press 2 for count the person by city or state\n press 3 for search by city or state   ");
                        int choice = Convert.ToInt32(Console.ReadLine());

                        switch (choice)
                        {
                            case 0: multipleAddressBookFunctionality.addContactToExsistingAddressBook(); break;
                            
                        }
                    }
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
    }
}