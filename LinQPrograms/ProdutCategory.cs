using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LinQPrograms
{
    public class ProdutCategory
    {

        public class products
        {
            public int pId { get; set; }
            public string pName { get; set; }

            public int price {  get; set; }

            public string category {  get; set; }

            public static List<products> GetAllProducts()
            {
                List<products> products = new List<products>()
                {
                    new products() {pId=1, pName="apple",price=100,category="fruits"},
                    new products() {pId=2, pName="pineApple",price=200,category="fruits"},

                   new products() {pId=3, pName="watermelon",price=50,category="fruits"},

                    new products() {pId=4, pName="redmi",price=100,category="phones"},
                    new products() {pId=5, pName="iphone",price=100,category="phones"},

                   new products() {pId=4, pName="oppo",price=100,category="phones"},
                    new products() {pId=5, pName="samsung",price=100,category="phones"},

                   new products() {pId=4, pName="lenovo",price=100,category="laptop"},
                    new products() {pId=5, pName="hp",price=100,category="laptop"},

                    new products() {pId=4, pName="dell",price=100,category="laptop"},
                    new products() {pId=5, pName="predator",price=100,category="laptop"},


                };
                return products;
            }

           
        }
    }
}
