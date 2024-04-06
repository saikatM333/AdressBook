using AddressBook;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("address book ");


        AddEditDeleteContact addEditDeleteContact = new AddEditDeleteContact();

        while (true)
        {
            Console.WriteLine("press 0 for add contact details\npress 1 for editing details\n press 2 for deleting  ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 0: addEditDeleteContact.AddContactDetails(); break;
                case 1 : addEditDeleteContact.EditContactDetails();break;
               
            }
        }

    }
}