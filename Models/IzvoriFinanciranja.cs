using ATECH.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATECH.Models
{
    public class IzvoriFinanciranja
    {
        public int Id { get; set; }
        public string IzvorFinanciranja { get; set; }

        public override string ToString()
        {
            return IzvorFinanciranja;
        }

    }
}
