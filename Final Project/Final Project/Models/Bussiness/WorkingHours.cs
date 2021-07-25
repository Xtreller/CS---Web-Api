using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Models
{
    public class WorkingHours
    {
        [Key]
        public int Id { get; set; }
        
        public int GarageId { get; set; }
        public Garage Garage { get; set; }
        public DateTime OpensAt { get; set; }
        public DateTime CloseAt { get; set; }

    }
}
