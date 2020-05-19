using CodeFirstFormsApp.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstFormsApp.Models
{
    class SalesPerson : BaseModel , IActive //A sales person belongs to a region
    {
        [Required]
        public bool Active { get; set; }

        [Required] //These are data annotations. EF has defaults, but we may specify 
        [StringLength(100)]

        public string FirstName { get; set; }
        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        public virtual SalesRegion Region { get; set; }

        //To connect to a model we need one property for the model itself. And one property for the models Id.
        [Required]
        public int RegionId { get; set; } //One-to-one relationship. To make property nullable put ? after type. ex: public int? RegionId { get; set; }

        public virtual ObservableListSource<Sale> Sales { get; set; } //One-to-many relationship

        [Required]
        [Range(0, double.MaxValue)] //Data annotation says value cannot be less than 0
        public decimal SalesTarget { get; set; }

        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", FirstName, LastName).Trim();
            }
        }
    }
}
