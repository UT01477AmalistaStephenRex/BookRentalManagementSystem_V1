using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagementSystem_V1
{
    public class PrintedBook:Book
    {
        public int ISBN { get; set; }
        public int NumberOfPages { get; set; }

        public PrintedBook(int iSBN, int numberOfPages) : base(bookId, title, author, rentalPrice)
        {
            ISBN = iSBN;
            NumberOfPages = numberOfPages;
        }

        DisplayPrintedBookInfo() : base()
        {
            return ToString();
        }
    }
}
