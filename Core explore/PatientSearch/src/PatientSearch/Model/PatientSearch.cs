using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PatientSearch.Model
{
    public class Patientinfo
    {
        public string ChartID { get; set; }
        [Key]
        public Guid PatientGUID { get; set; }
        public string LastName { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string MI { get; set; } = string.Empty;
        public string Sex { get; set; } = string.Empty;
        public DateTime DOB { get; set; } = DateTime.MinValue;
    }

    public class PatientContext:DbContext {
        public PatientContext(DbContextOptions<PatientContext> options) : base(options)
        {
        }
        public DbSet<Patientinfo> Patients { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // modelBuilder.Entity<Patients>().ToTable("Course");
           
        }
    }
}
