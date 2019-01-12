using Laba2.Interfaces;
using Laba2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2.Classes
{

    class Customer : Human
    {
        PaymentTypes PaymentMethod { get; }

        public Customer(string name, string phone, string email, PaymentTypes paymentMethod):base(name, phone, email)
        {
            PaymentMethod = paymentMethod;
        }

        public override string ToString() => $"{base.ToString()}, Способ оплаты: {PaymentMethod}";
    }
}
