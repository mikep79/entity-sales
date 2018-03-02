using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesApp.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace SalesApp.Models
{
    class SalesPerson : BaseModel, IActive
    {

        [Required]
        public bool Active
        {
            get;
            set;
        }

        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20)]
        public string LastName { get; set; }

        public virtual SalesRegion Region { get; set; }

        [Required]
        public int RegionId { get; set; }

        public virtual ObservableListSource<SalesPerson> People { get; set; }
    }
}
