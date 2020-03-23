﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class Class1
    {

        static void TestPerson()
        {
            using (Model1Container context = new Model1Container())
            {
                Person p = new Person()
                { FirstName = "Julie", LastName = "Andrew", MidleName = "T", TelephonNumber = "1234567890" };
                context.people.Add(p); context.SaveChanges();
                var items = context.people;
                foreach (var x in items)
                    Console.WriteLine("{0} {1}", x.Id, x.FirstName);
            }
        }

        static void TesTOneToMany() 
        { 
            Console.WriteLine("One to many association"); 
            using (Model2Container context = new Model2Container()) 
            { 
                Customer c = new Customer() { Name = "Customer 1",  City = "Iasi" }; 
                Order o1 = new Order() { TotalValue = 200,  Date = DateTime.Now,  CustomerId= c.Id }; 
                Order o2 = new Order() { TotalValue = 300,  Date = DateTime.Now, CustomerId = c.Id}; 
                context.Customers.Add(c); 
                context.Orders.Add(o1); 
                context.Orders.Add(o2); 
                context.SaveChanges(); 
                var items = context.Customers; foreach (var x in items) 
                {
                    Console.WriteLine("Customer : {0}, {1}, {2}", x.Id, x.Name, x.City); 
                    foreach (var ox in context.Orders) 
                        Console.WriteLine("\tOrders: {0}, {1}, {2}", ox.Id, ox.Date, ox.TotalValue); } } }
    }
}
