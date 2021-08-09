using test.Domain.Entities;
using test.Domain.ValueObjects;
using test.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;

namespace test.Infrastructure.Persistence
{
    public static class ApplicationDbContextSeed
    {
        public static async Task SeedDefaultUserAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            var administratorRole = new IdentityRole("Administrator");

            if (roleManager.Roles.All(r => r.Name != administratorRole.Name))
            {
                await roleManager.CreateAsync(administratorRole);
            }

            var administrator = new ApplicationUser { UserName = "administrator@localhost", Email = "administrator@localhost" };

            if (userManager.Users.All(u => u.UserName != administrator.UserName))
            {
                await userManager.CreateAsync(administrator, "Administrator1!");
                await userManager.AddToRolesAsync(administrator, new[] { administratorRole.Name });
            }
        }

        public static async Task SeedSampleDataAsync(ApplicationDbContext context)
        {
            // Seed, if necessary
            if (!context.TodoLists.Any())
            {
                context.TodoLists.Add(new TodoList
                {
                    Title = "Shopping",
                    Colour = Colour.Blue,
                    Items =
                    {
                        new TodoItem { Title = "Apples", Done = true },
                        new TodoItem { Title = "Milk", Done = true },
                        new TodoItem { Title = "Bread", Done = true },
                        new TodoItem { Title = "Toilet paper" },
                        new TodoItem { Title = "Pasta" },
                        new TodoItem { Title = "Tissues" },
                        new TodoItem { Title = "Tuna" },
                        new TodoItem { Title = "Water" }
                    }
                });


                await context.SaveChangesAsync();
            }
            return;
            /*
            IList<Customer> customers = new List<Customer>();
            IList<Book> books = new List<Book>();
            IList<OrderPosition> orderPositions = new List<OrderPosition>();
            IList<Order> orders = new List<Order>();

            
            if (!context.BooksItems.Any())
            {
            
                books.Add(new Book { Isbn = "4321324324", Author = "Ingrid Bergmann", Jahr = 2020, Titel = "C++ für Besoffene" });
                books.Add(new Book { Isbn = "11111111111", Author = "Ulrich Denzel", Jahr = 2014, Titel = "Java ist auch eine Insel" });
                books.Add(new Book { Isbn = "22222222222", Author = "Heinrich Alfons", Jahr = 2010, Titel = "C für Anfänger" });
                books.Add(new Book { Isbn = "22222222222", Author = "Heinrich Alfons", Jahr = 2010, Titel = "C für Anfänger" });
                foreach (var b in books)
                {
                    context.Add(b);
                }
                await context.SaveChangesAsync();

            }


            customers.Add(new Customer { LastName = "Mueller", FirstName = "Lisa", City = "Essen", Postcode = 12345, Street = "Hausstr.", StreetNumber = "2" });
            customers.Add(new Customer { LastName = "Meier", FirstName = "Stefan", City = "Bochum", Postcode = 54321, Street = "Astr.", StreetNumber = "3a" });
            customers.Add(new Customer { LastName = "Heiler", FirstName = "Marcus", City = "Dortmund", Postcode = 54321, Street = "Bstr.", StreetNumber = "4" });
            customers.Add(new Customer { LastName = "Bäll", FirstName = "Günter", City = "Hanau", Postcode = 34245, Street = "Cstr.", StreetNumber = "11" });


            orders.Add(new Order { Customer = customers[0], Date = DateTime.Today }); //0
            orders.Add(new Order { Customer = customers[0], Date = DateTime.Today.AddDays(-10) }); //1

            orders.Add(new Order { Customer = customers[1], Date = DateTime.Today.AddDays(-5) }); //2
            orders.Add(new Order { Customer = customers[1], Date = DateTime.Today.AddDays(-3) }); //3
            orders.Add(new Order { Customer = customers[1], Date = DateTime.Today.AddDays(-10) }); //4

            orders.Add(new Order { Customer = customers[2], Date = DateTime.Today.AddDays(-3) }); //5

            orders.Add(new Order { Customer = customers[3], Date = DateTime.Today.AddDays(-10) }); //6
            orders.Add(new Order { Customer = customers[3], Date = DateTime.Today.AddDays(-5) }); //7


            customers[0].Orders.Add(orders[0]);
            customers[0].Orders.Add(orders[0]);

            customers[1].Orders.Add(orders[2]);
            customers[1].Orders.Add(orders[3]);
            customers[1].Orders.Add(orders[4]);

            customers[2].Orders.Add(orders[5]);

            customers[3].Orders.Add(orders[6]);
            customers[3].Orders.Add(orders[7]);

            orderPositions.Add(new OrderPosition { Book = books[0], Order = orders[0] });
            orderPositions.Add(new OrderPosition { Book = books[1], Order = orders[0] });

            orderPositions.Add(new OrderPosition { Book = books[2], Order = orders[1] });
            orderPositions.Add(new OrderPosition { Book = books[0], Order = orders[1] });
            orderPositions.Add(new OrderPosition { Book = books[1], Order = orders[1] });

            orderPositions.Add(new OrderPosition { Book = books[1], Order = orders[2] });
            orderPositions.Add(new OrderPosition { Book = books[2], Order = orders[2] });
            orderPositions.Add(new OrderPosition { Book = books[3], Order = orders[2] });

            orderPositions.Add(new OrderPosition { Book = books[3], Order = orders[3] });

            orderPositions.Add(new OrderPosition { Book = books[0], Order = orders[4] });

            orderPositions.Add(new OrderPosition { Book = books[1], Order = orders[5] });

            orderPositions.Add(new OrderPosition { Book = books[3], Order = orders[6] });
            orderPositions.Add(new OrderPosition { Book = books[2], Order = orders[6] });

            orderPositions.Add(new OrderPosition { Book = books[0], Order = orders[7] });

            if (!context.Orders.Any())
            {
                foreach (var o in orders)
                {
                    context.Add(o);
                }

                await context.SaveChangesAsync();
            }

            if (!context.OrderPositions.Any())
            {
                foreach (var o in orderPositions)
                {
                    context.Add(o);
                }

                await context.SaveChangesAsync();
            }

            if (!context.Customers.Any())
            {
                foreach (var c in customers)
                {
                    context.Add(c);
                }
                await context.SaveChangesAsync();
            }
            */
        }
    }
}
