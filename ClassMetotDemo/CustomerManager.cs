using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
       public void Add(Customer customer)
        {
            Console.WriteLine(customer.Name +" " + "eklendi.");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine(customer.Age +" "+ "güncellendi.");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.İdentificationNumber +" "+" silindi.");
        }
    }
}
