using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Ferris_Bakes.Entities
{
    public class Ingredients
    {
        [Key]
        public int ReciepeID { get; set; }
        public bool Chocolate { get; set; }
        public bool Vanilla { get; set; }
        public bool Strawberry { get; set; }
        public bool Raspberry { get; set; }
        public bool Peach { get; set; }
        public bool Mango { get; set; }
        public bool Blackberry { get; set; }
        public bool Blueberry { get; set; }
        public bool RedVelvet { get; set; }
        public bool Lemon { get; set; }
        public bool Spice { get; set; }
        public bool Pecan { get; set; }

        public Ingredients (int ReciepeNum)
        {
            ReciepeID = ReciepeNum;
            Chocolate = false;
            Vanilla = false;
            Strawberry = false;
            Raspberry = false;
            Peach = false;
            Mango = false;
            Blackberry = false;
            Blueberry = false;
            RedVelvet = false;
            Lemon = false;
            Spice = false;
            Pecan = false;
        }
        public Ingredients()
        {
            ;
            Chocolate = false;
            Vanilla = false;
            Strawberry = false;
            Raspberry = false;
            Peach = false;
            Mango = false;
            Blackberry = false;
            Blueberry = false;
            RedVelvet = false;
            Lemon = false;
            Spice = false;
            Pecan = false;
        }

        public Ingredients Update(Ingredients Value, String Flavor)
        {
            string[] Flavors = Flavor.Split('-');

            foreach (string s in Flavors)
            {
                switch (s)
                {
                    case "Chocolate":
                        {
                            Value.Chocolate = true;
                            break;
                        }
                    case "Vanilla":
                        {
                            Value.Vanilla = true;
                            break;
                        }

                    case "Strawberry":
                        {
                            Value.Strawberry = true;
                            break;
                        }

                    case "Raspberry":
                        {
                            Value.Raspberry = true;
                            break;
                        }
                    case "Peach":
                        {
                            Value.Peach = true;
                            break;
                        }
                    case "Mango":
                        {
                            Value.Mango = true;
                            break;
                        }
                    case "Blackberry":
                        {
                            Value.Blackberry = true;
                            break;
                        }
                    case "Blueberry":
                        {
                            Value.Blueberry = true;
                            break;
                        }
                    case "RedVelvet":
                        {
                            Value.RedVelvet = true;
                            break;
                        }
                    case "Lemon":
                        {
                            Value.Lemon = true;
                            break;
                        }
                    case "Spice":
                        {
                            Value.Spice = true;
                            break;
                        }
                    case "Pecan":
                        {
                            Value.Spice = true;
                            break;
                        }
                    case "":
                        {
                            break;
                        }
                    default:
                        {
                            Debug.Print("Error");
                            break;
                        }
                }
            }

            
            return Value;
        }

        public Ingredients (int ReciepeNum, String Flavor)
        {
            ReciepeID = ReciepeNum;
            Chocolate = false;
            Vanilla = false;
            Strawberry = false;
            Raspberry = false;
            Peach = false;
            Mango = false;
            Blackberry = false;
            Blueberry = false;
            RedVelvet = false;
            Lemon = false;
            Spice = false;
            Pecan = false;

            Update(this, Flavor);
        }

        public bool CompareDislikes(Ingredients Dislikes)
        {
            if (this.Chocolate && Dislikes.Chocolate)
                return true;
            if (this.Vanilla && Dislikes.Vanilla)
                return true;
            if (this.Strawberry && Dislikes.Strawberry)
                return true;
            if (this.Raspberry && Dislikes.Raspberry)
                return true;
            if (this.Peach && Dislikes.Peach)
                return true;
            if (this.Mango && Dislikes.Mango)
                return true;
            if (this.Blackberry && Dislikes.Blackberry)
                return true;
            if (this.Blueberry && Dislikes.Blueberry)
                return true;
            if (this.RedVelvet && Dislikes.RedVelvet)
                return true;
            if (this.Lemon && Dislikes.Lemon)
                return true;
            if (this.Spice && Dislikes.Spice)
                return true;
            if (this.Pecan && Dislikes.Pecan)
                return true;
            return false;
        }


    }
}
