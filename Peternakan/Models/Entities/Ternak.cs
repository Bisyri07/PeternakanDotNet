using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Peternakan.Models.Entity
{
    public class Ternak
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Kode { get; set; }
        public string Id_jenis { get; set; }
        [ForeignKey("Id_jenis")]
        public TernakJenis Jenis { get; set; }
        public Guid Id_investor { get; set; }
        [ForeignKey("Id_investor")]
        public Pengguna Investor { get; set; }
        public int Harga_beli { get; set; }
        public int Harga_jual { get; set; }
        public int Biaya_perawatan { get; set; }
        public int Status { get; set; }
        public string Indukan_jantan { get; set; }
        public Guid Jantan_id { get; set; }
        public string Indukan_betina { get; set; }
        public Guid Betina_id { get; set; }

    }
}
