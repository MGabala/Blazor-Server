using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorServer.Entities
{
    public class ItemEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(5,ErrorMessage ="Sorry, testing validation (max 5 characters)")]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public DateTime ProductionDate { get; set; }
        public bool IsAvailable { get; set; }
    }
}
