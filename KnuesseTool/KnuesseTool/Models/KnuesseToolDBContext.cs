namespace KnuesseTool.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class KnuesseToolDBContext : DbContext
    {
        public KnuesseToolDBContext()
            : base("name=KnuesseToolDBContext")
        {
        }

        public virtual DbSet<AmmoSigned> AmmoSigneds { get; set; }
        public virtual DbSet<BonusMalu> BonusMalus { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CourseYear> CourseYears { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<EventUser> EventUsers { get; set; }
        public virtual DbSet<Meeting> Meetings { get; set; }
        public virtual DbSet<Programm> Programms { get; set; }
        public virtual DbSet<ProgrammTarget> ProgrammTargets { get; set; }
        public virtual DbSet<Result> Results { get; set; }
        public virtual DbSet<RoleUser> RoleUsers { get; set; }
        public virtual DbSet<Target> Targets { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<CourseNumber> CourseNumbers { get; set; }
        public virtual DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(e => e.Events)
                .WithOptional(e => e.Category)
                .HasForeignKey(e => e.Category_Id);

            modelBuilder.Entity<CourseYear>()
                .HasMany(e => e.Events)
                .WithOptional(e => e.CourseYear)
                .HasForeignKey(e => e.CourseYear_Id);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.EventUsers)
                .WithRequired(e => e.Event)
                .HasForeignKey(e => e.Event_Id);

            modelBuilder.Entity<EventUser>()
                .HasMany(e => e.AmmoSigneds)
                .WithOptional(e => e.EventUser)
                .HasForeignKey(e => e.EventUser_Id)
                .WillCascadeOnDelete();

            modelBuilder.Entity<EventUser>()
                .HasMany(e => e.Results)
                .WithRequired(e => e.EventUser)
                .HasForeignKey(e => e.EventUser_Id);

            modelBuilder.Entity<Meeting>()
                .HasMany(e => e.Documents)
                .WithOptional(e => e.Meeting)
                .HasForeignKey(e => e.Meeting_Id)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Meeting>()
                .HasMany(e => e.Users)
                .WithMany(e => e.Meetings)
                .Map(m => m.ToTable("MeetingUser"));

            modelBuilder.Entity<Programm>()
                .HasMany(e => e.Events)
                .WithOptional(e => e.Programm)
                .HasForeignKey(e => e.Programm_Id)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Programm>()
                .HasMany(e => e.ProgrammTargets)
                .WithRequired(e => e.Programm)
                .HasForeignKey(e => e.Programm_Id);

            modelBuilder.Entity<Target>()
                .HasMany(e => e.ProgrammTargets)
                .WithRequired(e => e.Target)
                .HasForeignKey(e => e.Target_Id);

            modelBuilder.Entity<Task>()
                .HasMany(e => e.Users)
                .WithMany(e => e.Tasks)
                .Map(m => m.ToTable("TaskUser"));

            modelBuilder.Entity<User>()
                .HasMany(e => e.BonusMalus)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.User_Id);

            modelBuilder.Entity<User>()
                .HasMany(e => e.EventUsers)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.User_Id);

            modelBuilder.Entity<User>()
                .HasMany(e => e.RoleUsers)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.User_Id);
        }
    }
}
