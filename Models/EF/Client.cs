using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace SaleSoft.Models.EF
{
    public class Client
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FullName { get; set; }

        public int Mark { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }
    }
}
