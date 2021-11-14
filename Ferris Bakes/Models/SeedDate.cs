using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using Ferris_Bakes.Data;
using System.Collections.Generic;
using Ferris_Bakes.Entities;

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
                        Ingredients = new Ingredients("Chocolate"),
                        Size = "One Dozen",
                        Price = 9.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 2,
                        Title = "Sugar Cookies",
                        Description = "Sugar Cookies",
                        Ingredients = new Ingredients("Vanilla"),
                        Size = "One Dozen",
                        Price = 9.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 3,
                        Title = "Chocolate Crinkle Cookies",
                        Description = "Chocolate Crinkle Cookies",
                        Ingredients = new Ingredients("Chocolate"),
                        Size = "One Dozen",
                        Price = 14.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 4,
                        Title = "Red Velvet Crinkle Cookies",
                        Description = "Red Velvet Crinkle Cookies",
                        Ingredients = new Ingredients("RedVelvet"),
                        Size = "One Dozen",
                        Price = 14.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 5,
                        Title = "Snicker Doodle Cookies",
                        Description = "Snicker Doodle Cookies",
                        Ingredients = new Ingredients("Spice"),
                        Size = "One Dozen",
                        Price = 9.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 6,
                        Title = "Vanilla Cupcakes",
                        Description = "Vanilla Cupcakes with Vanilla Buttercream",
                        Ingredients = new Ingredients("Vanilla"),
                        Size = "One Dozen",
                        Price = 9.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 7,
                        Title = "Vanilla Cake",
                        Description = "Vanilla Cake with Vanilla Buttercream",
                        Ingredients = new Ingredients("Vanilla"),
                        Size = "One three tiered cake",
                        Price = 14.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 8,
                        Title = "Chocolate Cupcakes",
                        Description = "Chocolate Cupcakes with Chocolate Buttercream",
                        Ingredients = new Ingredients("Chocolate"),
                        Size = "One Dozen",
                        Price = 9.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 9,
                        Title = "Chocolate Cake",
                        Description = "Chocolate Cake with Chocolate Buttercream",
                        Ingredients = new Ingredients("Chocolate"),
                        Size = "One three tiered cake",
                        Price = 14.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 10,
                        Title = "Vanilla and Chocolate Cupcakes",
                        Description = "Vanilla Cupcakes with Chocolate Buttercream",
                        Ingredients = new Ingredients("Chocolate", "Vanilla"),
                        Size = "One Dozen",
                        Price = 9.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 11,
                        Title = "Vanilla and Chocolate Cake",
                        Description = "Vanilla Cake with Chocolate Buttercream",
                        Ingredients = new Ingredients("Chocolate", "Vanilla"),
                        Size = "One three tiered cake",
                        Price = 14.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 12,
                        Title = "Chocolate and Vanilla Cupcakes",
                        Description = "Chocolate Cupcakes with Vanilla Buttercream",
                        Ingredients = new Ingredients("Chocolate", "Vanilla"),
                        Size = "One Dozen",
                        Price = 9.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 13,
                        Title = "Chocolate and Vanilla Cake",
                        Description = "Chocolate Cake with Vanilla Buttercream",
                        Ingredients = new Ingredients("Chocolate", "Vanilla"),
                        Size = "One three tiered cake",
                        Price = 14.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 14,
                        Title = "Chocolate and Strawberry Cupcakes",
                        Description = "Chocolate Cupcakes with Chocolate Buttercream and Strawberry filling",
                        Ingredients = new Ingredients("Chocolate","Strawberry"),
                        Size = "One Dozen",
                        Price = 14.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 15,
                        Title = "Chocolate and Strawberry Cake",
                        Description = "Chocolate Cake with Chocolate Buttercream and Strawberry filling",
                        Ingredients = new Ingredients("Chocolate", "Strawberry"),
                        Size = "One three tiered cake",
                        Price = 19.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 16,
                        Title = "Chocolate and Raspberry Cupcakes",
                        Description = "Chocolate Cupcakes with Chocolate Buttercream and Raspberry filling",
                        Ingredients = new Ingredients("Chocolate", "Raspberry"),
                        Size = "One Dozen",
                        Price = 14.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 17,
                        Title = "Chocolate and Raspberry Cake",
                        Description = "Chocolate Cake with Chocolate Buttercream and Raspberry filling",
                        Ingredients = new Ingredients("Chocolate", "Raspberry"),
                        Size = "One three tiered cake",
                        Price = 19.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 18,
                        Title = "Chocolate, Vanilla, and Strawbery Cupcakes",
                        Description = "Chocolate Cupcakes with Vanilla Buttercream and Strawberry filling",
                        Ingredients = new Ingredients("Chocolate", "Vanilla", "Strawberry"),
                        Size = "One Dozen",
                        Price = 14.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 19,
                        Title = "Chocolate, Vanilla, and Strawberry Cake",
                        Description = "Chocolate Cake with Vanilla Buttercream and Strawberry filling",
                        Ingredients = new Ingredients("Chocolate", "Vanilla", "Strawberry"),
                        Size = "One three tiered cake",
                        Price = 19.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 20,
                        Title = "Chocolate, Vanilla, and Raspberry Cupcakes",
                        Description = "Chocolate Cupcakes with Vanilla Buttercream and Raspberry filling",
                        Ingredients = new Ingredients("Chocolate", "Vanilla", "Raspberry"),
                        Size = "One Dozen",
                        Price = 14.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 21,
                        Title = "Chocolate, Vanilla, and Raspberry Cake",
                        Description = "Chocolate Cake with Vanilla Buttercream and Raspberry filling",
                        Ingredients = new Ingredients("Vanilla", "Raspberry"),
                        Size = "One three tiered cake",
                        Price = 19.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 22,
                        Title = "Vanilla and Strawberry Cupcakes",
                        Description = "Vanilla Cupcakes with Vanilla Buttercream and Strawberry filling",
                        Ingredients = new Ingredients("Vanilla", "Strawberry"),
                        Size = "One Dozen",
                        Price = 14.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 23,
                        Title = "Vanilla and Strawberry Cake",
                        Description = "Vanilla Cake with Vanilla Buttercream and Strawberry filling",
                        Ingredients = new Ingredients("Vanilla", "Strawberry"),
                        Size = "One three tiered cake",
                        Price = 19.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 24,
                        Title = "Vanilla and Raspberry Cupcakes",
                        Description = "Vanilla Cupcakes with Vanilla Buttercream and Raspberry filling",
                        Ingredients = new Ingredients("Vanilla", "Raspberry"),
                        Size = "One Dozen",
                        Price = 14.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 25,
                        Title = "Vanilla and Raspberry Cake",
                        Description = "Vanilla Cake with Vanilla Buttercream and Raspberry filling",
                        Ingredients = new Ingredients("Vanilla", "Raspberry"),
                        Size = "One three tiered cake",
                        Price = 19.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 26,
                        Title = "Vanilla and Peach Cupcakes",
                        Description = "Vanilla Cupcakes with Vanilla Buttercream and Peach filling",
                        Ingredients = new Ingredients("Vanilla", "Peach"),
                        Size = "One Dozen",
                        Price = 14.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 27,
                        Title = "Vanilla and Peach Cake",
                        Description = "Vanilla Cake with Vanilla Buttercream and Peach filling",
                        Ingredients = new Ingredients("Vanilla", "Peach"),
                        Size = "One three tiered cake",
                        Price = 19.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 28,
                        Title = "Vanilla and Mango Cupcakes",
                        Description = "Vanilla Cupcakes with Vanilla Buttercream and Mango filling",
                        Ingredients = new Ingredients("Vanilla", "Mango"),
                        Size = "One Dozen",
                        Price = 14.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 29,
                        Title = "Vanilla and Mango Cake",
                        Description = "Vanilla Cake with Vanilla Buttercream and Mango filling",
                        Ingredients = new Ingredients("Vanilla", "Mango"),
                        Size = "One three tiered cake",
                        Price = 19.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 30,
                        Title = "Vanilla and Blueberry Cupcakes",
                        Description = "Vanilla Cupcakes with Vanilla Buttercream and Blueberry filling",
                        Ingredients = new Ingredients("Vanilla", "Blueberry"),
                        Size = "One Dozen",
                        Price = 14.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 31,
                        Title = "Vanilla and Blueberry Cake",
                        Description = "Vanilla Cake with Vanilla Buttercream and Blueberry filling",
                        Ingredients = new Ingredients("Vanilla", "Blueberry"),
                        Size = "One three tiered cake",
                        Price = 19.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 32,
                        Title = "Lemon and Lavendar Cupcakes",
                        Description = "Lemon Cupcakes with Lavendar Buttercream",
                        Ingredients = new Ingredients("Lemon"),
                        Size = "One Dozen",
                        Price = 14.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 33,
                        Title = "Lemon and Lavendar Cake",
                        Description = "Lemon Cake with Lavendar Buttercream",
                        Ingredients = new Ingredients("Lemon"),
                        Size = "One three tiered cake",
                        Price = 19.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 34,
                        Title = "Lemon and Blueberry Cupcakes",
                        Description = "Lemon Cupcakes with Vanilla Buttercream and Blueberry Filling",
                        Ingredients = new Ingredients("Lemon", "Vanilla", "Blueberry"),
                        Size = "One Dozen",
                        Price = 19.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 35,
                        Title = "Lemon and Blueberry Cake",
                        Description = "Lemon Cake with Vanilla Buttercream and Blueberry Filling",
                        Ingredients = new Ingredients("Lemon", "Vanilla", "Blueberry"),
                        Size = "One three tiered cake",
                        Price = 24.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 36,
                        Title = "Lemon and Raspberry Cupcakes",
                        Description = "Lemon Cupcakes with Vanilla Buttercream and Raspberry Filling",
                        Ingredients = new Ingredients("Lemon", "Vanilla", "Raspberry"),
                        Size = "One Dozen",
                        Price = 19.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 37,
                        Title = "Lemon and Raspberry Cake",
                        Description = "Lemon Cake with Vanilla Buttercream and Raspberry Filling",
                        Ingredients = new Ingredients("Lemon", "Vanilla", "Raspberry"),
                        Size = "One three tiered cake",
                        Price = 24.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 38,
                        Title = "Red Velvet Cupcakes",
                        Description = "Red Velvet Cupcakes with Cream Cheese Frosting",
                        Ingredients = new Ingredients("RedVelvet", "Chocolate"),
                        Size = "One Dozen",
                        Price = 9.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 39,
                        Title = "Red Velvet Cake",
                        Description = "Red Velvet Cake with Cream Cheese Frosting",
                        Ingredients = new Ingredients("RedVelvet", "Chocolate"),
                        Size = "One three tiered cake",
                        Price = 14.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 40,
                        Title = "Pumpkin Cupcakes",
                        Description = "Pumpkin Cupcakes with Cream Cheese Frosting",
                        Ingredients = new Ingredients("Spice"),
                        Size = "One Dozen",
                        Price = 9.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 41,
                        Title = "Pumpkin Cake",
                        Description = "Pumpkin Cake with Cream Cheese Frosting",
                        Ingredients = new Ingredients("Spice"),
                        Size = "One three tiered cake",
                        Price = 14.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 42,
                        Title = "Chocolate and Bailey Cupcakes",
                        Description = "Chocolate Cupcakes with Bailey's Buttercream",
                        Ingredients = new Ingredients("Chocolate"),
                        Size = "One Dozen",
                        Price = 14.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 43,
                        Title = "Chocolate and Bailey's Cake",
                        Description = "Chocolate Cake with Bailey's Buttercream with Bailey's ganache filling",
                        Ingredients = new Ingredients("Chocolate"),
                        Size = "One three tiered cake",
                        Price = 19.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 44,
                        Title = "Chocolate and Peppermint Cupcakes",
                        Description = "Chocolate Cupcakes with Peppermint Buttercream",
                        Ingredients = new Ingredients("Chocolate"),
                        Size = "One Dozen",
                        Price = 14.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 45,
                        Title = "Chocolate and Peppermint Cake",
                        Description = "Chocolate Cake with Peppermint Buttercream",
                        Ingredients = new Ingredients("Chocolate"),
                        Size = "One three tiered cake",
                        Price = 19.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 46,
                        Title = "Vanilla Cranberry Cupcakes",
                        Description = "Vanilla Cupcakes with White Chocolate Buttercream with Cranberry filling",
                        Ingredients = new Ingredients("Vanilla", "Chocolate"),
                        Size = "One Dozen",
                        Price = 14.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 47,
                        Title = "Vanilla Cranberry Cake",
                        Description = "Vanilla Cake with White Chocolate Buttercream with Cranberry filling",
                        Ingredients = new Ingredients("Vanilla", "Chocolate"),
                        Size = "One three tiered cake",
                        Price = 19.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 48,
                        Title = "Strawberry and Cream Cheese Pastry Pinwheels",
                        Description = "Pastry Pinwheels filled with Cream Cheese and Strawberry",
                        Ingredients = new Ingredients("Strawberry"),
                        Size = "One Dozen",
                        Price = 14.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 49,
                        Title = "Raspberry and Cream Cheese Pastry Pinwheels",
                        Description = "Pastry Pinwheels filled with Cream Cheese and Raspberry",
                        Ingredients = new Ingredients("Raspberry"),
                        Size = "One Dozen",
                        Price = 14.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 50,
                        Title = "Peach and Cream Cheese Pastry Pinwheels",
                        Description = "Pastry Pinwheels filled with Cream Cheese and Peach",
                        Ingredients = new Ingredients("Peach"),
                        Size = "One Dozen",
                        Price = 14.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 51,
                        Title = "Mango and Cream Cheese Pastry Pinwheels",
                        Description = "Pastry Pinwheels filled with Cream Cheese and Mango",
                        Ingredients = new Ingredients("Mango"),
                        Size = "One Dozen",
                        Price = 14.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 52,
                        Title = "Blueberry and Cream Cheese Pastry Pinwheels",
                        Description = "Pastry Pinwheels filled with Cream Cheese and Blueberry",
                        Ingredients = new Ingredients("Blueberry"),
                        Size = "One Dozen",
                        Price = 14.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 53,
                        Title = "Blackberry and Cream Cheese Pastry Pinwheels",
                        Description = "Pastry Pinwheels filled with Cream Cheese and Blackberry",
                        Ingredients = new Ingredients("Blackberry"),
                        Size = "One Dozen",
                        Price = 14.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 54,
                        Title = "Raspberry Oat Bars",
                        Description = "Oat Bars with a Raspberry filling",
                        Ingredients = new Ingredients("Raspberry"),
                        Size = "One Dozen",
                        Price = 14.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 55,
                        Title = "Strawberry Oat Bars",
                        Description = "Oat Bars with a Strawberry filling",
                        Ingredients = new Ingredients("Strawberry"),
                        Size = "One Dozen",
                        Price = 14.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 56,
                        Title = "Peach Oat Bars",
                        Description = "Oat Bars with a Peach filling",
                        Ingredients = new Ingredients("Peach"),
                        Size = "One Dozen",
                        Price = 14.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 57,
                        Title = "Mango Oat Bars",
                        Description = "Oat Bars with a Mango filling",
                        Ingredients = new Ingredients("Mango"),
                        Size = "One Dozen",
                        Price = 14.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 58,
                        Title = "Blueberry Oat Bars",
                        Description = "Oat Bars with a Blueberry filling",
                        Ingredients = new Ingredients("Peach"),
                        Size = "One Dozen",
                        Price = 14.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 59,
                        Title = "Blackberry Oat Bars",
                        Description = "Oat Bars with a Blackberry filling",
                        Ingredients = new Ingredients("Blackberry"),
                        Size = "One Dozen",
                        Price = 14.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 60,
                        Title = "Apple Pie",
                        Description = "Apple Pie",
                        Ingredients = new Ingredients( ),
                        Size = "One Pie",
                        Price = 14.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 61,
                        Title = "Chocolate Pie",
                        Description = "Chocolate Pie",
                        Ingredients = new Ingredients("Chocolate"),
                        Size = "One Pie",
                        Price = 14.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 62,
                        Title = "Pecan Pie",
                        Description = "Pecan Pie",
                        Ingredients = new Ingredients("Pecan"),
                        Size = "One Pie",
                        Price = 14.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 63,
                        Title = "Peach Cobbler",
                        Description = "Peach Cobbler",
                        Ingredients = new Ingredients("Peach"),
                        Size = "One tray",
                        Price = 14.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 64,
                        Title = "Blueberry Cobbler",
                        Description = "Blueberry Cobbler",
                        Ingredients = new Ingredients("Blueberry"),
                        Size = "One tray",
                        Price = 14.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 65,
                        Title = "Blackberry Cobbler",
                        Description = "Blackberry Cobbler",
                        Ingredients = new Ingredients("Blackberry"),
                        Size = "One tray",
                        Price = 14.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 66,
                        Title = "Strawberry Cobbler",
                        Description = "Strawberry Cobbler",
                        Ingredients = new Ingredients("Strawberry"),
                        Size = "One tray",
                        Price = 14.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 67,
                        Title = "Peach and Pecan Cobbler",
                        Description = "Peach and Pecan Cobbler",
                        Ingredients = new Ingredients("Peach", "Pecan"),
                        Size = "One tray",
                        Price = 14.99
                    }, 

                   new ReciepeModel()
                   {
                       ReciepeNumber = 68,
                       Title = "Vegan Brownies",
                       Description = "Vegan Brownies made with vegan butter, vegan chocolate chips, and flax seed",
                       Ingredients = new Ingredients("Chocolate"),
                       Size = "One tray",
                       Price = 14.99
                   },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 69,
                        Title = "Vegan Chocolate Cake",
                        Description = "Vegan Chocolate Cake made with vegan butter, vegan chocolate chips, and apple sauce",
                        Ingredients = new Ingredients("Chocolate"),
                        Size = "One three tiered cake",
                        Price = 14.99
                    },
                    new ReciepeModel()
                    {
                        ReciepeNumber = 70,
                        Title = "Vanilla, Chocolate, and Strawbery Cupcakes",
                        Description = "Vanilla Cupcakes with Chocolate Buttercream and Strawberry filling",
                        Ingredients = new Ingredients("Vanilla", "Chocolate", "Strawberry"),
                        Size = "One Dozen",
                        Price = 14.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 71,
                        Title = "Vanilla, Chocolate, and Strawberry Cake",
                        Description = "Vanilla Cake with Chocolate Buttercream and Strawberry filling",
                        Ingredients = new Ingredients("Vanilla", "Chocolate", "Strawberry"),
                        Size = "One three tiered cake",
                        Price = 19.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 72,
                        Title = "Vanilla, Chocolate, and Raspberry Cupcakes",
                        Description = "Vanilla Cupcakes with Chocolate Buttercream and Raspberry filling",
                        Ingredients = new Ingredients("Vanilla", "Chocolate", "Raspberry"),
                        Size = "One Dozen",
                        Price = 14.99
                    },

                    new ReciepeModel()
                    {
                        ReciepeNumber = 73,
                        Title = "Vanilla, Chocolate, and Raspberry Cake",
                        Description = "Vanilla Cake with Chocolate Buttercream and Raspberry filling",
                        Ingredients = new Ingredients("Vanilla", "Chocolate", "Raspberry"),
                        Size = "One three tiered cake",
                        Price = 19.99
                    }
                );

                context.SaveChanges();

                context.ReciepeBook.AddRange(
                    new ReciepeBook()
                    {
                        Id = 1,
                        Title = "Chocolate",
                        Reciepes = 
                        { 
                            context.Reciepes.Find(1), 
                            context.Reciepes.Find(3), 
                            context.Reciepes.Find(8), 
                            context.Reciepes.Find(9), 
                            context.Reciepes.Find(61) 
                        },
                        Chapters = { 
                        
                            new ReciepeBook()
                            {
                                Id = 11,
                                Title = "Vanilla",
                                Reciepes = 
                                { 
                                    context.Reciepes.Find(12), 
                                    context.Reciepes.Find(13), 
                                    context.Reciepes.Find(18), 
                                    context.Reciepes.Find(19), 
                                    context.Reciepes.Find(20), 
                                    context.Reciepes.Find(21)
                                },
                                Chapters = { }
                            },

                            new ReciepeBook()
                            {
                                Id = 12,
                                Title = "Fruit",
                                Reciepes = 
                                { 
                                    context.Reciepes.Find(14), 
                                    context.Reciepes.Find(15), 
                                    context.Reciepes.Find(16), 
                                    context.Reciepes.Find(17)
                                },
                                Chapters = { }
                            },

                            new ReciepeBook()
                            {
                                Id = 13,
                                Title = "Misc",
                                Reciepes = 
                                { 
                                    context.Reciepes.Find(42), 
                                    context.Reciepes.Find(43), 
                                    context.Reciepes.Find(44), 
                                    context.Reciepes.Find(45)
                                },
                                Chapters = { }
                            }

                        }

                    },

                    new ReciepeBook()
                    {
                        Id = 2,
                        Title = "Vanilla",
                        Reciepes = 
                        { 
                            context.Reciepes.Find(6), 
                            context.Reciepes.Find(7), 
                            context.Reciepes.Find(2) 
                        },
                        Chapters = {

                            new ReciepeBook()
                            {
                                Id = 21,
                                Title = "Chocolate",
                                Reciepes = 
                                { 
                                    context.Reciepes.Find(10), 
                                    context.Reciepes.Find(11), 
                                    context.Reciepes.Find(70), 
                                    context.Reciepes.Find(71), 
                                    context.Reciepes.Find(72), 
                                    context.Reciepes.Find(73)
                                },
                                Chapters = { }
                            },

                            new ReciepeBook()
                            {
                                Id = 22,
                                Title = "Fruit",
                                Reciepes = 
                                { 
                                    context.Reciepes.Find(26), 
                                    context.Reciepes.Find(27), 
                                    context.Reciepes.Find(28), 
                                    context.Reciepes.Find(29), 
                                    context.Reciepes.Find(22), 
                                    context.Reciepes.Find(23),
                                    context.Reciepes.Find(24), 
                                    context.Reciepes.Find(25), 
                                    context.Reciepes.Find(30), 
                                    context.Reciepes.Find(31), 
                                    context.Reciepes.Find(46), 
                                    context.Reciepes.Find(47)
                                },
                                Chapters = { }

                            }

                        }

                    },

                    new ReciepeBook()
                    {
                        Id = 3,
                        Title = "Fruit",
                        Reciepes = 
                        { 
                            context.Reciepes.Find(60) 
                        },
                        Chapters = {

                            new ReciepeBook()
                            {
                                Id = 31,
                                Title = "Lemon",
                                Reciepes = 
                                { 
                                    context.Reciepes.Find(32),
                                    context.Reciepes.Find(33), 
                                    context.Reciepes.Find(34), 
                                    context.Reciepes.Find(35), 
                                    context.Reciepes.Find(36), 
                                    context.Reciepes.Find(37)
                                },
                                Chapters = { }
                            },
                            new ReciepeBook()
                            {
                                Id = 32,
                                Title = "Strawberry",
                                Reciepes = 
                                { 
                                    context.Reciepes.Find(48),
                                    context.Reciepes.Find(55), 
                                    context.Reciepes.Find(66)
                                },
                                Chapters = { }
                            },
                            new ReciepeBook()
                            {
                                Id = 33,
                                Title = "Raspberry",
                                Reciepes = 
                                { 
                                    context.Reciepes.Find(49), 
                                    context.Reciepes.Find(54)
                                },
                                Chapters = { }
                            },
                            new ReciepeBook()
                            {
                                Id = 34,
                                Title = "Peach",
                                Reciepes = 
                                { 
                                    context.Reciepes.Find(50), 
                                    context.Reciepes.Find(56), 
                                    context.Reciepes.Find(63), 
                                    context.Reciepes.Find(67)
                                },
                                Chapters = { }
                            },
                            new ReciepeBook()
                            {
                                Id = 35,
                                Title = "Mango",
                                Reciepes = 
                                { 
                                    context.Reciepes.Find(51), 
                                    context.Reciepes.Find(57)
                                },
                                Chapters = { }
                            },
                            new ReciepeBook()
                            {
                                Id = 36,
                                Title = "BLueberry",
                                Reciepes = 
                                { 
                                    context.Reciepes.Find(52), 
                                    context.Reciepes.Find(58), 
                                    context.Reciepes.Find(64)
                                },
                                Chapters = { }
                            },
                            new ReciepeBook()
                            {
                                Id = 37,
                                Title = "Blackberry",
                                Reciepes = 
                                { 
                                    context.Reciepes.Find(53), 
                                    context.Reciepes.Find(59), 
                                    context.Reciepes.Find(65)
                                },
                                Chapters = { }
                            }

                        }

                    },

                    new ReciepeBook()
                    {
                        Id = 4,
                        Title = "Misc",
                        Reciepes = 
                        { 
                            context.Reciepes.Find(5), 
                            context.Reciepes.Find(62), 
                            context.Reciepes.Find(40), 
                            context.Reciepes.Find(41), 
                            context.Reciepes.Find(38), 
                            context.Reciepes.Find(39), 
                            context.Reciepes.Find(4) 
                        },
                        Chapters = { }

                    },

                    new ReciepeBook()
                    {
                        Id = 5,
                        Title = "Vegan",
                        Reciepes = 
                        {
                            context.Reciepes.Find(68),
                            context.Reciepes.Find(69)
                        },
                        Chapters = { }

                    }
                );
                context.SaveChanges();

            }
        }
        
        /*
        protected void Seed(OrderModelContext context)
        {
            var reciepes = new List<ReciepeModel> {
                new ReciepeModel()
                {
                    ReciepeNumber = 1,
                    Title = "Chocolate Chip Cookies",
                    Description = "Chocolate Chip Cookies",
                    Ingredients = { "Chocolate"},
                    Size = "One Dozen",
                    Price = 9.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 2,
                    Title = "Sugar Cookies",
                    Description = "Sugar Cookies",
                    Ingredients = { "Vanilla" },
                    Size = "One Dozen",
                    Price = 9.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 3,
                    Title = "Chocolate Crinkle Cookies",
                    Description = "Chocolate Crinkle Cookies",
                    Ingredients = { "Chocolate" },
                    Size = "One Dozen",
                    Price = 14.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 4,
                    Title = "Red Velvet Crinkle Cookies",
                    Description = "Red Velvet Crinkle Cookies",
                    Ingredients = { "Chocolate" },
                    Size = "One Dozen",
                    Price = 14.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 5,
                    Title = "Snicker Doodle Cookies",
                    Description = "Snicker Doodle Cookies",
                    Ingredients = { "Spices" },
                    Size = "One Dozen",
                    Price = 9.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 6,
                    Title = "Vanilla Cupcakes",
                    Description = "Vanilla Cupcakes with Vanilla Buttercream",
                    Ingredients = { "Vanilla" },
                    Size = "One Dozen",
                    Price = 9.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 7,
                    Title = "Vanilla Cake",
                    Description = "Vanilla Cake with Vanilla Buttercream",
                    Ingredients = { "Vanilla" },
                    Size = "One three tiered cake",
                    Price = 14.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 8,
                    Title = "Chocolate Cupcakes",
                    Description = "Chocolate Cupcakes with Chocolate Buttercream",
                    Ingredients = { "Chocolate" },
                    Size = "One Dozen",
                    Price = 9.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 9,
                    Title = "Chocolate Cake",
                    Description = "Chocolate Cake with Chocolate Buttercream",
                    Ingredients = { "Chocolate" },
                    Size = "One three tiered cake",
                    Price = 14.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 10,
                    Title = "Vanilla and Chocolate Cupcakes",
                    Description = "Vanilla Cupcakes with Chocolate Buttercream",
                    Ingredients = { "Vanilla", "Chocolate" },
                    Size = "One Dozen",
                    Price = 9.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 11,
                    Title = "Vanilla and Chocolate Cake",
                    Description = "Vanilla Cake with Chocolate Buttercream",
                    Ingredients = { "Vanilla", "Chocolate" },
                    Size = "One three tiered cake",
                    Price = 14.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 12,
                    Title = "Chocolate and Vanilla Cupcakes",
                    Description = "Chocolate Cupcakes with Vanilla Buttercream",
                    Ingredients = { "Chocolate", "Vanilla" },
                    Size = "One Dozen",
                    Price = 9.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 13,
                    Title = "Chocolate and Vanilla Cake",
                    Description = "Chocolate Cake with Vanilla Buttercream",
                    Ingredients = { "Chocolate", "Vanilla" },
                    Size = "One three tiered cake",
                    Price = 14.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 14,
                    Title = "Chocolate and Strawberry Cupcakes",
                    Description = "Chocolate Cupcakes with Chocolate Buttercream and Strawberry filling",
                    Ingredients = { "Chocolate", "Strawberry" },
                    Size = "One Dozen",
                    Price = 14.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 15,
                    Title = "Chocolate and Strawberry Cake",
                    Description = "Chocolate Cake with Chocolate Buttercream and Strawberry filling",
                    Ingredients = { "Chocolate", "Strawberry" },
                    Size = "One three tiered cake",
                    Price = 19.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 16,
                    Title = "Chocolate and Raspberry Cupcakes",
                    Description = "Chocolate Cupcakes with Chocolate Buttercream and Raspberry filling",
                    Ingredients = { "Chocolate", "Raspberry" },
                    Size = "One Dozen",
                    Price = 14.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 17,
                    Title = "Chocolate and Raspberry Cake",
                    Description = "Chocolate Cake with Chocolate Buttercream and Raspberry filling",
                    Ingredients = { "Chocolate", "Raspberry" },
                    Size = "One three tiered cake",
                    Price = 19.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 18,
                    Title = "Chocolate, Vanilla, and Strawbery Cupcakes",
                    Description = "Chocolate Cupcakes with Vanilla Buttercream and Strawberry filling",
                    Ingredients = { "Chocolate", "Vanilla", "Strawberry" },
                    Size = "One Dozen",
                    Price = 14.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 19,
                    Title = "Chocolate, Vanilla, and Strawberry Cake",
                    Description = "Chocolate Cake with Vanilla Buttercream and Strawberry filling",
                    Ingredients = { "Chocolate", "Vanilla", "Strawberry" },
                    Size = "One three tiered cake",
                    Price = 19.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 20,
                    Title = "Chocolate, Vanilla, and Raspberry Cupcakes",
                    Description = "Chocolate Cupcakes with Vanilla Buttercream and Raspberry filling",
                    Ingredients = { "Chocolate", "Vanilla", "Raspberry" },
                    Size = "One Dozen",
                    Price = 14.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 21,
                    Title = "Chocolate, Vanilla, and Raspberry Cake",
                    Description = "Chocolate Cake with Vanilla Buttercream and Raspberry filling",
                    Ingredients = { "Chocolate", "Vanilla", "Raspberry" },
                    Size = "One three tiered cake",
                    Price = 19.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 22,
                    Title = "Vanilla and Strawberry Cupcakes",
                    Description = "Vanilla Cupcakes with Vanilla Buttercream and Strawberry filling",
                    Ingredients = { "Vanilla", "Strawberry" },
                    Size = "One Dozen",
                    Price = 14.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 23,
                    Title = "Vanilla and Strawberry Cake",
                    Description = "Vanilla Cake with Vanilla Buttercream and Strawberry filling",
                    Ingredients = { "Vanilla", "Strawberry" },
                    Size = "One three tiered cake",
                    Price = 19.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 24,
                    Title = "Vanilla and Raspberry Cupcakes",
                    Description = "Vanilla Cupcakes with Vanilla Buttercream and Raspberry filling",
                    Ingredients = { "Vanilla", "Raspberry" },
                    Size = "One Dozen",
                    Price = 14.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 25,
                    Title = "Vanilla and Raspberry Cake",
                    Description = "Vanilla Cake with Vanilla Buttercream and Raspberry filling",
                    Ingredients = { "Vanilla", "Raspberry" },
                    Size = "One three tiered cake",
                    Price = 19.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 26,
                    Title = "Vanilla and Peach Cupcakes",
                    Description = "Vanilla Cupcakes with Vanilla Buttercream and Peach filling",
                    Ingredients = { "Vanilla", "Peach" },
                    Size = "One Dozen",
                    Price = 14.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 27,
                    Title = "Vanilla and Peach Cake",
                    Description = "Vanilla Cake with Vanilla Buttercream and Peach filling",
                    Ingredients = { "Vanilla", "Peach" },
                    Size = "One three tiered cake",
                    Price = 19.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 28,
                    Title = "Vanilla and Mango Cupcakes",
                    Description = "Vanilla Cupcakes with Vanilla Buttercream and Mango filling",
                    Ingredients = { "Vanilla", "Mango" },
                    Size = "One Dozen",
                    Price = 14.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 29,
                    Title = "Vanilla and Mango Cake",
                    Description = "Vanilla Cake with Vanilla Buttercream and Mango filling",
                    Ingredients = { "Vanilla", "Mango" },
                    Size = "One three tiered cake",
                    Price = 19.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 30,
                    Title = "Vanilla and Blueberry Cupcakes",
                    Description = "Vanilla Cupcakes with Vanilla Buttercream and Blueberry filling",
                    Ingredients = { "Vanilla", "Blueberry" },
                    Size = "One Dozen",
                    Price = 14.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 31,
                    Title = "Vanilla and Blueberry Cake",
                    Description = "Vanilla Cake with Vanilla Buttercream and Blueberry filling",
                    Ingredients = { "Vanilla", "Blueberry" },
                    Size = "One three tiered cake",
                    Price = 19.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 32,
                    Title = "Lemon and Lavendar Cupcakes",
                    Description = "Lemon Cupcakes with Lavendar Buttercream",
                    Ingredients = { "Lemon", "Lavendar" },
                    Size = "One Dozen",
                    Price = 14.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 33,
                    Title = "Lemon and Lavendar Cake",
                    Description = "Lemon Cake with Lavendar Buttercream",
                    Ingredients = { "Lemon", "Lavendar" },
                    Size = "One three tiered cake",
                    Price = 19.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 34,
                    Title = "Lemon and Blueberry Cupcakes",
                    Description = "Lemon Cupcakes with Vanilla Buttercream and Blueberry Filling",
                    Ingredients = { "Lemon", "Vanilla", "Blueberry" },
                    Size = "One Dozen",
                    Price = 19.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 35,
                    Title = "Lemon and Blueberry Cake",
                    Description = "Lemon Cake with Vanilla Buttercream and Blueberry Filling",
                    Ingredients = { "Lemon", "Vanilla", "Blueberry" },
                    Size = "One three tiered cake",
                    Price = 24.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 36,
                    Title = "Lemon and Raspberry Cupcakes",
                    Description = "Lemon Cupcakes with Vanilla Buttercream and Raspberry Filling",
                    Ingredients = { "Lemon", "Vanilla", "Raspberry" },
                    Size = "One Dozen",
                    Price = 19.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 37,
                    Title = "Lemon and Raspberry Cake",
                    Description = "Lemon Cake with Vanilla Buttercream and Raspberry Filling",
                    Ingredients = { "Lemon", "Vanilla", "Raspberry" },
                    Size = "One three tiered cake",
                    Price = 24.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 38,
                    Title = "Red Velvet Cupcakes",
                    Description = "Red Velvet Cupcakes with Cream Cheese Frosting",
                    Ingredients = { "Red Velvet", "Chocolate", "Cream Cheese" },
                    Size = "One Dozen",
                    Price = 9.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 39,
                    Title = "Red Velvet Cake",
                    Description = "Red Velvet Cake with Cream Cheese Frosting",
                    Ingredients = { "Red Velvet", "Chocolate", "Cream Cheese" },
                    Size = "One three tiered cake",
                    Price = 14.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 40,
                    Title = "Pumpkin Cupcakes",
                    Description = "Pumpkin Cupcakes with Cream Cheese Frosting",
                    Ingredients = { "Pumpkin", "Cream Cheese" },
                    Size = "One Dozen",
                    Price = 9.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 41,
                    Title = "Pumpkin Cake",
                    Description = "Pumpkin Cake with Cream Cheese Frosting",
                    Ingredients = { "Pumpkin", "Cream Cheese" },
                    Size = "One three tiered cake",
                    Price = 14.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 42,
                    Title = "Chocolate and Bailey Cupcakes",
                    Description = "Chocolate Cupcakes with Bailey's Buttercream",
                    Ingredients = { "Chocolate", "Baileys" },
                    Size = "One Dozen",
                    Price = 14.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 43,
                    Title = "Chocolate and Bailey's Cake",
                    Description = "Chocolate Cake with Bailey's Buttercream with Bailey's ganache filling",
                    Ingredients = { "Chocolate", "Baileys" },
                    Size = "One three tiered cake",
                    Price = 19.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 44,
                    Title = "Chocolate and Peppermint Cupcakes",
                    Description = "Chocolate Cupcakes with Peppermint Buttercream",
                    Ingredients = { "Chocolate", "Peppermint" },
                    Size = "One Dozen",
                    Price = 14.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 45,
                    Title = "Chocolate and Peppermint Cake",
                    Description = "Chocolate Cake with Peppermint Buttercream",
                    Ingredients = { "Chocolate", "Peppermint" },
                    Size = "One three tiered cake",
                    Price = 19.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 46,
                    Title = "Vanilla Cranberry Cupcakes",
                    Description = "Vanilla Cupcakes with White Chocolate Buttercream with Cranberry filling",
                    Ingredients = { "Vanilla", "Chocolate", "Cranberry" },
                    Size = "One Dozen",
                    Price = 14.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 47,
                    Title = "Vanilla Cranberry Cake",
                    Description = "Vanilla Cake with White Chocolate Buttercream with Cranberry filling",
                    Ingredients = { "Vanilla", "Chocolate", "Cranberry" },
                    Size = "One three tiered cake",
                    Price = 19.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 48,
                    Title = "Strawberry and Cream Cheese Pastry Pinwheels",
                    Description = "Pastry Pinwheels filled with Cream Cheese and Strawberry",
                    Ingredients = { "Cream Cheese", "Strawberry" },
                    Size = "One Dozen",
                    Price = 14.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 49,
                    Title = "Raspberry and Cream Cheese Pastry Pinwheels",
                    Description = "Pastry Pinwheels filled with Cream Cheese and Raspberry",
                    Ingredients = { "Cream Cheese", "Raspberry" },
                    Size = "One Dozen",
                    Price = 14.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 50,
                    Title = "Peach and Cream Cheese Pastry Pinwheels",
                    Description = "Pastry Pinwheels filled with Cream Cheese and Peach",
                    Ingredients = { "Cream Cheese", "Peach" },
                    Size = "One Dozen",
                    Price = 14.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 51,
                    Title = "Mango and Cream Cheese Pastry Pinwheels",
                    Description = "Pastry Pinwheels filled with Cream Cheese and Mango",
                    Ingredients = { "Cream Cheese", "Mango" },
                    Size = "One Dozen",
                    Price = 14.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 52,
                    Title = "Blueberry and Cream Cheese Pastry Pinwheels",
                    Description = "Pastry Pinwheels filled with Cream Cheese and Blueberry",
                    Ingredients = { "Cream Cheese", "Blueberry" },
                    Size = "One Dozen",
                    Price = 14.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 53,
                    Title = "Blackberry and Cream Cheese Pastry Pinwheels",
                    Description = "Pastry Pinwheels filled with Cream Cheese and Blackberry",
                    Ingredients = { "Cream Cheese", "Blackberry" },
                    Size = "One Dozen",
                    Price = 14.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 54,
                    Title = "Raspberry Oat Bars",
                    Description = "Oat Bars with a Raspberry filling",
                    Ingredients = { "Raspberry" },
                    Size = "One Dozen",
                    Price = 14.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 55,
                    Title = "Strawberry Oat Bars",
                    Description = "Oat Bars with a Strawberry filling",
                    Ingredients = { "Strawberry" },
                    Size = "One Dozen",
                    Price = 14.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 56,
                    Title = "Peach Oat Bars",
                    Description = "Oat Bars with a Peach filling",
                    Ingredients = { "Peach" },
                    Size = "One Dozen",
                    Price = 14.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 57,
                    Title = "Mango Oat Bars",
                    Description = "Oat Bars with a Mango filling",
                    Ingredients = { "Mango" },
                    Size = "One Dozen",
                    Price = 14.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 58,
                    Title = "Blueberry Oat Bars",
                    Description = "Oat Bars with a Blueberry filling",
                    Ingredients = { "Blueberry" },
                    Size = "One Dozen",
                    Price = 14.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 59,
                    Title = "Blackberry Oat Bars",
                    Description = "Oat Bars with a Blackberry filling",
                    Ingredients = { "Blackberry" },
                    Size = "One Dozen",
                    Price = 14.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 60,
                    Title = "Apple Pie",
                    Description = "Apple Pie",
                    Ingredients = { "Apple" },
                    Size = "One Pie",
                    Price = 14.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 61,
                    Title = "Chocolate Pie",
                    Description = "Chocolate Pie",
                    Ingredients = { "Chocolate" },
                    Size = "One Pie",
                    Price = 14.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 62,
                    Title = "Pecan Pie",
                    Description = "Pecan Pie",
                    Ingredients = { "Pecan" },
                    Size = "One Pie",
                    Price = 14.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 63,
                    Title = "Peach Cobbler",
                    Description = "Peach Cobbler",
                    Ingredients = { "Peach" },
                    Size = "One tray",
                    Price = 14.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 64,
                    Title = "Blueberry Cobbler",
                    Description = "Blueberry Cobbler",
                    Ingredients = { "Blueberry" },
                    Size = "One tray",
                    Price = 14.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 65,
                    Title = "Blackberry Cobbler",
                    Description = "Blackberry Cobbler",
                    Ingredients = { "Blackberry" },
                    Size = "One tray",
                    Price = 14.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 66,
                    Title = "Strawberry Cobbler",
                    Description = "Strawberry Cobbler",
                    Ingredients = { "Strawberry" },
                    Size = "One tray",
                    Price = 14.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 67,
                    Title = "Peach and Pecan Cobbler",
                    Description = "Peach and Pecan Cobbler",
                    Ingredients = { "Peach", "Pecan" },
                    Size = "One tray",
                    Price = 14.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 68,
                    Title = "Vegan Brownies",
                    Description = "Vegan Brownies made with vegan butter, vegan chocolate chips, and flax seed",
                    Ingredients = { "Chocolate" },
                    Size = "One tray",
                    Price = 14.99
                },

                new ReciepeModel()
                {
                    ReciepeNumber = 69,
                    Title = "Vegan Chocolate Cake",
                    Description = "Vegan Chocolate Cake made with vegan butter, vegan chocolate chips, and apple sauce",
                    Ingredients = { "Chocolate" },
                    Size = "One three tiered cake",
                    Price = 14.99
                }
            };

            //reciepes.ForEach(r => context.Reciepes.AddOrUpdate(s));
            //context.SaveChanges();

            var books = new List<ReciepeBook> {

            new ReciepeBook()
                {
                    Id = 1,
                    Title = "Chocolate",
                    Reciepes = { },
                    Chapters = {

                        new ReciepeBook()
                        {
                            Id = 11,
                            Title = "Vanilla",
                            Reciepes = { },
                            Chapters = { }
                        },

                        new ReciepeBook()
                        {
                            Id = 12,
                            Title = "Fruit",
                            Reciepes = { },
                            Chapters = { }
                        },

                        new ReciepeBook()
                        {
                            Id = 13,
                            Title = "Misc",
                            Reciepes = { },
                            Chapters = { }
                        }

                    }

                },

                new ReciepeBook()
                {
                    Id = 2,
                    Title = "Vanilla",
                    Reciepes = { },
                    Chapters = {

                        new ReciepeBook()
                        {
                            Id = 21,
                            Title = "Chocolate",
                            Reciepes = { },
                            Chapters = { }
                        },

                        new ReciepeBook()
                        {
                            Id = 22,
                            Title = "Fruit",
                            Reciepes = { },
                            Chapters = { }
                        }

                    }

                },

                new ReciepeBook()
                {
                    Id = 3,
                    Title = "Fruit",
                    Reciepes = { },
                    Chapters = {

                        new ReciepeBook()
                        {
                            Id = 31,
                            Title = "Lemon",
                            Reciepes = { },
                            Chapters = { }
                        },
                        new ReciepeBook()
                        {
                            Id = 32,
                            Title = "Strawberry",
                            Reciepes = { },
                            Chapters = { }
                        },
                        new ReciepeBook()
                        {
                            Id = 33,
                            Title = "Raspberry",
                            Reciepes = { },
                            Chapters = { }
                        },
                        new ReciepeBook()
                        {
                            Id = 34,
                            Title = "Peach",
                            Reciepes = { },
                            Chapters = { }
                        },
                        new ReciepeBook()
                        {
                            Id = 35,
                            Title = "Mango",
                            Reciepes = { },
                            Chapters = { }
                        },
                        new ReciepeBook()
                        {
                            Id = 36,
                            Title = "BLueberry",
                            Reciepes = { },
                            Chapters = { }
                        },
                        new ReciepeBook()
                        {
                            Id = 37,
                            Title = "Blackberry",
                            Reciepes = { },
                            Chapters = { }
                        }

                    }

                },

                new ReciepeBook()
                {
                    Id = 4,
                    Title = "Misc",
                    Reciepes = { },
                    Chapters = { }

                },

                new ReciepeBook()
                {
                    Id = 4,
                    Title = "Vegan",
                    Reciepes =
                    {

                        new ReciepeModel()
                        {
                            ReciepeNumber = 68,
                            Title = "Vegan Brownies",
                            Description = "Vegan Brownies made with vegan butter, vegan chocolate chips, and flax seed",
                            Ingredients = { "Chocolate" },
                            Size = "One tray",
                            Price = 14.99
                        },

                        new ReciepeModel()
                        {
                            ReciepeNumber = 69,
                            Title = "Vegan Chocolate Cake",
                            Description = "Vegan Chocolate Cake made with vegan butter, vegan chocolate chips, and apple sauce",
                            Ingredients = { "Chocolate" },
                            Size = "One three tiered cake",
                            Price = 14.99
                        }

                    },
                    Chapters = { }

                }



            };

        }

        */
    }
}
