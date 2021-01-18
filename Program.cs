using System;

namespace MusteriTakip
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customer = new CustomerManager();
            Customer c = new Customer();
            c.Id = 1;
            c.FirstName = "Mehmet";
            c.LastName = "Arslan";
            c.Balance = 10000;
            customer.Add(c);
        }
    }
}
