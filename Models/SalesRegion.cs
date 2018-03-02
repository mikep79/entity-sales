using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesApp.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace SalesApp.Models
{
    class SalesRegion : BaseModel, IActive
    {

        public bool Active
        {
            get;
            set;
        }

        [Required]
        public string Name { get; set; }

        [Required]
        [MaxLength(int.MaxValue)]
        public string Code { get; set; }

        public virtual ObservableListSource<SalesPerson> People { get; set; }
        public virtual ObservableListSource<Sale> Sale { get; set; }

    }
}
