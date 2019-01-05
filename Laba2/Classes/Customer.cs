using Laba2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2.Classes
{

    public enum PaymentType
    {
        Cash,
        Card,
        Promises
    }
    class Customer : Human, ICustomer
    {

        PaymentType PaymentMethod { get; set; }


        public Customer(string name, string phone, string email, PaymentType paymentMethod):base(name, phone, email)
        {
            PaymentMethod = paymentMethod;
        }

        public override string Print()
        {
            return $"{base.Print()}, Способ оплаты: {PaymentMethod}";
        }
    }
}
