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
            try
            {
                using (var context = new MetaPlanContext())
                {

                    context.AdatElemek.Add(adatElem);
                    context.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            
        }

        public void SaveAdatKor(Adatkor adatKor)
        {
            try
            {
                using (var context = new MetaPlanContext())
                {

                    context.AdatKorok.Add(adatKor);
                    context.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

        }

        public void SaveEljarasTipus(EljarasTipus eljarasTipus)
        {
            try
            {
                using (var context = new MetaPlanContext())
                {

                    context.EljarasTipusok.Add(eljarasTipus);
                    context.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

        }

        public void SaveFejlesztesiAllapot(FejlesztesiAllapot fejlesztesiAllapot)
        {
            try
            {
                using (var context = new MetaPlanContext())
                {

                    context.FejlesztesiAllapotok.Add(fejlesztesiAllapot);
                    context.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

        }

        public void SaveKepernyo(Kepernyo kepernyo)
        {
            try
            {
                using (var context = new MetaPlanContext())
                {

                    context.Kepernyok.Add(kepernyo);
                    context.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

        }

        public void SaveKepernyoAdatkor(KepernyoAdatkor kepernyoAdatkor)
        {
            try
            {
                using (var context = new MetaPlanContext())
                {

                    context.KepernyoAdatkorok.Add(kepernyoAdatkor);
                    context.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

        }

        public void SaveKepernyoElem(KepernyoElem kepernyoElem)
        {
            try
            {
                using (var context = new MetaPlanContext())
                {

                    context.KepernyoElemek.Add(kepernyoElem);
                    context.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

        }

        public void SaveKepernyoFejlesztesiAllapot(KepernyoFejlesztesiAllapot kepernyoFejlesztesiAllapot)
        {
            try
            {
                using (var context = new MetaPlanContext())
                {

                    context.KepernyoFejlesztesiAllapotok.Add(kepernyoFejlesztesiAllapot);
                    context.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

        }

        public void SaveKepernyoGyujtemeny(KepernyoGyujtemeny kepernyoGyujtemeny)
        {
            try
            {
                using (var context = new MetaPlanContext())
                {

                    context.KepernyoGyujtemenyek.Add(kepernyoGyujtemeny);
                    context.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

        }

        public void SaveKepernyoTeszteles(KepernyoTeszteles kepernyoTeszteles)
        {
            try
            {
                using (var context = new MetaPlanContext())
                {

                    context.KepernyoTesztelesek.Add(kepernyoTeszteles);
                    context.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

        }

        public void SaveMetodus(Metodus metodus)
        {
            try
            {
                using (var context = new MetaPlanContext())
                {

                    context.Metodusok.Add(metodus);
                    context.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

        }

        public void SaveModul(Modul modul)
        {
            try
            {
                using (var context = new MetaPlanContext())
                {

                    context.Modulok.Add(modul);
                    context.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

        }

        public void SaveMuvelet(Muvelet muvelet)
        {
            try
            {
                using (var context = new MetaPlanContext())
                {

                    context.Muveletek.Add(muvelet);
                    context.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

        }

        public void SaveProgramkod(Programkod programkod)
        {
            try
            {
                using (var context = new MetaPlanContext())
                {

                    context.Programkodok.Add(programkod);
                    context.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

        }

        public void SaveRAMetaObjektum(RAMetaObjektum rAMetaObjektum)
        {
            try
            {
                using (var context = new MetaPlanContext())
                {

                    context.RAMetaObjektumok.Add(rAMetaObjektum);
                    context.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

        }

        public void SaveTabla(Tabla tabla)
        {
            try
            {
                using (var context = new MetaPlanContext())
                {

                    context.Tablak.Add(tabla);
                    context.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

        }

        public void SaveTablaOszlop(TablaOszlop tablaOszlop)
        {
            try
            {
                using (var context = new MetaPlanContext())
                {

                    context.TablaOszlopok.Add(tablaOszlop);
                    context.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

        }

        public void SaveTaroltEljaras(TaroltEljaras taroltEljaras)
        {
            try
            {
                using (var context = new MetaPlanContext())
                {

                    context.TaroltEljarasok.Add(taroltEljaras);
                    context.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

        }

        public void SaveTaroltEljarasArgumentum(TaroltEljarasArgumentum taroltEljarasArgumentum)
        {
            try
            {
                using (var context = new MetaPlanContext())
                {

                    context.TaroltEljarasArgumentumok.Add(taroltEljarasArgumentum);
                    context.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

        }

        public void SaveTeszteles(Teszteles teszteles)
        {
            try
            {
                using (var context = new MetaPlanContext())
                {

                    context.Tesztelesek.Add(teszteles);
                    context.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

        }
    }
}
