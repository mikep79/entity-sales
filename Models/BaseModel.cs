using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SalesApp.Models
{
    class BaseModel
    {
        [Key]
        [Required]
        public int Id
        {
            get;
            set;
        }
        // know which user created model
        public string CreatedBy
        {
            get;
            set;
        }

        public string UpdatedBy
        {
            get;
            set;
        }
        
        // whenever model created, CreatedDate auto inserted into db
        public DateTime CreatedDate
        {
            get;
            set;
        }

        public DateTime UpdatedDate
        {
            get;
            set;
        }
    }
}
