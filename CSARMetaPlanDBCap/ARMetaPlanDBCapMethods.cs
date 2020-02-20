using CSARMetaPlan.Class;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSARMetaPlanDBCap
{
    public class ARMetaPlanDBCapMethods
    {
        private SqlConnection Connection = null;

        public ARMetaPlanDBCapMethods() { }

        public ARMetaPlanDBCapMethods(SqlConnection connection)
        {
            Connection = connection;
        }

        public void SaveAdatElem(AdatElem adatElem)
        {
                using (var context = new MetaPlanContext())
                {

                    context.AdatElemek.Add(adatElem);
                    context.SaveChanges();
                }

        }

        public void SaveAdatKor(Adatkor adatKor)
        {
                using (var context = new MetaPlanContext())
                {

                    context.AdatKorok.Add(adatKor);
                    context.SaveChanges();
                }

        }

        public void SaveEljarasTipus(EljarasTipus eljarasTipus)
        {
            using (var context = new MetaPlanContext())
            {

                context.EljarasTipusok.Add(eljarasTipus);
                context.SaveChanges();
            }


        }

        public void SaveFejlesztesiAllapot(FejlesztesiAllapot fejlesztesiAllapot)
        {
            using (var context = new MetaPlanContext())
            {

                context.FejlesztesiAllapotok.Add(fejlesztesiAllapot);
                context.SaveChanges();
            }

        }

        public void SaveKepernyo(Kepernyo kepernyo)
        {
            using (var context = new MetaPlanContext())
            {

                context.Kepernyok.Add(kepernyo);
                context.SaveChanges();
            }

        }

        public void SaveKepernyoAdatkor(KepernyoAdatkor kepernyoAdatkor)
        {
            using (var context = new MetaPlanContext())
            {

                context.KepernyoAdatkorok.Add(kepernyoAdatkor);
                context.SaveChanges();
            }

        }

        public void SaveKepernyoElem(KepernyoElem kepernyoElem)
        {
            using (var context = new MetaPlanContext())
            {

                context.KepernyoElemek.Add(kepernyoElem);
                context.SaveChanges();
            }

        }

        public void SaveKepernyoFejlesztesiAllapot(KepernyoFejlesztesiAllapot kepernyoFejlesztesiAllapot)
        {
            using (var context = new MetaPlanContext())
            {

                context.KepernyoFejlesztesiAllapotok.Add(kepernyoFejlesztesiAllapot);
                context.SaveChanges();
            }

        }

        public void SaveKepernyoGyujtemeny(KepernyoGyujtemeny kepernyoGyujtemeny)
        {
            using (var context = new MetaPlanContext())
            {

                context.KepernyoGyujtemenyek.Add(kepernyoGyujtemeny);
                context.SaveChanges();
            }

        }

        public void SaveKepernyoTeszteles(KepernyoTeszteles kepernyoTeszteles)
        {
            using (var context = new MetaPlanContext())
            {

                context.KepernyoTesztelesek.Add(kepernyoTeszteles);
                context.SaveChanges();
            }

        }

        public void SaveMetodus(Metodus metodus)
        {
            using (var context = new MetaPlanContext())
            {

                context.Metodusok.Add(metodus);
                context.SaveChanges();
            }

        }

        public void SaveModul(Modul modul)
        {
            using (var context = new MetaPlanContext())
            {

                context.Modulok.Add(modul);
                context.SaveChanges();
            }

        }

        public void SaveMuvelet(Muvelet muvelet)
        {
            using (var context = new MetaPlanContext())
            {

                context.Muveletek.Add(muvelet);
                context.SaveChanges();
            }

        }

        public Muvelet GetByGUIDMuvelet(string guid)
        {
            using(var context = new MetaPlanContext())
            {
                return context.Muveletek
                    .FirstOrDefault<Muvelet>(muvelet => muvelet.GUID == guid);
            }
        }

        public void SaveProgramkod(Programkod programkod)
        {
            using (var context = new MetaPlanContext())
            {

                context.Programkodok.Add(programkod);
                context.SaveChanges();
            }


        }

        public void SaveRAMetaObjektum(RAMetaObjektum rAMetaObjektum)
        {
            using (var context = new MetaPlanContext())
            {

                context.RAMetaObjektumok.Add(rAMetaObjektum);
                context.SaveChanges();
            }


        }

        public void SaveTabla(Tabla tabla)
        {
            using (var context = new MetaPlanContext())
            {

                context.Tablak.Add(tabla);
                context.SaveChanges();
            }


        }

        public void SaveTablaOszlop(TablaOszlop tablaOszlop)
        {
            using (var context = new MetaPlanContext())
            {

                context.TablaOszlopok.Add(tablaOszlop);
                context.SaveChanges();
            }


        }

        public void SaveTaroltEljaras(TaroltEljaras taroltEljaras)
        {
            using (var context = new MetaPlanContext())
            {

                context.TaroltEljarasok.Add(taroltEljaras);
                context.SaveChanges();
            }


        }

        public void SaveTaroltEljarasArgumentum(TaroltEljarasArgumentum taroltEljarasArgumentum)
        {
            using (var context = new MetaPlanContext())
            {

                context.TaroltEljarasArgumentumok.Add(taroltEljarasArgumentum);
                context.SaveChanges();
            }


        }

        public void SaveTeszteles(Teszteles teszteles)
        {
            using (var context = new MetaPlanContext())
            {

                context.Tesztelesek.Add(teszteles);
                context.SaveChanges();
            }

        }
    }
}

