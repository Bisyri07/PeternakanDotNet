using System.ComponentModel.DataAnnotations;

namespace Peternakan.Models.Entities
{
    public class TernakBiayaCategory
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nama { get; set; }
        public bool Is_active { get; set; } = true;
    }
}
