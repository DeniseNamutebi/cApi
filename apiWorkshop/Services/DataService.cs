using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace apiWorkshop.Services
{
    public class DataService
    {
        List<Models.Customer> customers;

        public DataService()
        {
            customers = new List<Models.Customer>();

            customers.Add(new Models.Customer() { id = 1, firstName = "Ann", surname = "Droid", address = "12 Alopecia Avenue", email = "ann.droid@email.com", age = 25, subscribed = false });
            customers.Add(new Models.Customer() { id = 2, firstName = "Bob", surname = "Cat", address = "13 Boring Road", email = "bob.cat@email.com", age = 56, subscribed = true });
            customers.Add(new Models.Customer() { id = 3, firstName = "Cameron", surname = "Macaroon", address = "14 Camel Avenue", email = "cameronmac@email.com", age = 19, subscribed = true });
            customers.Add(new Models.Customer() { id = 4, firstName = "Derek", surname = "Domino", address = "15 Dinosaur Lane", email = "dominod@email.com", age = 67, subscribed = false });
            customers.Add(new Models.Customer() { id = 5, firstName = "Ernie", surname = "Bird", address = "16 Electric Avenue", email = "ernie@email.com", age = 32, subscribed = true });
            customers.Add(new Models.Customer() { id = 6, firstName = "Frank", surname = "Lee", address = "17 Farm Lane", email = "franklee@email.com", age = 34, subscribed = false });
            customers.Add(new Models.Customer() { id = 7, firstName = "Greg", surname = "Egg", address = "18 Giraffe Street", email = "gregg@email.com", age = 21, subscribed = true });
            customers.Add(new Models.Customer() { id = 8, firstName = "Helen", surname = "Back", address = "19 Hairy Road", email = "neleh@email.com", age = 31, subscribed = true });
            customers.Add(new Models.Customer() { id = 9, firstName = "Ivan", surname = "Driver", address = "20 Iceberg Lane", email = "vandriver.droid@email.com", age = 28, subscribed = false });
            customers.Add(new Models.Customer() { id = 10, firstName = "Jay", surname = "Walker", address = "21 Jumping Avenue", email = "jaywalker.droid@email.com", age = 22, subscribed = true });
            customers.Add(new Models.Customer() { id = 11, firstName = "Kay", surname = "Elemenopee", address = "22 Killer Lane", email = "klmnop@email.com", age = 56, subscribed = true });
            customers.Add(new Models.Customer() { id = 12, firstName = "Lee", surname = "Keypipe", address = "23 Louis Lane", email = "keypipe-plumbling@email.com", age = 82, subscribed = true });
            customers.Add(new Models.Customer() { id = 13, firstName = "Malcolm", surname = "Powder", address = "24 Malice Gardens", email = "m.powder@email.com", age = 74, subscribed = true });
            customers.Add(new Models.Customer() { id = 14, firstName = "Nora", surname = "Bone", address = "25 Naughty Lane", email = "nora.bone@email.com", age = 72, subscribed = false });
            customers.Add(new Models.Customer() { id = 15, firstName = "Oscar", surname = "Winner", address = "26 Orange Lane", email = "oscarwin@email.com", age = 25, subscribed = false });
            customers.Add(new Models.Customer() { id = 16, firstName = "Paul", surname = "Melegg", address = "27 Penguin Road", email = "melegg_paul@email.com", age = 35, subscribed = true });
        }

        public Models.Customer GetCustomer(int id)
        {
            //Gets a customer by id
            return customers.Where(x => x.id == id).First();
        }

        public Models.Customer UpdateCustomer(Models.Customer customer)
        {
            customer.firstName = customer.firstName.ToUpper();
            customer.surname = customer.surname.ToUpper();
            return customer;
        }

        public List<Models.Customer> ListCustomers()
        {
            return customers;
        }
       
    }
}
