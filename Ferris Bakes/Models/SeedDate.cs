using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using Ferris_Bakes.Data;
using System.Collections.Generic;
using Ferris_Bakes.Entities;
using System.Diagnostics;

namespace Ferris_Bakes.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new FerrisBakesContext(
               serviceProvider.GetRequiredService<
                   DbContextOptions<FerrisBakesContext>>()))
            {
                SeedSetOrder(context);
                SeedReciepes(context);
                SeedChapters(context);
                SeedReciepeBooks(context);
                SeedIngredients(context);

                clearCart(context);
            }

        }
        
        public static void SeedSetOrder(FerrisBakesContext context)
        {
           
            // Look for any orders.
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
                    Price = 34.99,
                    ImgPath = "/bakes/square/21st choc and baileys.jpg"
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
                    Price = 24.99,
                    ImgPath = "/bakes/square/dec red vel.jpeg"
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
                    Price = 9.99,
                    ImgPath = "/bakes/square/mini lemon bunt cakes.jpg"
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
                    Price = 19.99,
                    ImgPath = "/bakes/square/pound cake.jpeg"
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
                    Price = 19.99,
                    ImgPath = "/bakes/square/no Photo.jpg"
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
                    Price = 19.99,
                    ImgPath = "/bakes/square/no Photo.jpg"
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
                    Price = 14.99,
                    ImgPath = "/bakes/square/crinkle cookies.jpg"
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
                    Price = 14.99,
                    ImgPath = "/bakes/square/no Photo.jpg"
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
                    Price = 9.99,
                    ImgPath = "/bakes/square/no Photo.jpg"
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
                    Price = 9.99,
                    ImgPath = "/bakes/square/no Photo.jpg"
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
                    Price = 19.99,
                    ImgPath = "/bakes/square/lemon cup.jpeg"
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
                    Price = 14.99,
                    ImgPath = "/bakes/square/choc straw cup.jpeg"
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
                    Price = 9.99,
                    ImgPath = "/bakes/square/no Photo.jpg"
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
                    Price = 9.99,
                    ImgPath = "/bakes/square/no Photo.jpg"
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
                    Price = 19.99,
                    ImgPath = "/bakes/square/apple pie.jpeg"
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
                    Price = 19.99,
                    ImgPath = "/bakes/square/no Photo.jpg"
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
                    Price = 24.99,
                    ImgPath = "/bakes/square/pinwheel.jpg"
                },

                new SetOrderModel
                {
                    BakeName = "Broken Glass Cupcakes",
                    BakeType = "Holiday",
                    Flavor = "Chocolate",
                    Size = 12,
                    Frosting = "Vanilla",
                    FillFlavor = null,
                    Description = "Chocolate cupcakes with vanilla buttercream topped with sugar glass and fake edible blood.",
                    Price = 24.99,
                    ImgPath = "/bakes/square/bloody cups.jpeg"
                },

                new SetOrderModel
                {
                    BakeName = "Pumpkin Cake",
                    BakeType = "Holiday",
                    Flavor = "Chocolate",
                    Size = 1,
                    Frosting = "Cream Cheese",
                    FillFlavor = "Orange gelatin strings and white chocolate chips",
                    Description = "Pumpkin flavored and shaped caked with cream cheese frosting with orange geletain and white chocolate chips as pumpkin guts inside.",
                    Price = 49.99,
                    ImgPath = "/bakes/square/pumpkin cake.JPG"
                },

                new SetOrderModel
                {
                    BakeName = "Santa Hat Cupcakes",
                    BakeType = "Holiday",
                    Flavor = "Vanilla",
                    Size = 12,
                    Frosting = "White Chocolate",
                    FillFlavor = "Cranberry",
                    Description = "Vanilla cupcakes with white chocolate buttercream filled with cranberry filling.",
                    Price = 14.99,
                    ImgPath = "/bakes/square/santa cupcakes.jpg"
                },

                new SetOrderModel
                {
                    BakeName = "Peppermint Cupcakes",
                    BakeType = "Holiday",
                    Flavor = "Chocolate",
                    Size = 12,
                    Frosting = "Peppermint",
                    FillFlavor = null,
                    Description = "Chocolate cupcakes with a peppermint buttercream topped with a peppermint.",
                    Price = 9.99,
                    ImgPath = "/bakes/square/peppermint cupcakes.jpg"
                },

                new SetOrderModel
                {
                    BakeName = "Valentine's Day Cheesecake",
                    BakeType = "Holiday",
                    Flavor = "Cheesecake",
                    Size = 1,
                    Frosting = null,
                    FillFlavor = null,
                    Description = "New York style cheesecake topped with chocolate covered strawberries and a chocolate heart mold.",
                    Price = 39.99,
                    ImgPath = "/bakes/square/VDay cheesecake.jpg"
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
                    Price = 14.99,
                    ImgPath = "/bakes/square/cake pops.jpg"
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
                    Price = 9.99,
                    ImgPath = "/bakes/square/rasp bar.jpeg"
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
                    Price = 19.99,
                    ImgPath = "/bakes/square/swiss rolls.jpg"
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
                    Price = 19.99,
                    ImgPath = "/bakes/square/tiger pretzels.jpg"
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
                    Price = 19.99,
                    ImgPath = "/bakes/square/trifold.jpeg"
                }

            );
            context.SaveChanges();
        }

        public static void SeedReciepes(FerrisBakesContext context)
        {

            // Look for any orders.
            if (context.Reciepes.Any())
            {
                return;   // DB has been seeded
            }

            context.Reciepes.AddRange(
                    new ReciepeModel()
                    {                        
                        Title = "Chocolate Chip Cookies",
                        Description = "Chocolate Chip Cookies",
                        Ingredients = "Chocolate",
                        Size = "One Dozen",
                        Price = 9.99,
                        BookId = 1,
                        ChapterId = 0
                    },

                    new ReciepeModel()
                    {
                        Title = "Sugar Cookies",
                        Description = "Sugar Cookies",
                        Ingredients = "Vanilla",
                        Size = "One Dozen",
                        Price = 9.99,
                        BookId = 2,
                        ChapterId = 0
                    },

                    new ReciepeModel()
                    {
                        Title = "Chocolate Crinkle Cookies",
                        Description = "Chocolate Crinkle Cookies",
                        Ingredients = "Chocolate",
                        Size = "One Dozen",
                        Price = 14.99,
                        BookId = 1,
                        ChapterId = 0
                    },

                    new ReciepeModel()
                    {
                        Title = "Red Velvet Crinkle Cookies",
                        Description = "Red Velvet Crinkle Cookies",
                        Ingredients = "RedVelvet",
                        Size = "One Dozen",
                        Price = 14.99,
                        BookId = 4,
                        ChapterId = 0
                    },

                    new ReciepeModel()
                    {
                        Title = "Snicker Doodle Cookies",
                        Description = "Snicker Doodle Cookies",
                        Ingredients = "Spice",
                        Size = "One Dozen",
                        Price = 9.99,
                        BookId = 4,
                        ChapterId = 0
                    },

                    new ReciepeModel()
                    {
                        Title = "Vanilla Cupcakes",
                        Description = "Vanilla Cupcakes with Vanilla Buttercream",
                        Ingredients = "Vanilla",
                        Size = "One Dozen",
                        Price = 9.99,
                        BookId = 2,
                        ChapterId = 0
                    },

                    new ReciepeModel()
                    {
                        Title = "Vanilla Cake",
                        Description = "Vanilla Cake with Vanilla Buttercream",
                        Ingredients = "Vanilla",
                        Size = "One three tiered cake",
                        Price = 14.99,
                        BookId = 2,
                        ChapterId = 0
                    },

                    new ReciepeModel()
                    {
                        Title = "Chocolate Cupcakes",
                        Description = "Chocolate Cupcakes with Chocolate Buttercream",
                        Ingredients = "Chocolate",
                        Size = "One Dozen",
                        Price = 9.99,
                        BookId = 1,
                        ChapterId = 0
                    },

                    new ReciepeModel()
                    {
                        Title = "Chocolate Cake",
                        Description = "Chocolate Cake with Chocolate Buttercream",
                        Ingredients = "Chocolate",
                        Size = "One three tiered cake",
                        Price = 14.99,
                        BookId = 1,
                        ChapterId = 0
                    },

                    new ReciepeModel()
                    {
                        Title = "Vanilla and Chocolate Cupcakes",
                        Description = "Vanilla Cupcakes with Chocolate Buttercream",
                        Ingredients = "Chocolate-Vanilla",
                        Size = "One Dozen",
                        Price = 9.99,
                        BookId = 2,
                        ChapterId = 4
                    },

                    new ReciepeModel()
                    {
                        Title = "Vanilla and Chocolate Cake",
                        Description = "Vanilla Cake with Chocolate Buttercream",
                        Ingredients = "Chocolate-Vanilla",
                        Size = "One three tiered cake",
                        Price = 14.99,
                        BookId = 2,
                        ChapterId = 4
                    },

                    new ReciepeModel()
                    {
                        Title = "Chocolate and Vanilla Cupcakes",
                        Description = "Chocolate Cupcakes with Vanilla Buttercream",
                        Ingredients = "Chocolate-Vanilla",
                        Size = "One Dozen",
                        Price = 9.99,
                        BookId = 1,
                        ChapterId = 1
                    },

                    new ReciepeModel()
                    {
                        Title = "Chocolate and Vanilla Cake",
                        Description = "Chocolate Cake with Vanilla Buttercream",
                        Ingredients = "Chocolate-Vanilla",
                        Size = "One three tiered cake",
                        Price = 14.99,
                        BookId = 1,
                        ChapterId = 1
                    },

                    new ReciepeModel()
                    {
                        Title = "Chocolate and Strawberry Cupcakes",
                        Description = "Chocolate Cupcakes with Chocolate Buttercream and Strawberry filling",
                        Ingredients = "Chocolate-Strawberry",
                        Size = "One Dozen",
                        Price = 14.99,
                        BookId = 1,
                        ChapterId = 2
                    },

                    new ReciepeModel()
                    {
                        Title = "Chocolate and Strawberry Cake",
                        Description = "Chocolate Cake with Chocolate Buttercream and Strawberry filling",
                        Ingredients = "Chocolate-Strawberry",
                        Size = "One three tiered cake",
                        Price = 19.99,
                        BookId = 1,
                        ChapterId = 2
                    },

                    new ReciepeModel()
                    {
                        Title = "Chocolate and Raspberry Cupcakes",
                        Description = "Chocolate Cupcakes with Chocolate Buttercream and Raspberry filling",
                        Ingredients = "Chocolate-Raspberry",
                        Size = "One Dozen",
                        Price = 14.99,
                        BookId = 1,
                        ChapterId = 2
                    },

                    new ReciepeModel()
                    {
                        Title = "Chocolate and Raspberry Cake",
                        Description = "Chocolate Cake with Chocolate Buttercream and Raspberry filling",
                        Ingredients = "Chocolate-Raspberry",
                        Size = "One three tiered cake",
                        Price = 19.99,
                        BookId = 1,
                        ChapterId = 2
                    },

                    new ReciepeModel()
                    {
                        Title = "Chocolate, Vanilla, and Strawbery Cupcakes",
                        Description = "Chocolate Cupcakes with Vanilla Buttercream and Strawberry filling",
                        Ingredients = "Chocolate-Vanilla-Strawberry",
                        Size = "One Dozen",
                        Price = 14.99,
                        BookId = 1,
                        ChapterId = 1
                    },

                    new ReciepeModel()
                    {
                        Title = "Chocolate, Vanilla, and Strawberry Cake",
                        Description = "Chocolate Cake with Vanilla Buttercream and Strawberry filling",
                        Ingredients = "Chocolate-Vanilla-Strawberry",
                        Size = "One three tiered cake",
                        Price = 19.99,
                        BookId = 1,
                        ChapterId = 1
                    },

                    new ReciepeModel()
                    {
                        Title = "Chocolate, Vanilla, and Raspberry Cupcakes",
                        Description = "Chocolate Cupcakes with Vanilla Buttercream and Raspberry filling",
                        Ingredients = "Chocolate-Vanilla-Raspberry",
                        Size = "One Dozen",
                        Price = 14.99,
                        BookId = 1,
                        ChapterId = 1
                    },

                    new ReciepeModel()
                    {
                        Title = "Chocolate, Vanilla, and Raspberry Cake",
                        Description = "Chocolate Cake with Vanilla Buttercream and Raspberry filling",
                        Ingredients = "Vanilla-Raspberry",
                        Size = "One three tiered cake",
                        Price = 19.99,
                        BookId = 1,
                        ChapterId = 1
                    },

                    new ReciepeModel()
                    {
                        Title = "Vanilla and Strawberry Cupcakes",
                        Description = "Vanilla Cupcakes with Vanilla Buttercream and Strawberry filling",
                        Ingredients = "Vanilla-Strawberry",
                        Size = "One Dozen",
                        Price = 14.99,
                        BookId = 2,
                        ChapterId = 5
                    },

                    new ReciepeModel()
                    {
                        Title = "Vanilla and Strawberry Cake",
                        Description = "Vanilla Cake with Vanilla Buttercream and Strawberry filling",
                        Ingredients = "Vanilla-Strawberry",
                        Size = "One three tiered cake",
                        Price = 19.99,
                        BookId = 2,
                        ChapterId = 5
                    },

                    new ReciepeModel()
                    {
                        Title = "Vanilla and Raspberry Cupcakes",
                        Description = "Vanilla Cupcakes with Vanilla Buttercream and Raspberry filling",
                        Ingredients = "Vanilla-Raspberry",
                        Size = "One Dozen",
                        Price = 14.99,
                        BookId = 2,
                        ChapterId = 5
                    },

                    new ReciepeModel()
                    {
                        Title = "Vanilla and Raspberry Cake",
                        Description = "Vanilla Cake with Vanilla Buttercream and Raspberry filling",
                        Ingredients = "Vanilla-Raspberry",
                        Size = "One three tiered cake",
                        Price = 19.99,
                        BookId = 2,
                        ChapterId = 5
                    },

                    new ReciepeModel()
                    {
                        Title = "Vanilla and Peach Cupcakes",
                        Description = "Vanilla Cupcakes with Vanilla Buttercream and Peach filling",
                        Ingredients = "Vanilla-Peach",
                        Size = "One Dozen",
                        Price = 14.99,
                        BookId = 2,
                        ChapterId = 5
                    },

                    new ReciepeModel()
                    {
                        Title = "Vanilla and Peach Cake",
                        Description = "Vanilla Cake with Vanilla Buttercream and Peach filling",
                        Ingredients = "Vanilla-Peach",
                        Size = "One three tiered cake",
                        Price = 19.99,
                        BookId = 2,
                        ChapterId = 5
                    },

                    new ReciepeModel()
                    {
                        Title = "Vanilla and Mango Cupcakes",
                        Description = "Vanilla Cupcakes with Vanilla Buttercream and Mango filling",
                        Ingredients = "Vanilla-Mango",
                        Size = "One Dozen",
                        Price = 14.99,
                        BookId = 2,
                        ChapterId = 5
                    },

                    new ReciepeModel()
                    {
                        Title = "Vanilla and Mango Cake",
                        Description = "Vanilla Cake with Vanilla Buttercream and Mango filling",
                        Ingredients = "Vanilla-Mango",
                        Size = "One three tiered cake",
                        Price = 19.99,
                        BookId = 2,
                        ChapterId = 5
                    },

                    new ReciepeModel()
                    {
                        Title = "Vanilla and Blueberry Cupcakes",
                        Description = "Vanilla Cupcakes with Vanilla Buttercream and Blueberry filling",
                        Ingredients = "Vanilla-Blueberry",
                        Size = "One Dozen",
                        Price = 14.99,
                        BookId = 2,
                        ChapterId = 5
                    },

                    new ReciepeModel()
                    {
                        Title = "Vanilla and Blueberry Cake",
                        Description = "Vanilla Cake with Vanilla Buttercream and Blueberry filling",
                        Ingredients = "Vanilla-Blueberry",
                        Size = "One three tiered cake",
                        Price = 19.99,
                        BookId = 2,
                        ChapterId = 5
                    },

                    new ReciepeModel()
                    {
                        Title = "Lemon and Lavendar Cupcakes",
                        Description = "Lemon Cupcakes with Lavendar Buttercream",
                        Ingredients = "Lemon",
                        Size = "One Dozen",
                        Price = 14.99,
                        BookId = 3,
                        ChapterId = 6
                    },

                    new ReciepeModel()
                    {
                        Title = "Lemon and Lavendar Cake",
                        Description = "Lemon Cake with Lavendar Buttercream",
                        Ingredients = "Lemon",
                        Size = "One three tiered cake",
                        Price = 19.99,
                        BookId = 3,
                        ChapterId = 6
                    },

                    new ReciepeModel()
                    {
                        Title = "Lemon and Blueberry Cupcakes",
                        Description = "Lemon Cupcakes with Vanilla Buttercream and Blueberry Filling",
                        Ingredients = "Lemon-Vanilla-Blueberry",
                        Size = "One Dozen",
                        Price = 19.99,
                        BookId = 3,
                        ChapterId = 6
                    },

                    new ReciepeModel()
                    {
                        Title = "Lemon and Blueberry Cake",
                        Description = "Lemon Cake with Vanilla Buttercream and Blueberry Filling",
                        Ingredients = "Lemon-Vanilla-Blueberry",
                        Size = "One three tiered cake",
                        Price = 24.99,
                        BookId = 3,
                        ChapterId = 6
                    },

                    new ReciepeModel()
                    {
                        Title = "Lemon and Raspberry Cupcakes",
                        Description = "Lemon Cupcakes with Vanilla Buttercream and Raspberry Filling",
                        Ingredients = "Lemon-Vanilla-Raspberry",
                        Size = "One Dozen",
                        Price = 19.99,
                        BookId = 3,
                        ChapterId = 6
                    },

                    new ReciepeModel()
                    {
                        Title = "Lemon and Raspberry Cake",
                        Description = "Lemon Cake with Vanilla Buttercream and Raspberry Filling",
                        Ingredients = "Lemon-Vanilla-Raspberry",
                        Size = "One three tiered cake",
                        Price = 24.99,
                        BookId = 3,
                        ChapterId = 6
                    },

                    new ReciepeModel()
                    {
                        Title = "Red Velvet Cupcakes",
                        Description = "Red Velvet Cupcakes with Cream Cheese Frosting",
                        Ingredients = "RedVelvet-Chocolate",
                        Size = "One Dozen",
                        Price = 9.99,
                        BookId = 4,
                        ChapterId = 0
                    },

                    new ReciepeModel()
                    {
                        Title = "Red Velvet Cake",
                        Description = "Red Velvet Cake with Cream Cheese Frosting",
                        Ingredients = "RedVelvet-Chocolate",
                        Size = "One three tiered cake",
                        Price = 14.99,
                        BookId = 4,
                        ChapterId = 0
                    },

                    new ReciepeModel()
                    {
                        Title = "Pumpkin Cupcakes",
                        Description = "Pumpkin Cupcakes with Cream Cheese Frosting",
                        Ingredients = "Spice",
                        Size = "One Dozen",
                        Price = 9.99,
                        BookId = 4,
                        ChapterId = 0
                    },

                    new ReciepeModel()
                    {
                        Title = "Pumpkin Cake",
                        Description = "Pumpkin Cake with Cream Cheese Frosting",
                        Ingredients = "Spice",
                        Size = "One three tiered cake",
                        Price = 14.99,
                        BookId = 4,
                        ChapterId = 0
                    },

                    new ReciepeModel()
                    {
                        Title = "Chocolate and Bailey Cupcakes",
                        Description = "Chocolate Cupcakes with Bailey's Buttercream",
                        Ingredients = "Chocolate",
                        Size = "One Dozen",
                        Price = 14.99,
                        BookId = 1,
                        ChapterId = 3
                    },

                    new ReciepeModel()
                    {
                        Title = "Chocolate and Bailey's Cake",
                        Description = "Chocolate Cake with Bailey's Buttercream with Bailey's ganache filling",
                        Ingredients = "Chocolate",
                        Size = "One three tiered cake",
                        Price = 19.99,
                        BookId = 1,
                        ChapterId = 3
                    },

                    new ReciepeModel()
                    {
                        Title = "Chocolate and Peppermint Cupcakes",
                        Description = "Chocolate Cupcakes with Peppermint Buttercream",
                        Ingredients = "Chocolate",
                        Size = "One Dozen",
                        Price = 14.99,
                        BookId = 1,
                        ChapterId = 3
                    },

                    new ReciepeModel()
                    {
                        Title = "Chocolate and Peppermint Cake",
                        Description = "Chocolate Cake with Peppermint Buttercream",
                        Ingredients = "Chocolate",
                        Size = "One three tiered cake",
                        Price = 19.99,
                        BookId = 1,
                        ChapterId = 3
                    },

                    new ReciepeModel()
                    {
                        Title = "Vanilla Cranberry Cupcakes",
                        Description = "Vanilla Cupcakes with White Chocolate Buttercream with Cranberry filling",
                        Ingredients = "Vanilla-Chocolate",
                        Size = "One Dozen",
                        Price = 14.99,
                        BookId = 2,
                        ChapterId = 5
                    },

                    new ReciepeModel()
                    {
                        Title = "Vanilla Cranberry Cake",
                        Description = "Vanilla Cake with White Chocolate Buttercream with Cranberry filling",
                        Ingredients = "Vanilla-Chocolate",
                        Size = "One three tiered cake",
                        Price = 19.99,
                        BookId = 2,
                        ChapterId = 5
                    },

                    new ReciepeModel()
                    {
                        Title = "Strawberry and Cream Cheese Pastry Pinwheels",
                        Description = "Pastry Pinwheels filled with Cream Cheese and Strawberry",
                        Ingredients = "Strawberry",
                        Size = "One Dozen",
                        Price = 14.99,
                        BookId = 3,
                        ChapterId = 7
                    },

                    new ReciepeModel()
                    {
                        Title = "Raspberry and Cream Cheese Pastry Pinwheels",
                        Description = "Pastry Pinwheels filled with Cream Cheese and Raspberry",
                        Ingredients = "Raspberry",
                        Size = "One Dozen",
                        Price = 14.99,
                        BookId = 3,
                        ChapterId = 8
                    },

                    new ReciepeModel()
                    {
                        Title = "Peach and Cream Cheese Pastry Pinwheels",
                        Description = "Pastry Pinwheels filled with Cream Cheese and Peach",
                        Ingredients = "Peach",
                        Size = "One Dozen",
                        Price = 14.99,
                        BookId = 3,
                        ChapterId = 9
                    },

                    new ReciepeModel()
                    {
                        Title = "Mango and Cream Cheese Pastry Pinwheels",
                        Description = "Pastry Pinwheels filled with Cream Cheese and Mango",
                        Ingredients = "Mango",
                        Size = "One Dozen",
                        Price = 14.99,
                        BookId = 3,
                        ChapterId = 10
                    },

                    new ReciepeModel()
                    {
                        Title = "Blueberry and Cream Cheese Pastry Pinwheels",
                        Description = "Pastry Pinwheels filled with Cream Cheese and Blueberry",
                        Ingredients = "Blueberry",
                        Size = "One Dozen",
                        Price = 14.99,
                        BookId = 3,
                        ChapterId = 11
                    },

                    new ReciepeModel()
                    {
                        Title = "Blackberry and Cream Cheese Pastry Pinwheels",
                        Description = "Pastry Pinwheels filled with Cream Cheese and Blackberry",
                        Ingredients = "Blackberry",
                        Size = "One Dozen",
                        Price = 14.99,
                        BookId = 3,
                        ChapterId = 12
                    },

                    new ReciepeModel()
                    {
                        Title = "Raspberry Oat Bars",
                        Description = "Oat Bars with a Raspberry filling",
                        Ingredients = "Raspberry",
                        Size = "One Dozen",
                        Price = 14.99,
                        BookId = 3,
                        ChapterId = 8
                    },

                    new ReciepeModel()
                    {
                        Title = "Strawberry Oat Bars",
                        Description = "Oat Bars with a Strawberry filling",
                        Ingredients = "Strawberry",
                        Size = "One Dozen",
                        Price = 14.99,
                        BookId = 3,
                        ChapterId = 7
                    },

                    new ReciepeModel()
                    {
                        Title = "Peach Oat Bars",
                        Description = "Oat Bars with a Peach filling",
                        Ingredients = "Peach",
                        Size = "One Dozen",
                        Price = 14.99,
                        BookId = 3,
                        ChapterId = 9
                    },

                    new ReciepeModel()
                    {
                        Title = "Mango Oat Bars",
                        Description = "Oat Bars with a Mango filling",
                        Ingredients = "Mango",
                        Size = "One Dozen",
                        Price = 14.99,
                        BookId = 3,
                        ChapterId = 10
                    },

                    new ReciepeModel()
                    {
                        Title = "Blueberry Oat Bars",
                        Description = "Oat Bars with a Blueberry filling",
                        Ingredients = "Peach",
                        Size = "One Dozen",
                        Price = 14.99,
                        BookId = 3,
                        ChapterId = 11
                    },

                    new ReciepeModel()
                    {
                        Title = "Blackberry Oat Bars",
                        Description = "Oat Bars with a Blackberry filling",
                        Ingredients = "Blackberry",
                        Size = "One Dozen",
                        Price = 14.99,
                        BookId = 3,
                        ChapterId = 12
                    },

                    new ReciepeModel()
                    {
                        Title = "Apple Pie",
                        Description = "Apple Pie",
                        Ingredients = "",
                        Size = "One Pie",
                        Price = 14.99,
                        BookId = 3,
                        ChapterId = 0
                    },

                    new ReciepeModel()
                    {
                        Title = "Chocolate Pie",
                        Description = "Chocolate Pie",
                        Ingredients = "Chocolate",
                        Size = "One Pie",
                        Price = 14.99,
                        BookId = 1,
                        ChapterId = 0
                    },

                    new ReciepeModel()
                    {
                        Title = "Pecan Pie",
                        Description = "Pecan Pie",
                        Ingredients = "Pecan",
                        Size = "One Pie",
                        Price = 14.99,
                        BookId = 4,
                        ChapterId = 0
                    },

                    new ReciepeModel()
                    {
                        Title = "Peach Cobbler",
                        Description = "Peach Cobbler",
                        Ingredients = "Peach",
                        Size = "One tray",
                        Price = 14.99,
                        BookId = 3,
                        ChapterId = 9
                    },

                    new ReciepeModel()
                    {
                        Title = "Blueberry Cobbler",
                        Description = "Blueberry Cobbler",
                        Ingredients = "Blueberry",
                        Size = "One tray",
                        Price = 14.99,
                        BookId = 3,
                        ChapterId = 11
                    },

                    new ReciepeModel()
                    {
                        Title = "Blackberry Cobbler",
                        Description = "Blackberry Cobbler",
                        Ingredients = "Blackberry",
                        Size = "One tray",
                        Price = 14.99,
                        BookId = 3,
                        ChapterId = 12
                    },

                    new ReciepeModel()
                    {
                        Title = "Strawberry Cobbler",
                        Description = "Strawberry Cobbler",
                        Ingredients = "Strawberry",
                        Size = "One tray",
                        Price = 14.99,
                        BookId = 3,
                        ChapterId = 7
                    },

                    new ReciepeModel()
                    {
                        Title = "Peach and Pecan Cobbler",
                        Description = "Peach and Pecan Cobbler",
                        Ingredients = "Peach-Pecan",
                        Size = "One tray",
                        Price = 14.99,
                        BookId = 3,
                        ChapterId = 9
                    },

                    new ReciepeModel()
                    {
                        Title = "Vegan Brownies",
                        Description = "Vegan Brownies made with vegan butter, vegan chocolate chips, and flax seed",
                        Ingredients = "Chocolate",
                        Size = "One tray",
                        Price = 14.99,
                        BookId = 5,
                        ChapterId = 0
                    },

                    new ReciepeModel()
                    {
                        Title = "Vegan Chocolate Cake",
                        Description = "Vegan Chocolate Cake made with vegan butter, vegan chocolate chips, and apple sauce",
                        Ingredients = "Chocolate",
                        Size = "One three tiered cake",
                        Price = 14.99,
                        BookId = 5,
                        ChapterId = 0
                    },
                    new ReciepeModel()
                    {
                        Title = "Vanilla, Chocolate, and Strawbery Cupcakes",
                        Description = "Vanilla Cupcakes with Chocolate Buttercream and Strawberry filling",
                        Ingredients = "Vanilla-Chocolate-Strawberry",
                        Size = "One Dozen",
                        Price = 14.99,
                        BookId = 2,
                        ChapterId = 4
                    },

                    new ReciepeModel()
                    {
                        Title = "Vanilla, Chocolate, and Strawberry Cake",
                        Description = "Vanilla Cake with Chocolate Buttercream and Strawberry filling",
                        Ingredients = "Vanilla-Chocolate-Strawberry",
                        Size = "One three tiered cake",
                        Price = 19.99,
                        BookId = 2,
                        ChapterId = 4
                    },

                    new ReciepeModel()
                    {
                        Title = "Vanilla, Chocolate, and Raspberry Cupcakes",
                        Description = "Vanilla Cupcakes with Chocolate Buttercream and Raspberry filling",
                        Ingredients = "Vanilla-Chocolate-Raspberry",
                        Size = "One Dozen",
                        Price = 14.99,
                        BookId = 2,
                        ChapterId = 4
                    },

                    new ReciepeModel()
                    {
                        Title = "Vanilla, Chocolate, and Raspberry Cake",
                        Description = "Vanilla Cake with Chocolate Buttercream and Raspberry filling",
                        Ingredients = "Vanilla-Chocolate-Raspberry",
                        Size = "One three tiered cake",
                        Price = 19.99,
                        BookId = 2,
                        ChapterId = 4
                    }
                );

            context.SaveChanges();
        }

        public static void SeedReciepeBooks(FerrisBakesContext context)
        {

            // Look for any orders.
            if (context.ReciepeBook.Any())
            {
                return;   // DB has been seeded
            }

            context.ReciepeBook.AddRange(

                new ReciepeBook()
                {
                    BookId = 1,
                    Title = "Chocolate"
                },

                new ReciepeBook()
                {
                    BookId = 2,
                    Title = "Vanilla"

                },

                new ReciepeBook()
                {
                    BookId = 3,
                    Title = "Fruit"

                },

                new ReciepeBook()
                {
                    BookId = 4,
                    Title = "Misc"
                },

                new ReciepeBook()
                {
                    BookId = 5,
                    Title = "Vegan"

                }
            ) ;
            context.SaveChanges();
            
        }

        public static void SeedChapters(FerrisBakesContext context)
        {

            // Look for any orders.
            if (context.Chapters.Any())
            {
                return;   // DB has been seeded
            }

            context.Chapters.AddRange(


            new Chapter()
            {
                Title = "Chocolate-Vanilla",
                BookID = 1,
                ChapterId = 1
            },

            new Chapter()
            {
                Title = "Chocolate-Fruit",
                BookID = 1,
                ChapterId = 2
            },

            new Chapter()
            {
                Title = "Chocolate-Misc",
                BookID = 1,
                ChapterId = 3
            },


            new Chapter()
            {
                Title = "Vanilla-Chocolate",
                BookID = 2,
                ChapterId = 4
            },

            new Chapter()
            {
                Title = "Vanilla-Fruit",
                BookID = 2,
                ChapterId = 5
            },

            new Chapter()
            {
                Title = "Fruit-Lemon",
                BookID = 3,
                ChapterId = 6
            },
            new Chapter()
            {
                Title = "Fruit-Strawberry",
                BookID = 3,
                ChapterId = 7
            },
            new Chapter()
            {
                Title = "Fruit-Raspberry",
                BookID = 3,
                ChapterId = 8
            },
            new Chapter()
            {
                Title = "Fruit-Peach",
                BookID = 3,
                ChapterId = 9
            },
            new Chapter()
            {
                Title = "Fruit-Mango",
                BookID = 3,
                ChapterId = 10
            },
            new Chapter()
            {
                Title = "Fruit-Blueberry",
                BookID = 3,
                ChapterId = 11
            },
            new Chapter()
            {
                Title = "Fruit-Blackberry",
                BookID = 3,
                ChapterId = 12
            }


            ) ;
            context.SaveChanges();

        }

        public static void SeedIngredients(FerrisBakesContext context)
        {
            // Look for any orders.
            if (context.Ingredients.Any())
            {
                return;   // DB has been seeded
            }

            List<Ingredients> Resutls = new List<Ingredients>();

            foreach (ReciepeModel r in context.Reciepes)
            {
                Ingredients temp = new Ingredients(r.ReciepeNumber, r.Ingredients);
                Resutls.Add(temp);
            }

            context.AddRange(Resutls);
            context.SaveChanges();
        }

        public static void clearCart(FerrisBakesContext context)
        {
            if (context.Cart.Any())
            {
                foreach (CartItemModel c in context.Cart)
                {
                    if (c != null)
                    {
                        context.Cart.Remove(c);
                    }
                }

                context.SaveChanges();
            }
        }

    }
}
