using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagementSystem_V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
            Console.ReadLine();
        }

        public static void Menu()
        {
            Console.WriteLine("Book Rental Management System:");
            Console.WriteLine("1. Add a Book");
            Console.WriteLine("2. View All Books");
            Console.WriteLine("3. Update a Book");
            Console.WriteLine("4. Delete a Book");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Choose an option:");




            switch (option)
            {
                case "1":
                    Console.WriteLine("Select type");
                    Console.WriteLine("1.DigitalBook");
                    Console.WriteLine("2.DVDBook");
                    break;

                case "2":
                    Console.WriteLine("Enter Book Title");
                    Console.WriteLine("Enter Book Author");
                    Console.WriteLine("Enter Book rental price");
                    Console.WriteLine("Book added successfully.");
                    break;
                case "3":
                    Console.WriteLine("List of Books:");
                    Console.WriteLine($"ID:{bookId},Title:{title},Author{author},Rental Price{rentalPrice}");
                    break;
                case "4":
                    Console.WriteLine("Enter the Book ID to update: ");
                    Console.WriteLine("Enter new Title");
                    Console.WriteLine("Enter new Author");
                    Console.WriteLine("Enter new rental Price");
                    Console.WriteLine("Book updated successfully.");
                    break;
                case "5":
                    Console.WriteLine("");
                    break;
            }
        }

           
    

        
    }
}
