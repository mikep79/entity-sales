using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SalesApp.Models
{
    // inherit model
    class Sale : BaseModel
    {

        [Required]
        [Range(0.01, double.MaxValue)]
        public decimal Amount 
        { 
            get;
            set;
        }

        [Required]
        public DateTime Date { get; set; }

        public virtual SalesPerson Person { get; set; }

        // MUST be Person. Entity framework then knows
        // to relate PersonId to Person.
        [Required]
        public int PersonId { get; set; }

        public virtual SalesRegion Region { get; set; }

        [Required]
        public int RegionId { get; set; }
    }
}
