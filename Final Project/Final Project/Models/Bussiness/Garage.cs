using Final_Project.Models.Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Models
{
    public class Garage
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public double Rating { get; set; }
        public int Done_jobs { get; set; }
        public string Town { get; set; }
        public string Address { get; set; }
        public string OwnerId { get; set; }
        public ApplicationUser Owner { get; set; }

        public ICollection<WorkingDays> WorkingDays{ get; set; }

        public virtual ICollection<Job> Jobs { get; set; }

    }
}
