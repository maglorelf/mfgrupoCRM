using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace mfgrupoCRM.Data.EntityFramework.Models
{
  public  class CustomerDAO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Fullname { get; set; }


        public static CustomerDAO FromDomain(Core.Domain.Customer customer)
        {

            return new CustomerDAO
            {

              
                Id = customer.Id,
                Fullname= customer.Fullname,
              
            };

        }

        public Core.Domain.Customer ToDomain()
        {

            return new Core.Domain.Customer
            {

                Id = Id,
                Fullname = Fullname,
               
            };

        }
    }
}
