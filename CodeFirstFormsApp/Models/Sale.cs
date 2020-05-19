using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstFormsApp.Models
{
    //A sale belongs to a sales person and a sales region
    class Sale : BaseModel
    {
        [Required]
        [Range(0, double.MaxValue)] //Data annotation says value cannot be less than 0
        public decimal Amount { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public virtual SalesPerson Person { get; set; } //Virtual allows EF to add extra code to track when property is being changed
                                                        //** This is the relationship property. This allows us to optional pull SalesPerson data.
        [Required]
        public int PersonId { get; set; }               //** This is the Id property. PersonId and Person are related. Naming is important.


        public virtual SalesRegion Region { get; set; } 

        [Required]
        public int RegionId { get; set; } //One-to-one relationship

    }
}
