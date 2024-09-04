using Peternakan.Models.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Peternakan.Models.Entities
{
    public class TernakGambar
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid Id_ternak { get; set; }
        [ForeignKey("Id_ternak")]
        public Ternak Ternak { get; set; }
        public Guid Id_category { get; set; }
        [ForeignKey("Id_category")]
        public TernakBiayaCategory Category { get; set; }
        public DateTime Tanggal { get; set; }
        public int jumlah { get; set; }
        public string img1 { get; set; }
        public string img2 { get; set; }
        public string img3 { get; set; }
        public string Keterangan { get; set; }

    }
}
