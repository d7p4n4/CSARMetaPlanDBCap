using CSARMetaPlan.Class;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSARMetaPlanDBCap
{
    class MetaPlanContext : DbContext
    {
        public MetaPlanContext(): base()
        {
            Database.SetInitializer<MetaPlanContext>(new CreateDatabaseIfNotExists<MetaPlanContext>());
        }

        public DbSet<AdatElem> AdatElemek { get; set; }
        public DbSet<Adatkor> AdatKorok { get; set; }
        public DbSet<EljarasTipus> EljarasTipusok { get; set; }
        public DbSet<FejlesztesiAllapot> FejlesztesiAllapotok { get; set; }
        public DbSet<Kepernyo> Kepernyok { get; set; }
        public DbSet<KepernyoAdatkor> KepernyoAdatkorok { get; set; }
        public DbSet<KepernyoElem> KepernyoElemek { get; set; }
        public DbSet<KepernyoFejlesztesiAllapot> KepernyoFejlesztesiAllapotok { get; set; }
        public DbSet<KepernyoGyujtemeny> KepernyoGyujtemenyek { get; set; }
        public DbSet<KepernyoTeszteles> KepernyoTesztelesek { get; set; }
        public DbSet<Metodus> Metodusok { get; set; }
        public DbSet<Modul> Modulok { get; set; }
        public DbSet<Muvelet> Muveletek { get; set; }
        public DbSet<Programkod> Programkodok { get; set; }
        public DbSet<RAMetaObjektum> RAMetaObjektumok { get; set; }
        public DbSet<Tabla> Tablak { get; set; }
        public DbSet<TablaOszlop> TablaOszlopok { get; set; }
        public DbSet<TaroltEljaras> TaroltEljarasok { get; set; }
        public DbSet<TaroltEljarasArgumentum> TaroltEljarasArgumentumok { get; set; }
        public DbSet<Teszteles> Tesztelesek { get; set; }
    }
}
