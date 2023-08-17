using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2210A_Phone.Demo;

namespace T2210A_Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneBook phoneBook = new PhoneBook();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Phone Book Menu:");
                Console.WriteLine("1. Insert Phone");
                Console.WriteLine("2. Remove Phone");
                Console.WriteLine("3. Update Phone");
                Console.WriteLine("4. Search Phone");
                Console.WriteLine("5. Sort");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter phone: ");
                        string phone = Console.ReadLine();
                        phoneBook.insertPhone(name, phone);
                        break;
                    case 2:
                        Console.Write("Enter name to remove: ");
                        string nameToRemove = Console.ReadLine();
                        phoneBook.RemovePhone(nameToRemove);
                        break;
                    case 3:
                        Console.Write("Enter name to update: ");
                        string nameToUpdate = Console.ReadLine();
                        Console.Write("Enter new phone: ");
                        string newPhone = Console.ReadLine();
                        phoneBook.UpdatePhone(nameToUpdate, newPhone);
                        break;
                    case 4:
                        Console.Write("Enter name to search: ");
                        string nameToSearch = Console.ReadLine();
                        phoneBook.SearchPhone(nameToSearch);
                        break;
                    case 5:
                        phoneBook.Sort();
                        Console.WriteLine("Phone Book sorted.");
                        break;
                    case 6:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please choose again.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
