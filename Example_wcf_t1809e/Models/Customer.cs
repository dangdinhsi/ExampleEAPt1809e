using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Example_wcf_t1809e.Models
{
    [DataContract]
    public class Customer
    {
        [Key]
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public string SecurityCode { get; set; }
        public string Name { get; set; }
        [DataMember]
        public double CurrentMoney { get; set; }
        [DataMember]
        public CustomerStatus Status { get; set; }
        public enum CustomerStatus
        {
            active =1,
            deactive =0,
        }
    }
}