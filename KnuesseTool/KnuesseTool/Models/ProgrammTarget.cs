namespace KnuesseTool.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProgrammTarget")]
    public partial class ProgrammTarget
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Programm_Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Target_Id { get; set; }

        public int AmountOfShots { get; set; }

        public bool? Trial { get; set; }

        public int Order { get; set; }

        public bool Shown { get; set; }

        public int? Time { get; set; }

        public virtual Programm Programm { get; set; }

        public virtual Target Target { get; set; }
    }
}
