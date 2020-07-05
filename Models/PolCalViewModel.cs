using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PolCal.Models
{
    public class PolCalViewModel : DbContext 
    {
        public string PolicyType { get; set; }

        public string Amount { get; set; }

        public int Year { get; set; }
 protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\;Database=EFCoreWebDemo;Trusted_Connection=True;MultipleActiveResultSets=true");
     
    }
    }}