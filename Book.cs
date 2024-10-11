using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagementSystem_V1
{
    public class Book
    {
        public string bookId { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public decimal rentalPrice { get; set; }
        public int totalBook {  get; set; }=0;

        public Book(string bookId, string title, string author, decimal rentalPrice)
        {
            this.bookId = bookId;
            this.title = title;
            this.author = author;
            this.rentalPrice = rentalPrice;
            this.totalBook = totalBook++;

        }

        public override string ToString()
        {
            return $"{bookId}, title: {title}, author: {author}, rentalPrice: {rentalPrice}";
        }

        
       

    }
}
