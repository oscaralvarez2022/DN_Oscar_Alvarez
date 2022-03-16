using System;
using System.Collections.Generic;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var Customers = new List<Customer>{
                new Customer { Name = "Moy", RegisterDate=DateTime.Parse("2018,1,1") },
                new Customer { Name = "Oscar", RegisterDate=DateTime.Parse("2018,1,2") },
                new Customer { Name = "Daniel", RegisterDate=DateTime.Parse("2018,1,3") },
                new Customer { Name = "Jorge", RegisterDate=DateTime.Parse("2018,1,4") },
                new Customer { Name = "Xitlali", RegisterDate=DateTime.Parse("2018,1,5") },
                new Customer { Name = "Karla", RegisterDate=DateTime.Parse("2018,1,6") },
                new Customer { Name = "Carlos", RegisterDate=DateTime.Parse("2018,1,7") },
                new Customer { Name = "Juan", RegisterDate=DateTime.Parse("2018,1,8") },
                new Customer { Name = "Luna", RegisterDate=DateTime.Parse("2018,1,9") },
                new Customer { Name = "Lady", RegisterDate=DateTime.Parse("2018,1,10") },
            };

            Customers.Add(new Customer { Name = "Mayra", RegisterDate = DateTime.Parse("2018,1,11") });

            Console.WriteLine("Foreach");
            foreach (Customer c in Customers)
            {
                System.Console.WriteLine(c.Name);
                System.Console.WriteLine(c.RegisterDate);
            }

            Console.WriteLine("For");
            for (int i=0;i<Customers.Count;i++)
            {
                System.Console.WriteLine(Customers[i].Name);
                System.Console.WriteLine(Customers[i].RegisterDate);
            }

            Console.WriteLine("ForEach Compact ");
            Customers.ForEach((v) => Console.WriteLine("{0} {1}", v.Name, v.RegisterDate));

            Console.WriteLine("While");
            int ii = 0;
            while(ii<Customers.Count)
            {
                
                System.Console.WriteLine(Customers[ii].Name);
                System.Console.WriteLine(Customers[ii].RegisterDate);
                ii++;
            }

            Console.WriteLine("Do");
            int iii = 0;
            do
            {

                System.Console.WriteLine(Customers[iii].Name);
                System.Console.WriteLine(Customers[iii].RegisterDate);
                iii++;
            } while (iii < Customers.Count);

            //Console.WriteLine(customerArray);

            Console.ReadKey();
        }
    }
}
