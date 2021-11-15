using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ferris_Bakes.Models;
using Ferris_Bakes.Data;
using Ferris_Bakes.Entities;
using Microsoft.AspNetCore.Http;

namespace Ferris_Bakes.Logic
{
    public class HelpingBaker
    {
        public List<ReciepeModel> GetLikeableRecieps (Preference Preference)
        {
            List<ReciepeModel> Reciepes = new List<ReciepeModel>();

            using (var context = new FerrisBakesContext())
            {
                List<ReciepeModel> data = context.Reciepes.ToList();
                bool Fruit = !(Preference.Dislikes.Blackberry && Preference.Dislikes.Blueberry && Preference.Dislikes.Strawberry && Preference.Dislikes.Raspberry && Preference.Dislikes.Mango && Preference.Dislikes.Peach && Preference.Dislikes.Lemon);
                //Fruit will only be negative if they don't like any fruit 

                if (Preference.Vegan)
                {
                    ReciepeBook Vegan = context.ReciepeBook.Find(18);
                    Reciepes.AddRange(BookReader(Preference.Dislikes, Vegan));
                }

                else
                {
                    ReciepeBook Chocolate = context.ReciepeBook.Find(14);
                    ReciepeBook Vanilla = context.ReciepeBook.Find(15);
                    ReciepeBook FruitBook = context.ReciepeBook.Find(16);
                    ReciepeBook Misc = context.ReciepeBook.Find(17);


                    if (!Preference.Dislikes.Chocolate)
                    {
                        if (!Preference.Dislikes.Vanilla)
                        {
                            Reciepes.AddRange(BookReader(Preference.Dislikes, Chocolate.Chapters.ElementAt(0)));
                        }

                        if (!Fruit)
                        {
                            Reciepes.AddRange(BookReader(Preference.Dislikes, Chocolate.Chapters.ElementAt(1)));
                        }

                        Reciepes.AddRange(BookReader(Preference.Dislikes, Chocolate.Chapters.ElementAt(2)));
                        Reciepes.AddRange(BookReader(Preference.Dislikes, Chocolate));

                    }

                    if (!Preference.Dislikes.Vanilla)
                    {
                        if (!Preference.Dislikes.Chocolate)
                        {
                            Reciepes.AddRange(BookReader(Preference.Dislikes, Vanilla.Chapters.ElementAt(0)));
                        }

                        if (!Fruit)
                        {
                            Reciepes.AddRange(BookReader(Preference.Dislikes, Vanilla.Chapters.ElementAt(1)));
                        }

                        Reciepes.AddRange(BookReader(Preference.Dislikes, Vanilla));
                    }

                    if (Fruit)
                    {
                        if (!Preference.Dislikes.Lemon)
                        {
                            Reciepes.AddRange(BookReader(Preference.Dislikes, FruitBook.Chapters.ElementAt(0)));
                        }

                        if (!Preference.Dislikes.Strawberry)
                        {
                            Reciepes.AddRange(BookReader(Preference.Dislikes, FruitBook.Chapters.ElementAt(0)));
                        }

                        if (!Preference.Dislikes.Raspberry)
                        {
                            Reciepes.AddRange(BookReader(Preference.Dislikes, FruitBook.Chapters.ElementAt(0)));
                        }

                        if (!Preference.Dislikes.Peach)
                        {
                            Reciepes.AddRange(BookReader(Preference.Dislikes, FruitBook.Chapters.ElementAt(0)));
                        }

                        if (!Preference.Dislikes.Mango)
                        {
                            Reciepes.AddRange(BookReader(Preference.Dislikes, FruitBook.Chapters.ElementAt(0)));
                        }

                        if (!Preference.Dislikes.Blueberry)
                        {
                            Reciepes.AddRange(BookReader(Preference.Dislikes, FruitBook.Chapters.ElementAt(0)));
                        }

                        if (!Preference.Dislikes.Blackberry)
                        {
                            Reciepes.AddRange(BookReader(Preference.Dislikes, FruitBook.Chapters.ElementAt(0)));
                        }

                        Reciepes.AddRange(BookReader(Preference.Dislikes, FruitBook));
                    }

                    Reciepes.AddRange(BookReader(Preference.Dislikes, Misc));
                }
            }


            return Reciepes;
        }

        public List<ReciepeModel> BookReader (Ingredients Dislikes, ReciepeBook Book)
        {
            List<ReciepeModel> Reciepes = new List<ReciepeModel>();

            foreach (ReciepeModel Page in Book.Reciepes)
            {
                if (!Page.Ingredients.CompareDislikes(Dislikes))
                    Reciepes.Add(Page);
            }

            return Reciepes;
        }
    }
}