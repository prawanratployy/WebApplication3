using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.model
{
    public class employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string empId { get; set; }
        public string empName { get; set; }
        public string Email { get; set; }
        public string phoneNumber { get; set; }
        public DateTime hireDate { get; set; }
        public string positionID { get; set; }
    }
}
