using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class FoodCoupon
    {
        [Key]
        public Guid Id { get; set; }
        public float Amount { get; set; }

    }
}