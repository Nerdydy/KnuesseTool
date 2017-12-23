namespace KnuesseTool.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            BonusMalus = new HashSet<BonusMalu>();
            EventUsers = new HashSet<EventUser>();
            RoleUsers = new HashSet<RoleUser>();
            Meetings = new HashSet<Meeting>();
            Tasks = new HashSet<Task>();
        }

        public int Id { get; set; }

        [StringLength(256)]
        public string Name { get; set; }

        [StringLength(256)]
        public string Prename { get; set; }

        [StringLength(256)]
        public string Email { get; set; }

        [StringLength(256)]
        public string MobilePhoneNumber { get; set; }

        [StringLength(256)]
        public string PhoneNumber { get; set; }

        public DateTime? Birthdate { get; set; }

        [StringLength(256)]
        public string AHVNumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EntryYear { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DepartureYear { get; set; }

        public int? Function_ID { get; set; }

        public int? Task_Id { get; set; }

        public int? CourseNumber_Id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BonusMalu> BonusMalus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventUser> EventUsers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoleUser> RoleUsers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Meeting> Meetings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
