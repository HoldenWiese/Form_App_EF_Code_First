using CodeFirstFormsApp.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstFormsApp.Models
{
    class SalesRegion : BaseModel, IActive
    {
        [Required]
        public bool Active { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Code { get; set; }

        public virtual ObservableListSource<SalesPerson> People { get; set; } //One-to-many relationship

        public virtual ObservableListSource<Sale> Sales { get; set; } //One-to-many relationship

        [Required]
        [Range(0, double.MaxValue)] //Data annotation says value cannot be less than 0
        public decimal SalesTarget { get; set; }
    }
}
