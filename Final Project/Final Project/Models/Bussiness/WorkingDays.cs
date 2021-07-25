using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Models.Bussiness
{
    public class WorkingDays
    {
        [Key]
        public int Id { get; set; }
        public string Day { get; set; }
        public ICollection<WorkingHours> WorkingHours { get; set; }
    }
}
