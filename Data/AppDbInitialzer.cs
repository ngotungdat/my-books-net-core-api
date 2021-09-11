using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using my_books.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Data
{
    public class AppDbInitialzer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                if (!context.Books.Any())
                {
                    context.Books.AddRange(new Book
                    {
                        Title = "Book One",
                        DateRead = DateTime.Now,
                        DateAdded = DateTime.Now,
                        Author = "First author",
                        Category = 1
                    },
                    new Book 
                    {
                        Title = "Book Two",
                        DateRead = DateTime.Now.AddDays(1),
                        DateAdded = DateTime.Now.AddDays(1),
                        Author = "First author",
                        Category = 2
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
