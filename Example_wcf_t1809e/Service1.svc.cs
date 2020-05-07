using Example_wcf_t1809e.Data;
using Example_wcf_t1809e.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Example_wcf_t1809e
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private Example_wcf_t1809eContext db = new Example_wcf_t1809eContext();



        public Customer GetById(string code)
        {
            var customer = db.Customers.Where(x => x.Code.Equals(code)).FirstOrDefault();
            if (customer == null)
            {
                throw new ArgumentNullException("customer");
            }
            return customer;
        }

        public Customer GetAccount(string code, string pass)
        {
            var loginCustomer = db.Customers.Where(x => x.Code.Equals(code) && x.SecurityCode.Equals(pass)).FirstOrDefault();
            if (loginCustomer == null)
            {
                throw new ArgumentNullException("customer");
            }
            return loginCustomer;
        }
        public List<Customer> TransferMoney(string sCode, string rCode, double amount)
        {
            var sendCustomer = db.Customers.Find(sCode);
            var receiverCustomer = db.Customers.Find(rCode);
            if (sendCustomer == null)
            {
                throw new ArgumentNullException("customer");

            }
            if (receiverCustomer == null)
            {
                throw new ArgumentNullException("customer");
            }
            if(sendCustomer.CurrentMoney < amount)
            {
                throw new ArgumentNullException("customer");
            }

            sendCustomer.CurrentMoney -= amount;
            receiverCustomer.CurrentMoney += amount;
            db.Customers.AddOrUpdate(sendCustomer, receiverCustomer);
            db.SaveChanges();
            return db.Customers.ToList();
        }
        public List<Customer> GetAllCustomer()
        {
            return db.Customers.ToList();
        }
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

       
    }
}
