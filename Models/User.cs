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
        public DateTime CreatedAt { get; private set; }
        public decimal Founds { get; private set; }

        public User(string email, string password)
        {
            SetEmail(email);
            SetPassword(password);
            CreatedAt=DateTime.Now;
        }

        private void SetEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new Exception("Incorrect e-mail address.");
            }
            if (Email == email)
            {
                return;
            }
            Email = email;
            UpdateProperty();
        }

        private void SetPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new Exception("Entered password can't has white space or be null.");
            }
            if (password.Length < 8)
            {
                throw new Exception("Entered password is too short.");
            }
            if (password.Equals(Password))
            {
                throw new Exception("Entered password is this same like previous password. Please enter other password.");
            }
            if (Password == password)
            {
                return;
            }
            Password = password;
            UpdateProperty();
        }

        public void Activate()
        {
            if (IsActive)
            {
                return;
            }
            IsActive = true;
            UpdateProperty();
        }

        public void Deactivate()
        {
            if (!IsActive)
            {
                return;
            }
            IsActive = false;
            UpdateProperty();
        }

        public void SetAge(int age)
        {
            if (age <= 13)
            {
                throw new Exception("User must have greater than thirteen years old.");
            }
            Age = age;
            UpdateProperty();
        }
        public void IncreaseFunds(decimal founds)
        {
            if (founds <= 0)
            {
                throw new Exception("Funds must be greater than 0.");
            }
            Founds += founds;
            UpdateProperty();
        }

        public void PurchaseOrder(Order order)
        {
            if(!IsActive)
            {
                throw new Exception("Only active user can purchase an order.");
            }
            if(order.TotalPrice>Founds)
            {
                throw new Exception("You don't have enough money.");
            }
            order.Pucharse();
            Founds-=order.TotalPrice;
        }
        private void UpdateProperty()
        {
            UpdateAt = DateTime.Now;
        }
    }
}