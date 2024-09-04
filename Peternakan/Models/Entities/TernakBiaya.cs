using Peternakan.Models.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Peternakan.Models.Entities
{
    public class TernakBiaya
    {
        public Guid Id { get; set; }
        public Guid Id_ternak { get; set; }
        [ForeignKey("Id_ternak")]
        public Ternak Ternak { get; set; }
        public DateTime Tanggal { get; set; }
        public int Jumlah { get; set; }
        public string img1 { get; set; }
        public string img2 { get; set; }
        public string img3 { get; set; }
        public string img4 { get; set; }
        public string img5 { get; set; }
    }
}
