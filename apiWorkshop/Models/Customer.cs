using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiWorkshop.Models
{
    public class Customer
    {
        public int id { get; set; }

        public string firstName { get; set; }

        public int age { get; set; }

        public string surname { get; set; }

        public string email { get; set; }

        public string address { get; set; }

        public bool subscribed { get; set; }

    }
}
//definiton of how you server looks