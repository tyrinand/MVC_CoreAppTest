using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SaleSoft.Models.EF;

namespace SaleSoft.Models
{
    public class IndexViewModel<T>
    {
        public IEnumerable<T> List { get; set; }
        public PageViewModel PageViewModel { get; set; }
    }
}
