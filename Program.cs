using System;

namespace NamedArguments
{
    class Product
    {
        public void PrintOrderDetails(object ordernum, string productname, string sellername)
        {
            Console.WriteLine("Order details are:\nOrderno:{0} Productname:{1} Sellername:{2}", ordernum, productname, sellername);
        }



        static void Main(string[] args)
        {
            Product obj = new Product();
            obj.PrintOrderDetails(ordernum:20 , productname: "Stationary", sellername: "Sandip");
        }
    }
}
