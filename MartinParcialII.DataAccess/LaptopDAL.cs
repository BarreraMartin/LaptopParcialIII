
using MartinParcialII.AppContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MartinParcialII.DataAccess
{
    public class LaptopDAL
    {
        private static LaptopDAL _instance;

        public static LaptopDAL Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LaptopDAL();
                }
                return _instance;

            }


        }

        public List<Laptop> SellectAll()
        {
            List<Laptop> result = null;
            using (AppDBContext _context = new AppDBContext())
            {
                result = _context.Laptops.ToList();
            }

            return result;


        }

       
        public bool Insert(Laptop entity)
        {
            bool result = false;
            using (AppDBContext _context = new AppDBContext())
            {
                var query = _context.Laptops.FirstOrDefault(x => x.Nombre.Equals(entity.Nombre));
                if (query == null)
                {
                    _context.Laptops.Add(entity);
                    result = _context.SaveChanges() > 0;

                }

                return result;

            }

        }

        public bool Update(Laptop entity)
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
