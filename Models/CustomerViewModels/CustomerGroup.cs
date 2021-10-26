using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Pascu_Ioana_Lab2.Models.CustomerViewModels
{
    public class CustomerGroup
    {
        public string CustomerName { get; set; }
        public int BookCount { get; set; }
    }
}
