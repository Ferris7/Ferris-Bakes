﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ferris_Bakes.Models
{
    public class CheckoutOrderModel
    {
        [Key]
        public int OrderNumber { get; set; }
        public string OrderConfirmation { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public DateTime DatePlaced { get; set; }
        public DateTime DueDate { get; set; }
    } 
}
