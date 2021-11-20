using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ferris_Bakes.Models
{
    public class SetOrderListModel
    {
        public List<SetOrderModel> Cakes { get; set; }
        public List<SetOrderModel> Cookies { get; set; }
        public List<SetOrderModel> Cupcakes { get; set; }
        public List<SetOrderModel> Pastry { get; set; }
        public List<SetOrderModel> Holiday { get; set; }
        public List<SetOrderModel> Misc { get; set; }

        public SetOrderListModel ()
        {
            Cakes = new List<SetOrderModel>();
            Cookies = new List<SetOrderModel>();
            Cupcakes = new List<SetOrderModel>();
            Pastry = new List<SetOrderModel>();
            Holiday = new List<SetOrderModel>();
            Misc = new List<SetOrderModel>();
        }
    }
}
