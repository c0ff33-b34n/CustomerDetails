using System.ComponentModel.DataAnnotations;

namespace CustomerDetails.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(50)]
        public string BusinessName { get; set; }
        [StringLength(35)]
        public string BuildingName { get; set; }
        [Required]
        [StringLength(35)]
        public string NumberAndStreet { get; set; }
        [StringLength(35)]
        public string LocalityName { get; set; }
        [Required]
        [StringLength(35)]
        public string TownOrCity { get; set; }
        [Required]
        [StringLength(35)]
        public string County { get; set; }
        [Required]
        [StringLength(8)]
        public string PostCode { get; set; }
    }
}