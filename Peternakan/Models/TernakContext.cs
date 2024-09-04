using Microsoft.EntityFrameworkCore;
using Peternakan.Models.Entities;
using Peternakan.Models.Entity;

namespace Peternakan.Models
{
    public class TernakContext : DbContext
    {
        public TernakContext(DbContextOptions<TernakContext> options ) : base(options) { }

        // nama nama table yang digunakan di database 
        public DbSet<Pengguna> Pengguna { get; set; }
        public DbSet<Ternak> Ternak { get; set; }
        public DbSet<TernakBiaya> TernakBiaya { get; set; }
        public DbSet<TernakBiayaCategory> TernakBiayaCategory { get; set; }
        public DbSet<TernakGambar> TernakGambar { get; set; }
        public DbSet<TernakJenis> TernakJenis { get; set; }

    }
}
/*
 * NOTE
 kalau kita menambahkan entity ke dalam entities 
 maka kita harus mendaftarkannya disini juga
 */