using System;
using System.Collections.Generic;
using System.Text;

namespace MusteriTakip
{
    class CustomerManager
    {

        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri Adı : "+ customer.FirstName);
            Console.WriteLine("Müşteri Soyadı : "+ customer.LastName);
            Console.WriteLine("Müşteri Bakiyesi : "+ customer.Balance);
            Console.WriteLine("Kayıt Eklendi");
        }

        public void List(Customer customer)
        {
            Console.WriteLine("Müşteri Adı : " + customer.FirstName);
            Console.WriteLine("Müşteri Soyadı : " + customer.LastName);
            Console.WriteLine("Müşteri Bakiyesi : " + customer.Balance);
            Console.WriteLine("Kayıt Listesi");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Kayıt Silindi");
        }

    }
}
