using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using team1.Data;
using System;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.CodeAnalysis;

namespace team1.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new team1Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<team1Context>>()))
            {
                // Look for any movies.
                if (context.Products.Any())
                {
                    return;   // DB has been seeded
                }

                var customers = new Customers[]
                {
                    new Customers
                    {
                        CustomersId = 1,
                        CustomerName = "Tai",
                        BirthDay = DateTime.Parse("2003-09-18")
                    }
                };
                foreach (Customers a in customers)
                {
                    context.Customers.Add(a);
                }
                context.SaveChanges();

                var grouproduct = new GroupProduct[]
                {
                    new GroupProduct
                    {
                        GroupProductId=1,
                        Name = "Tai",
                        Content =" web ban hang"

                    }
                };
                foreach (GroupProduct b in grouproduct)
                {
                    context.GroupProducts.Add(b);
                }
                context.SaveChanges();

                var orders = new Order[]
                {
                    new Order
                    {
                        OrderId = 1,
                        TotalMoney = 55,
                        Date = DateTime.Parse("2023-1-10"),

                    }
                };
                foreach (Order c in orders)
                {
                    context.Orders.Add(c);
                }
                context.SaveChanges();

                var orderdetail = new OrderDetail[]
                {
                    new OrderDetail
                    {
                        OrderDetailId = 1,
                        ProductId = 1,
                        Quantity = 23,
                        OrderId =1,
                        
                    }
                };
                foreach (OrderDetail d in orderdetail)
                {
                    context.OrderDetails.Add(d);
                }
                context.SaveChanges();

                var product = new Product[]
                {
                    new Product
                    {
                        ProductId = 1,
                        ProductName = "tra sua thai",
                        Detail = "...",
                        Price = 45,
                        PriceNew = 40,
                        Date = DateTime.Parse(" 2023-03-09")
                    }
                };
                foreach (Product s in product)
                {
                    context.Products.Add(s);
                }
                context.SaveChanges();

                var users = new Users[]
                {
                    new Users
                    {
                        UserId = 1,
                        name = "Tai",
                        UserName = " tai03",
                        Password = "1234"
                    }
                };
                foreach (Users f in users)
                {
                    context.Users.Add(f);
                }
                context.SaveChanges();
            }
        }


    }
}
    