using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Shared
{
    public class FilterParams
    { 
        public string Title { get; set; }
        public string Price { get; set; }

        public string Barcode { get; set; }

        public string ReleaseDate { get; set; }
    }
}
