using MartinParcialII.AppContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MartinParcialII.DataAccess
{
    public class DocenteDAL
    {
        private static DocenteDAL _instance;

        public static DocenteDAL Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DocenteDAL();
                }
                return _instance;

            }


        }

        public List<Docente> SellectAll()
        {
            List<Docente> result = null;
            using (AppDBContext _context = new AppDBContext())
            {
                result = _context.Docentes.Include(x =>x.Laptops).ToList();
            }

            return result;


        }


        public bool Insert(Docente entity)
        {
            bool result = false;
            using (AppDBContext _context = new AppDBContext())
            {
                var query = _context.Docentes.FirstOrDefault(x => x.Nombre.Equals(entity.Nombre));
                if (query == null)
                {
                    _context.Docentes.Add(entity);
                    result = _context.SaveChanges() > 0;

                }

                return result;

            }

        }

        public bool Update(Docente entity)
        {
            bool result = false;
            using (AppDBContext _context = new AppDBContext())
            {
                _context.Entry(entity).State = EntityState.Modified;
                result = _context.SaveChanges() > 0;
            }
            return result;

        }

    }
}
