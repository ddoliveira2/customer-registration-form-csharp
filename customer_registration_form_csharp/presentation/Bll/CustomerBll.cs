using presentation.Dal;
using presentation.Dal.Dao;
using presentation.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentation.Bll
{
    public class CustomerBll
    {
        private CustomerDal _dal;

        public CustomerBll()
        {
            this._dal = new CustomerDal();
        }

        public CustomerDto GetOneCustome(string id)
        {
            try
            {
                Int64 _id = 0;

                Int64.TryParse(id, out _id);

                if (_id > 0)
                {
                    return _dal.GetOneCustome(_id);
                }
                return new CustomerDto();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CustomerDto> GetListCustomer(string name, string rg, string cpf)
        {
            try
            {
                return _dal.GetListCustomer(name, rg, cpf);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public CustomerDto CreateCustomer(CustomerDto obj, out string msg)
        {
            try
            {
                msg = "Cliente cadastrado com sucesso!";

                if (string.IsNullOrEmpty(obj.name) || string.IsNullOrEmpty(obj.rg) || string.IsNullOrEmpty(obj.cpf))
                {
                    msg = "Verificar se todos parametros foram preenchidos!";
                    return new CustomerDto();
                }                            

                return _dal.CreateCustomer(obj);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public CustomerDto UpdateCustomer(string id, CustomerDto obj, out string msg)
        {
            try
            {
                msg = "Cliente Atualizado com sucesso!";

                Int64 _id = 0;

                Int64.TryParse(id, out _id);

                if (_id == 0)
                {

                    msg = "Id do cliente não foi informado!";
                    return new CustomerDto();
                }

                if (string.IsNullOrEmpty(obj.name) || string.IsNullOrEmpty(obj.rg) || string.IsNullOrEmpty(obj.cpf))
                {
                    msg = "Verificar se todos parametros foram preenchidos!";
                    return new CustomerDto();
                }        
                return _dal.UpdateCustomer(_id, obj);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public CustomerDto DeleteCustomer(string id, out string msg)
        {
            try
            {
                msg = "Cliente Deletado com sucesso!";

                Int64 _id = 0;

                Int64.TryParse(id, out _id);

                if (_id == 0)
                {

                    msg = "Id do cliente não foi informado!";
                    return new CustomerDto();
                }


                return _dal.DeleteCustomer(_id);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
