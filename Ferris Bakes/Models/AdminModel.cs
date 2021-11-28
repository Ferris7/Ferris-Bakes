using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ferris_Bakes.Models
{
    public class AdminModel
    {
        public List<DatabaseSetOrder> DBSet { get; set; }
        public List<CustomOrderModel> CustomOrderList { get; set; }
        public List<SetOrderModel> SetOrderList { get; set; }

        public AdminModel()
        {
            DBSet = new List<DatabaseSetOrder>();
            CustomOrderList = new List<CustomOrderModel>();
            SetOrderList = new List<SetOrderModel>();
        }
    }
}
