using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Models
{
    public class Job
    {
        [Key]
        public int Id { get; set; }

        public JobTypes JobTypes { get; set; }
        [Column(TypeName= "decimal(18,4)")]
        public decimal Price { get; set; }

        public double Rating { get; set; }
        public int GarageID { get; set; }
        public Garage Garage { get; set; }
        public DateTime DoneAt { get; set; }
    }
}
