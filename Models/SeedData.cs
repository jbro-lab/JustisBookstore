using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JustisBookstore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            BookDbContext context = application.ApplicationServices.CreateScope()
                .ServiceProvider.GetRequiredService<BookDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Books.Any())
            {
                context.Books.AddRange(

                    new Book
                    {
                        ISBN = "978-0451419439",
                        title = "Les Miserables",
                        authorFirstName = "Victor",
                        authorLastName = "Hugo",
                        publisher = "Signet",
                        classification = "Fiction",
                        category = "Classic",
                        price = 9.95
                    },

                    new Book
                    {
                        ISBN = "978-0743270755",
                        title = "Team of Rivals",
                        authorFirstName = "Doris",
                        authorMiddleName = "Kearns",
                        authorLastName = "Goodwin",
                        publisher = "Simon & Schuster",
                        classification = "Non-Fiction",
                        category = "Biography",
                        price = 14.58
                    },

                     new Book
                     {
                         ISBN = "978-0553384611",
                         title = "The Snowball",
                         authorFirstName = "Alice",
                         authorLastName = "Schroeder",
                         publisher = "Bantam",
                         classification = "Non-Fiction",
                         category = "Biography",
                         price = 21.54
                     },

                      new Book
                      {
                          ISBN = "978-0812981254",
                          title = "American Ulysses",
                          authorFirstName = "Ronald",
                          authorMiddleName = "C.",
                          authorLastName = "White",
                          publisher = "Random House",
                          classification = "Non-Fiction",
                          category = "Biography",
                          price = 11.61
                      },

                       new Book
                       {
                           ISBN = "978-0812974492",
                           title = "Unbroken",
                           authorFirstName = "Laura",
                           authorLastName = "Hillenbrand",
                           publisher = "Simon & Schuster",
                           classification = "Non-Fiction",
                           category = "Historical",
                           price = 13.33
                       },

                        new Book
                        {
                            ISBN = "978-0804171281",
                            title = "The Great Train Robbery",
                            authorFirstName = "Michael",
                            authorLastName = "Crichton",
                            publisher = "Vintage",
                            classification = "Fiction",
                            category = "Historical Fiction",
                            price = 15.95
                        },

                        new Book
                        {
                            ISBN = "978-1455586691",
                            title = "Deep Work",
                            authorFirstName = "Cal",
                            authorLastName = "Newport",
                            publisher = "Grand Central Publishing",
                            classification = "Non-Fiction",
                            category = "Self-Help",
                            price = 14.99
                        },

                        new Book
                        {
                            ISBN = "978-1455523023",
                            title = "It's Your Ship",
                            authorFirstName = "Michael",
                            authorLastName = "Abrashoff",
                            publisher = "Grand Central Publishing",
                            classification = "Non-Fiction",
                            category = "Self-Help",
                            price = 21.66
                        },

                        new Book
                        {
                            ISBN = "978-1591847984",
                            title = "The Virgin Way",
                            authorFirstName = "Richard",
                            authorLastName = "Branson",
                            publisher = "Portfolio",
                            classification = "Non-Fiction",
                            category = "Business",
                            price = 29.16
                        },

                        new Book
                        {
                            ISBN = "978-0553393613",
                            title = "Sycamore Row",
                            authorFirstName = "John",
                            authorLastName = "Grisham",
                            publisher = "Bantam",
                            classification = "Fiction",
                            category = "Thriller",
                            price = 15.03
                        }
                );

                context.SaveChanges();
            }
        }
    }
}
