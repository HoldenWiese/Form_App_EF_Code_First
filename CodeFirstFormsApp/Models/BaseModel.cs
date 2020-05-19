using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstFormsApp.Models
{
    class BaseModel //This base model ensures all entities include the following columns/properties.
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string CreatedBy { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public string UpdateBy { get; set; }
        [Required]
        public DateTime UpdatedDate { get; set; }

    }
}
