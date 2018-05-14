using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACS387Group10Project
{
    class APIBook
    {
        public string isbn13 { get; set; }
        public string isbn10 { get; set; }
        public string title { get; set; }
        public List<BookAuthor> author_name { get; set; }
        public string summary { get; set; }
        public string onhand { get; set; } 

        
    }
}
