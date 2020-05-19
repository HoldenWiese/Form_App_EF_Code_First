using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstFormsApp.Models.Interfaces
{
    interface IActive //This interface allows us to soft delete by giving a row and active equals false value.
    {
        bool Active { get; set; }
    }
}
