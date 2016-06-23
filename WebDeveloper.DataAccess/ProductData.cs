using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class ProductData 
    {
        public List<Product> GetFakeProducts()
        {
            return new List<Product>
            {
                new Product { ID= 1, Description="Cristal",Price=3.0, CreateDate=null},
                new Product { ID= 1, Description="Pilsen",Price=0.0, CreateDate=DateTime.Now},
                new Product { ID= 1, Description="Cusqueña",Price=5.0, CreateDate=null},
                new Product { ID= 1, Description="Sublime",Price=1.1, CreateDate=DateTime.Now},
                new Product { ID= 1, Description="Coca Cola",Price=0.0, CreateDate=null},
                new Product { ID= 1, Description="Inka Cola",Price=2.5, CreateDate=DateTime.Now},
                new Product { ID= 1, Description="7up",Price=1.5, CreateDate=null},
                new Product { ID= 1, Description="Pepsi",Price=0.0, CreateDate=DateTime.Now},
            };
        }
    }
}
