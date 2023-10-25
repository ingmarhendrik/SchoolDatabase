using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Student
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string? HomeNumber { get; set; }
        public string? Address { get; set; }
        public IEnumerable<FoodCoupon>? FoodCoupons { get; set; } = new List<FoodCoupon>();


    }
}