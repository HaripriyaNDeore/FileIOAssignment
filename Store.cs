using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    [Serializable]
    class Store
    {
        public int batchid { get; set; }
        public string batchname { get; set; }
        public DateTime startdate { get; set; }
        public DateTime enddate { get; set; }
        public string location { get; set; }
        public string trainername { get; set; }
        
    }
    

}
