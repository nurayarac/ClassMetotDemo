using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] informations = new string[] { };
            Customer customer1 = new Customer();
            customer1.Id = 215431;
            customer1.Name = "Hasan Duraid Mansor";
            customer1.Surname = "Alansarry";
            customer1.Age = 22;
            customer1.İdentificationNumber = 12354415641344;

            Customer customer2 = new Customer();
            customer2.Id = 234512;
            customer2.Name = "Oğuzhan";
            customer2.Surname = "Bayram";
            customer2.Age = 23;
            customer2.İdentificationNumber = 321468433215;

            Customer customer3 = new Customer { Id = 135413, Name = "hediye", Surname = "zeybek", Age = 19, İdentificationNumber = 45464158 };

            CustomerManager customermanager  = new CustomerManager();
            customermanager.Add(customer1);
            Console.WriteLine(customer1.Name);

            customermanager.Update(customer2);
            Console.WriteLine(customer2.Age);


            customermanager.Delete(customer3);
            Console.WriteLine(customer3.İdentificationNumber);
        }
    }
}
