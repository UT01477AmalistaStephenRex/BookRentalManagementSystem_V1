using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagementSystem_V1
{
    internal class BookManager
    {
        List<Book> books = new List<Book>();

        public void CreateBook(Book book)
        {
            if (book == null)
            {
                Console.WriteLine("no books have to add");
            }
            else
            {
                books.Add(book);
                Console.WriteLine("Book is successfully added");
            }
        }

        public void ReadBooks() 
        {
            if (books.Count == 0)
            {
                Console.WriteLine("Books are not identify");
            }
            else 
            {
                foreach (Book book in books)
               
                Console.WriteLine();
            }
        }

        public void UpdateBook(int id , string title, string author, decimal rentalPrice)
        {
             Book book = books[id];

            
            

           
            
        }

        public void DeleteBook(int id)

        {
            var book = books[id];

            if (books.Count == 0)
            {
                Console.WriteLine("no books have to delete");
            }
            else
            {
                books.Remove(book);

                Console.WriteLine("Book is successfully deleted");
            }
        }

        

    }
}
