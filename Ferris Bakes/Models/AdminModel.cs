using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ferris_Bakes.Models
{
    public class AdminModel
    {
        public List<DatabaseCustomOrder> dbCustom { get; set; }
        public List<DatabaseSetOrder> dbSet { get; set; }
        public List<CustomOrderModel> CustomOrderList { get; set; }
        public List<SetOrderModel> SetOrderList { get; set; }
    }
}
