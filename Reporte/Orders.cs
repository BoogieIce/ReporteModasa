using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporte
{
    class Orders
    {
        public int OrderID { get; set; }

        public String CustomerID { get; set; }
        [Display (Name="Conctact Name")]

        public String ContacName { get; set; }
        public String Address { get; set;  }
        [Display(Name = "Postal Code")]
        public String Postalcode { get; set; }
        public String City { get; set; }
        public string Phone { get; set; }
        public DateTime OrderDate { get; set; }

    }
}
