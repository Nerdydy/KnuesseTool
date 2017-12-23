namespace KnuesseTool.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Result")]
    public partial class Result
    {
        public int Id { get; set; }

        [Column("Result")]
        public int Result1 { get; set; }

        public int EventUser_Id { get; set; }

        public virtual EventUser EventUser { get; set; }
    }
}
