using MartinParcialII.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartinParcialII.BusinessLogic
{
    public class DocenteBL
    {
        private static DocenteBL _instance;

        public static DocenteBL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DocenteBL();

                return _instance;
            }
        }

        public List<Docente> SellecALL()
        {
            List<Docente> result;
            try
            {
                result = DocenteDAL.Instance.SellectAll();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return result;
        }



        public bool Insert(Docente entity)
        {
            bool result = false;
            try
            {
                result = DocenteDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
            return result;
        }

        public bool Update(Docente entity)
        {
            bool result = false;
            try
            {
                result = DocenteDAL.Instance.Update(entity);
            }
            catch (Exception ex)
            {
                throw new Exception("Error. " + ex.Message);
            }
            return result;
        }
    }
}
