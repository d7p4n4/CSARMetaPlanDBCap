using CSARMetaPlan.Class;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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

        public void InsertMuvelet(Muvelet muvelet)
        {
            using (var context = new MetaPlanContext())
            {

                context.Muveletek.Add(muvelet);
                context.SaveChanges();
            }

        }

        public bool IsExistMuveletById(Muvelet muvelet)
        {
            using (var context = new MetaPlanContext())
            {
                Muvelet isExistMuvelet = context.Muveletek.Find(muvelet.Id);

                if(isExistMuvelet != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        public bool IsExistMuveletByGUID(Muvelet muvelet)
        {
            using (var context = new MetaPlanContext())
            {
                Muvelet isExistMuvelet = context.Muveletek.Find(muvelet.GUID);

                if (isExistMuvelet != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        public Muvelet GetByIdMuvelet(Muvelet muvelet)
        {
            using (var context = new MetaPlanContext())
            {
                return context.Muveletek.Find(muvelet.Id);
                
            }

        }

        public void UpdateMuveletById(Muvelet updatedMuvelet)
        {
            using (var context = new MetaPlanContext())
            {
                var muvelet = context.Muveletek.Find(updatedMuvelet.Id);
                muvelet.Valasz = updatedMuvelet.Valasz;
                muvelet.GUID = updatedMuvelet.GUID;
                muvelet.TurelmiIdo = updatedMuvelet.TurelmiIdo;
                muvelet.Keres = updatedMuvelet.Keres;
                muvelet.ArgumentumLista = updatedMuvelet.ArgumentumLista;
                muvelet.Nevproblemas = updatedMuvelet.Nevproblemas;
                muvelet.ValaszTipus = updatedMuvelet.ValaszTipus;
                context.SaveChanges();

            }

        }

        public void UpdateMuveletByGUID(Muvelet updatedMuvelet)
        {
            using (var context = new MetaPlanContext())
            {
                var muvelet = context.Muveletek.Find(updatedMuvelet.GUID);
                muvelet.Valasz = updatedMuvelet.Valasz;
                muvelet.GUID = updatedMuvelet.GUID;
                muvelet.TurelmiIdo = updatedMuvelet.TurelmiIdo;
                muvelet.Keres = updatedMuvelet.Keres;
                muvelet.ArgumentumLista = updatedMuvelet.ArgumentumLista;
                muvelet.Nevproblemas = updatedMuvelet.Nevproblemas;
                muvelet.ValaszTipus = updatedMuvelet.ValaszTipus;20.4
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
        
    }
}

