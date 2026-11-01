using presentation.Dal.Dao;
using presentation.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace presentation.Dal
{
    public class CustomerDal
    {

        public CustomerDto GetOneCustome(Int64 id)
        {
            try
            {
                using (var conn = new SqlServerContext()) {

                    return conn.Customer.FirstOrDefault(i => i.id == id);
                }                
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
                using (var conn = new SqlServerContext())
                {
                    return conn.Customer.Where(i => i.name.Contains(name) && i.rg.Contains(rg) && cpf.Contains(cpf)).ToList();
                }                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CustomerDto CreateCustomer(CustomerDto obj)
        {
            CustomerDto insert = new CustomerDto();
            using (var conn = new SqlServerContext())
            {
                insert.name = obj.name;
                insert.rg = obj.rg;
                insert.cpf = obj.cpf;
                insert.status = true;
                conn.Customer.Add(insert);
                conn.SaveChanges();
                return insert;
            }
            
        }


        public CustomerDto UpdateCustomer(Int64 id, CustomerDto obj)
        {
            using (var conn = new SqlServerContext())
            {
                CustomerDto selected = conn.Customer.FirstOrDefault(i => i.id == id);
                if (selected != null)
                {
                    selected.name = obj.name;
                    selected.rg = obj.rg;
                    selected.cpf = obj.cpf;
                    selected.status = obj.status;
                    conn.SaveChanges();
                }
                return selected;
            }

        }

        public CustomerDto DeleteCustomer(Int64 id)
        {
            using (var conn = new SqlServerContext())
            {
                CustomerDto delete = conn.Customer.FirstOrDefault(i => i.id == id);
                if (delete != null)
                {
                    conn.Customer.Remove(delete);
                    conn.SaveChanges();
                }
                return delete;
            }            
        }
    }
}
