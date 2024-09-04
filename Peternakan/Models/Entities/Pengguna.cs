using System.ComponentModel.DataAnnotations;

namespace Peternakan.Models.Entity
{
    public class Pengguna
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nama { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string No_hp { get; set; }
        public string Role { get; set; } = "Investor";
        public bool Is_active { get; set; } = true;

    }
}
