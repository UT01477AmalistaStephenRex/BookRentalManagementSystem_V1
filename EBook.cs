using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagementSystem_V1
{
    public class EBook : Book
    {
        public int FileSize { get; set; }
        public string Format { get; set; }

        public EBook(int fileSize, string format) : base
        {
            FileSize = fileSize;
            Format = format;
        }
    }


}
