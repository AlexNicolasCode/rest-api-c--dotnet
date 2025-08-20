using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestAPI.Entities
{
    [Table("products")]
    public class ProductEntity
    {
        public ProductEntity()
        {
            SetCreated();
        }


        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("name")]
        public string Name { get; set; }

        [Column("price", TypeName = "real")]
        public float Price { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; private set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; private set; }

        [Column("deleted_at")]
        public DateTime? DeletedAt { get; set; }

        public void SetCreated()
        {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }

        public void SetUpdated()
        {
            UpdatedAt = DateTime.UtcNow;
        }

        public void SoftDelete()
        {
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
