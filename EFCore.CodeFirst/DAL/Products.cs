using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.CodeFirst.DAL
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; } 
        public int Stock { get; set; }
        public string Barcode { get; set; } 

      
    
    }
}
