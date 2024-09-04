using System.ComponentModel.DataAnnotations;

namespace Peternakan.Models.Entities
{
    public class TernakJenis
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nama { get; set; }
        public string Note { get; set; }
        public bool Is_active { get; set; }
    }
}
