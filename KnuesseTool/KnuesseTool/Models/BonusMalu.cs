namespace KnuesseTool.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BonusMalu
    {
        public int Id { get; set; }

        public int Value { get; set; }

        [Required]
        public string Reason { get; set; }

        public bool? Paid { get; set; }

        public bool? Returned { get; set; }

        public int User_Id { get; set; }

        public virtual User User { get; set; }
    }
}
