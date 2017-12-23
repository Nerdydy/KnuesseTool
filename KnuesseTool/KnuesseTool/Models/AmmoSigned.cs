namespace KnuesseTool.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AmmoSigned")]
    public partial class AmmoSigned
    {
        public int Id { get; set; }

        public int Recieved { get; set; }

        public int? Returned { get; set; }

        public bool Signed { get; set; }

        public DateTime Date { get; set; }

        [Required]
        public string Comment { get; set; }

        public int User_Id { get; set; }

        public int? EventUser_Id { get; set; }

        public virtual EventUser EventUser { get; set; }
    }
}
