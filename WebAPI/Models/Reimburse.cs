using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Reimburse
    {
        public string purchaseDate { get; set; }
        public string purchaseAmount { get; set; }
        public string purchaseDesc { get; set; }
        public FileDetail fileDetail { get; set; }
    }
}
