using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataAccess.Entities
{
    public partial class EventSchedulerContext : DbContext
    {
        public EventSchedulerContext()
        {
        }

        public EventSchedulerContext(DbContextOptions<EventSchedulerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Attendee> Attendee { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<EventAttendee> EventAttendee { get; set; }
        public virtual DbSet<EventNotification> EventNotification { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=EventScheduler;Integrated security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attendee>(entity =>
            {
                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EventAttendee>(entity =>
            {
                entity.HasOne(d => d.Attendee)
                    .WithMany(p => p.EventAttendee)
                    .HasForeignKey(d => d.AttendeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EventAtte__Atten__2C3393D0");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.EventAttendee)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EventAtte__Event__2B3F6F97");
            });

            modelBuilder.Entity<EventNotification>(entity =>
            {
                entity.Property(e => e.DateSent).HasColumnType("datetime");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.EventNotification)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EventNoti__Event__276EDEB3");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
