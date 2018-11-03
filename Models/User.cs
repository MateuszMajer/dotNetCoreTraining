using System;

namespace NET_Core_Training.Models
{
    public class User
    {
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; private set; }
        public bool IsActive { get; private set; }
        public DateTime UpdateAt { get; private set; }
        public decimal Founds { get; private set; }
    }
}