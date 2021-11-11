using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using Ferris_Bakes.Data;

namespace Ferris_Bakes.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new OrderModelContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<OrderModelContext>>()))
            {
                // Look for any movies.
                if (context.SetOrder.Any())
                {
                    return;   // DB has been seeded
                }

                context.SetOrder.AddRange(
                    new SetOrderModel
                    {
                        BakeName = "Chocolate and Bailey's Cake",
                        BakeType = "Cake",
                        Flavor = "Chocolate and Bailey's",
                        Size = 1,
                        Frosting = "Bailey's",
                        FillFlavor = "Bailey's Ganache",
                        Description = "Chocolate and Bailey's flavored cake with a Bailey's buttercream. Filled with a Bailey's mousse and topped with a Chocolate Ganache.",
                        Price = 34.99
                    },

                    new SetOrderModel
                    {
                        BakeName = "Red Velvet Cake",
                        BakeType = "Cake",
                        Flavor = "Red Velvet",
                        Size = 1,
                        Frosting = "Cream Cheese",
                        FillFlavor = null,
                        Description = "Red Velvet Cake with Cream Cheese frosting.",
                        Price = 24.99
                    },

                    new SetOrderModel
                    {
                        BakeName = "Mini Lemon Bunt Cakes",
                        BakeType = "Cake",
                        Flavor = "Lemon",
                        Size = 4,
                        Frosting = null,
                        FillFlavor = "Blueberry",
                        Description = "Mini Lemon Bunt Cake with blueberry filling and icing on top.",
                        Price = 9.99
                    },

                    new SetOrderModel
                    {
                        BakeName = "Sparkling Apple Cider Pound Cake",
                        BakeType = "Cake",
                        Flavor = "Apple Cider",
                        Size = 1,
                        Frosting = null,
                        FillFlavor = null,
                        Description = "Sparkling Apple Cider Pound Cake with a sparkling apple cider icing.",
                        Price = 19.99
                    },

                    new SetOrderModel
                    {
                        BakeName = "Chocolate Cake",
                        BakeType = "Cake",
                        Flavor = "Chocolate",
                        Size = 1,
                        Frosting = "Chocolate",
                        FillFlavor = null,
                        Description = "Chocolate cake with chocolate icing.",
                        Price = 19.99
                    },

                    new SetOrderModel
                    {
                        BakeName = "Vanilla Cake",
                        BakeType = "Cake",
                        Flavor = "Vanilla",
                        Size = 1,
                        Frosting = "Vanilla",
                        FillFlavor = null,
                        Description = "Vanilla cake with vanilla icing.",
                        Price = 19.99
                    },

                    new SetOrderModel
                    {
                        BakeName = "Chocolate Crinkle Cookies",
                        BakeType = "Cookies",
                        Flavor = "Chocolate Crinkle",
                        Size = 12,
                        Frosting = null,
                        FillFlavor = null,
                        Description = "Chocolate Crinkle cookies covered in powered sugar.",
                        Price = 14.99
                    },

                    new SetOrderModel
                    {
                        BakeName = "Red Velvet Crinkle Cookies",
                        BakeType = "Cookies",
                        Flavor = "Red Velvet Crinkle",
                        Size = 12,
                        Frosting = null,
                        FillFlavor = null,
                        Description = "Red Velvet Crinkle cookies covered in powered sugar.",
                        Price = 14.99
                    },

                    new SetOrderModel
                    {
                        BakeName = "Chocolate Chip Cookies",
                        BakeType = "Cookies",
                        Flavor = "Chocolate Chip",
                        Size = 12,
                        Frosting = null,
                        FillFlavor = null,
                        Description = "Chocolate Crinkle cookies.",
                        Price = 9.99
                    },

                    new SetOrderModel
                    {
                        BakeName = "Sugar Cookies",
                        BakeType = "Cookies",
                        Flavor = "Sugar Chip",
                        Size = 12,
                        Frosting = null,
                        FillFlavor = null,
                        Description = "Sugar cookies.",
                        Price = 9.99
                    },

                    new SetOrderModel
                    {
                        BakeName = "Lemon & Lavendar Cupcakes",
                        BakeType = "Cupcakes",
                        Flavor = "Lemon",
                        Size = 12,
                        Frosting = "Lavendar",
                        FillFlavor = null,
                        Description = "Lemon Cupcakes with a lavendar buttercream.",
                        Price = 19.99
                    },

                    new SetOrderModel
                    {
                        BakeName = "Chocolate & Strawberry Cupcakes",
                        BakeType = "Cupcakes",
                        Flavor = "Chocolate",
                        Size = 12,
                        Frosting = "Vanilla",
                        FillFlavor = "Strawberry",
                        Description = "Chocolate cupcakes with a strawberry filling and vanilla buttercream.",
                        Price = 14.99
                    },

                    new SetOrderModel
                    {
                        BakeName = "Vanilla Cupcakes",
                        BakeType = "Cupcakes",
                        Flavor = "Vanilla",
                        Size = 12,
                        Frosting = "Vanilla",
                        FillFlavor = null,
                        Description = "Vanilla cupcakes with vanilla buttercream.",
                        Price = 9.99
                    },

                    new SetOrderModel
                    {
                        BakeName = "Chocolate Cupcakes",
                        BakeType = "Cupcakes",
                        Flavor = "Chocolate",
                        Size = 12,
                        Frosting = "Chocolate",
                        FillFlavor = null,
                        Description = "Chocolate cupcakes with chocolate buttercream.",
                        Price = 9.99
                    },

                    new SetOrderModel
                    {
                        BakeName = "Apple Pie",
                        BakeType = "Pastry",
                        Flavor = "Apple",
                        Size = 1,
                        Frosting = null,
                        FillFlavor = null,
                        Description = "Apple Pie made with Granny Smith apples and homemade pastry.",
                        Price = 19.99
                    },

                    new SetOrderModel
                    {
                        BakeName = "Chocolate Pie",
                        BakeType = "Pastry",
                        Flavor = "Chocolate",
                        Size = 1,
                        Frosting = null,
                        FillFlavor = null,
                        Description = "Chocolate pie with merguine and handmade pastry.",
                        Price = 19.99
                    },

                    new SetOrderModel
                    {
                        BakeName = "Pinwheel Pastries",
                        BakeType = "Pastry",
                        Flavor = "Raspberry & Cream Cheese",
                        Size = 24,
                        Frosting = null,
                        FillFlavor = null,
                        Description = "Pinwheel shaped pastries with cream cheese and raspberry jam filling.",
                        Price = 24.99
                    },

                    new SetOrderModel
                    {
                        BakeName = "Broken Glass Cupcakes",
                        BakeType = "Cupcakes",
                        Flavor = "Chocolate",
                        Size = 12,
                        Frosting = "Vanilla",
                        FillFlavor = null,
                        Description = "Chocolate cupcakes with vanilla buttercream topped with sugar glass and fake edible blood.",
                        Price = 24.99
                    },

                    new SetOrderModel
                    {
                        BakeName = "Pumpkin Cake",
                        BakeType = "Cake",
                        Flavor = "Chocolate",
                        Size = 1,
                        Frosting = "Cream Cheese",
                        FillFlavor = "Orange gelatin strings and white chocolate chips",
                        Description = "Pumpkin flavored and shaped caked with cream cheese frosting with orange geletain and white chocolate chips as pumpkin guts inside.",
                        Price = 49.99
                    },

                    new SetOrderModel
                    {
                        BakeName = "Santa Hat Cupcakes",
                        BakeType = "Cupcakes",
                        Flavor = "Vanilla",
                        Size = 12,
                        Frosting = "White Chocolate",
                        FillFlavor = "Cranberry",
                        Description = "Vanilla cupcakes with white chocolate buttercream filled with cranberry filling.",
                        Price = 14.99
                    },

                    new SetOrderModel
                    {
                        BakeName = "Peppermint Cupcakes",
                        BakeType = "Cupcakes",
                        Flavor = "Chocolate",
                        Size = 12,
                        Frosting = "Peppermint",
                        FillFlavor = null,
                        Description = "Chocolate cupcakes with a peppermint buttercream topped with a peppermint.",
                        Price = 9.99
                    },

                    new SetOrderModel
                    {
                        BakeName = "Valentine's Day Cheesecake",
                        BakeType = "Cake",
                        Flavor = "Cheesecake",
                        Size = 1,
                        Frosting = null,
                        FillFlavor = null,
                        Description = "New York style cheesecake topped with chocolate covered strawberries and a chocolate heart mold.",
                        Price = 39.99
                    },

                    new SetOrderModel
                    {
                        BakeName = "Cake Pops",
                        BakeType = "Misc",
                        Flavor = "Red Velvet",
                        Size = 15,
                        Frosting = "Cream Cheese",
                        FillFlavor = null,
                        Description = "Cake pops made with Red Velvet cake and cream cheese frosting.",
                        Price = 14.99
                    },

                    new SetOrderModel
                    {
                        BakeName = "Raspberry Oat Bar",
                        BakeType = "Misc",
                        Flavor = "Raspberry",
                        Size = 12,
                        Frosting = null,
                        FillFlavor = null,
                        Description = "Raspberry Oat Bar.",
                        Price = 9.99
                    },

                    new SetOrderModel
                    {
                        BakeName = "Swiss Rolls",
                        BakeType = "Misc",
                        Flavor = "Chocolate",
                        Size = 12,
                        Frosting = "Peppermint",
                        FillFlavor = null,
                        Description = "Chocolate and peppermint swiss rolls.",
                        Price = 19.99
                    },

                    new SetOrderModel
                    {
                        BakeName = "Tiger Pretzels",
                        BakeType = "Misc",
                        Flavor = "Regular",
                        Size = 4,
                        Frosting = null,
                        FillFlavor = null,
                        Description = "Tiger Stripped Pretzels",
                        Price = 19.99
                    },

                    new SetOrderModel
                    {
                        BakeName = "Chocolate Strawberry Trifold",
                        BakeType = "Misc",
                        Flavor = "Chocolate",
                        Size = 4,
                        Frosting = "Whipped Cream & Ganache",
                        FillFlavor = "Strawberry",
                        Description = "Chocolate cake with whipped cream, fresh strawberries, a strawberry galze, and chocolate ganache.",
                        Price = 19.99
                    }

                ); 
                context.SaveChanges();

                context.Reciepes.AddRange(
                    new ReciepeModel()
                    {
                        ReciepeNumber = 1,
                        Title = "Chocolate Chip Cookies",
                        Description = "Chocolate Chip Cookies",
                        Ingredients = { "Chocolate"},
                        Size = "One Dozen",
                        Price = ,
                        LactoseIntolerant = 
                    },
                );
            }
        }
    }
}
