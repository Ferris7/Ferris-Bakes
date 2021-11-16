using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ferris_Bakes.Models;
using Ferris_Bakes.Data;
using Ferris_Bakes.Entities;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;

namespace Ferris_Bakes.Logic
{
    public class HelpingBaker
    {
        public List<ReciepeModel> GetLikeableRecieps (Preference Preference)
        {
            List<ReciepeModel> Reciepes = new List<ReciepeModel>();

            using (var context = new FerrisBakesContext())
            {
                List<ReciepeModel> ReciepeData = context.Reciepes.ToList();
                List<Ingredients> IngredientData = context.Ingredients.ToList();
                bool Fruit = !(Preference.Dislikes.Blackberry && Preference.Dislikes.Blueberry && Preference.Dislikes.Strawberry && Preference.Dislikes.Raspberry && Preference.Dislikes.Mango && Preference.Dislikes.Peach && Preference.Dislikes.Lemon);
                //Fruit will only be negative if they don't like any fruit 

                ReciepeBook Chocolate = new ReciepeBook();
                ReciepeBook Vanilla = new ReciepeBook();
                ReciepeBook FruitBook = new ReciepeBook();
                ReciepeBook Misc = new ReciepeBook();
                ReciepeBook Vegan = new ReciepeBook();

                foreach (ReciepeBook r in context.ReciepeBook)
                {
                    switch (r.BookId)
                    {
                        case 1:
                            {
                                Chocolate = r;
                                break;
                            }
                        case 2:
                            {
                                Vanilla = r;
                                break;
                            }
                        case 3:
                            {
                                FruitBook = r;
                                break;
                            }
                        case 4:
                            {
                                Misc = r;
                                break;
                            }
                        case 5:
                            {
                                Vegan = r;
                                break;
                            }
                        default:
                            {
                                Debug.Print("Error");
                                break;
                            }

                    }
                }


                if (Preference.Vegan)
                {
                    
                    Reciepes.AddRange(BookReader(Preference.Dislikes, Vegan, ReciepeData, IngredientData));
                }

                else
                {
                    


                    if (!Preference.Dislikes.Chocolate)
                    {
                        if (!Preference.Dislikes.Vanilla)
                        {
                            Reciepes.AddRange(BookReader(Preference.Dislikes, context.Chapters.Find(1), ReciepeData, IngredientData));
                        }

                        if (Fruit)
                        {
                            Reciepes.AddRange(BookReader(Preference.Dislikes, context.Chapters.Find(2), ReciepeData, IngredientData));
                        }

                        Reciepes.AddRange(BookReader(Preference.Dislikes, context.Chapters.Find(3), ReciepeData, IngredientData));
                        Reciepes.AddRange(BookReader(Preference.Dislikes, Chocolate, ReciepeData, IngredientData));

                    }

                    if (!Preference.Dislikes.Vanilla)
                    {
                        if (!Preference.Dislikes.Chocolate)
                        {
                            Reciepes.AddRange(BookReader(Preference.Dislikes, context.Chapters.Find(4), ReciepeData, IngredientData));
                        }

                        if (!Fruit)
                        {
                            Reciepes.AddRange(BookReader(Preference.Dislikes, context.Chapters.Find(5), ReciepeData, IngredientData));
                        }

                        Reciepes.AddRange(BookReader(Preference.Dislikes, Vanilla, ReciepeData, IngredientData));
                    }

                    if (Fruit)
                    {
                        if (!Preference.Dislikes.Lemon)
                        {
                            Reciepes.AddRange(BookReader(Preference.Dislikes, context.Chapters.Find(6), ReciepeData, IngredientData));
                        }

                        if (!Preference.Dislikes.Strawberry)
                        {
                            Reciepes.AddRange(BookReader(Preference.Dislikes, context.Chapters.Find(7), ReciepeData, IngredientData));
                        }

                        if (!Preference.Dislikes.Raspberry)
                        {
                            Reciepes.AddRange(BookReader(Preference.Dislikes, context.Chapters.Find(8), ReciepeData, IngredientData));
                        }

                        if (!Preference.Dislikes.Peach)
                        {
                            Reciepes.AddRange(BookReader(Preference.Dislikes, context.Chapters.Find(9), ReciepeData, IngredientData));
                        }

                        if (!Preference.Dislikes.Mango)
                        {
                            Reciepes.AddRange(BookReader(Preference.Dislikes, context.Chapters.Find(10), ReciepeData, IngredientData));
                        }

                        if (!Preference.Dislikes.Blueberry)
                        {
                            Reciepes.AddRange(BookReader(Preference.Dislikes, context.Chapters.Find(11), ReciepeData, IngredientData));
                        }

                        if (!Preference.Dislikes.Blackberry)
                        {
                            Reciepes.AddRange(BookReader(Preference.Dislikes, context.Chapters.Find(12), ReciepeData, IngredientData));
                        }

                        Reciepes.AddRange(BookReader(Preference.Dislikes, FruitBook, ReciepeData, IngredientData));
                    }

                    Reciepes.AddRange(BookReader(Preference.Dislikes, Misc, ReciepeData, IngredientData));
                }
            }


            return Reciepes;
        }

        public List<ReciepeModel> BookReader (Ingredients Dislikes, ReciepeBook Book, List<ReciepeModel> RecipeList, List<Ingredients> IngredientsList)
        {
            List<ReciepeModel> Reciepes = new List<ReciepeModel>();

            foreach (ReciepeModel r in RecipeList)
            {
                if (r.BookId == Book.BookId)
                {
                    Ingredients temp = new Ingredients();
                    temp = IngredientsList.Find(x => x.ReciepeID == r.ReciepeNumber);
                    if (!temp.CompareDislikes(Dislikes))
                        Reciepes.Add(r);
                }
                
            }

            return Reciepes;
        }

        public List<ReciepeModel> BookReader(Ingredients Dislikes, Chapter Chapter, List<ReciepeModel> RecipeList, List<Ingredients> IngredientsList)
        {
            List<ReciepeModel> Reciepes = new List<ReciepeModel>();

            foreach (ReciepeModel r in RecipeList)
            {
                if (r.BookId == Chapter.BookID && r.ChapterId == Chapter.ChapterId)
                {
                    Ingredients temp = new Ingredients();
                    temp = IngredientsList.Find(x => x.ReciepeID == r.ReciepeNumber);
                    if (!temp.CompareDislikes(Dislikes))
                        Reciepes.Add(r);
                }

            }

            return Reciepes;
        }
    }
}