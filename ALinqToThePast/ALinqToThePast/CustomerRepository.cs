using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ALinqToThePast {
    public class CustomerRepository {
        public Customer Find (List<Customer> customerList, int customerId) {
            Customer foundCustomer = null;
          
            //foreach (var customer in customerList) {
            //    if (customer.CustomerId == customerId) {
            //        foundCustomer = customer;
            //        break;
            //    }
            //}

            //var query = from customer in customerList
            //            where customer.CustomerId == customerId
            //            select customer;

            //foundCustomer = query.First();

            //foundCustomer = customerList.FirstOrDefault(c => c.CustomerId == customerId);

            //foundCustomer = customerList.FirstOrDefault(c => {
            //    Debug.WriteLine(c.LastName);
            //    return c.CustomerId == customerId;
            //});


            //Transversal operation
            foundCustomer = customerList.Where(c => c.CustomerId == customerId)
                                .Skip(0)
                                .FirstOrDefault();

            return foundCustomer;
        }

        public List<Customer> Retrieve () {
            return new List<Customer> {
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
}
