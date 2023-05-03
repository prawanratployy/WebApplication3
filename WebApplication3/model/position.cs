using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.model
{
    public class position
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]       
        public string positionId { get; set; }
        public string positionName { get; set; }
        public float baseSalary { get; set; }
        public float salaryIncreaseRate { get; set; }
        
    }
}
