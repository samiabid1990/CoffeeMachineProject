using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CoffeOrder
    {
        [Key]
        public string badge { get; set; }

        public string type { get; set; }

        public bool personalCup { get; set; }

        public int sugarQuantity { get; set; }

    }
}
