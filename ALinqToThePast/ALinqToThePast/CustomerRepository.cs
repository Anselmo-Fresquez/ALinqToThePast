using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALinqToThePast {
    class CustomerRepository {
        List<Customer> custList = new List<Customer> {
            new Customer() {
                CustomerId      = 1,
                FirstName       = "Frodo",
                LastName        = "Baggins",
                EmailAddress    = "frobro@shiremail.nz",
                CustomerTypeId  = 1
            },
            new Customer() {
                CustomerId      = 2,
                FirstName       = "Bilbo",
                LastName        = "Baggins",
                EmailAddress    = "goodmorning@shiremail.nz",
                CustomerTypeId  = 1
            },
            new Customer() {
                CustomerId      = 3,
                FirstName       = "Samwise",
                LastName        = "Baggins",
                EmailAddress    = "goodmorning@shiremail.nz",
                CustomerTypeId  = 1
            },
            new Customer() {
                CustomerId      = 2,
                FirstName       = "Rosie",
                LastName        = "Cotton",
                EmailAddress    = "goodmorning@shiremail.nz",
                CustomerTypeId  = 2
            }
        };
    }
}
