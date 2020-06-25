using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfdtdSamples.Models
{
    public enum OrderStatus { None, New, Processing, Shipped, Received };

    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int IsMember { get; set; }
        public OrderStatus Status { get; set; }
    }
}
