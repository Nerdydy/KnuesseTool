namespace KnuesseTool.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Event")]
    public partial class Event
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Event()
        {
            EventUsers = new HashSet<EventUser>();
        }

        public int Id { get; set; }

        [StringLength(256)]
        public string Name { get; set; }

        public int? Category_Id { get; set; }

        public int? Programm_Id { get; set; }

        public int? CourseYear_Id { get; set; }

        public virtual Category Category { get; set; }

        public virtual CourseYear CourseYear { get; set; }

        public virtual Programm Programm { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventUser> EventUsers { get; set; }
    }
}
