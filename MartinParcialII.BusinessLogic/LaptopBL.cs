using MartinParcialII.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartinParcialII.BusinessLogic
{
    public class LaptopBL
    {
        private static LaptopBL _instance;

        public static LaptopBL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LaptopBL();

                return _instance;
            }
        }

        public List<Laptop> SellecALL()
        {
            List<Laptop> result;
            try
            {
                result = LaptopDAL.Instance.SellectAll();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return result;
        }



        public bool Insert(Laptop entity)
        {
            bool result = false;
            try
            {
                result = LaptopDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
            return result;
        }

        public bool Update(Laptop entity)
        {
            bool result = false;
            try
            {
                result = LaptopDAL.Instance.Update(entity);
            }
            catch (Exception ex)
            {
                throw new Exception("Error. " + ex.Message);
            }
            return result;
        }
    }
}
