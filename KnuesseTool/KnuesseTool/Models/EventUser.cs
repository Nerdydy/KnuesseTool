namespace KnuesseTool.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EventUser")]
    public partial class EventUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EventUser()
        {
            AmmoSigneds = new HashSet<AmmoSigned>();
            Results = new HashSet<Result>();
        }

        public int Id { get; set; }

        public int Event_Id { get; set; }

        public int User_Id { get; set; }

        public bool Participate { get; set; }

        public int Depth { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AmmoSigned> AmmoSigneds { get; set; }

        public virtual Event Event { get; set; }

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Result> Results { get; set; }
    }
}
