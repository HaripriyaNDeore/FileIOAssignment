using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    [Serializable]

    public class Book
    {
        public int bid { get; set; }
        public string bname { get; set; }
        public string authorname { get; set; }
        public int price { get; set; }
        public string bookdetails { get; set; }
       
    }
}
