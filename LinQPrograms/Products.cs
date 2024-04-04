using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQPrograms
{
    public class Products
    {

        public string name { get; set; }

        public int price { get; set; }

        public string category { get; set; }

        List<Products> ls=new List<Products>();
       
        

        public static List<Products> getAllproducts()
        {
            List<Products> lsproducts = new List<Products>()
            {
                new Products{name="britania",price=20,category="biscuit"},
                new Products{name="gooday",price=10,category = "biscuit"},
                new Products{name="oreo",price=30,category = "biscuit"},

               new Products{name="grapes",price=50,category = "fruit"},

                 new Products{name="banana",price=100,category = "fruit"},

                 new Products{name="watermelon",price=20,category = "fruit"},
                 

            };


            //lsproducts.Add(new Products { name = "watermelon", price = 20, category = "fruit" });
            //lsproducts.Remove(new Products )

            return lsproducts;



        }


    


    }

}
