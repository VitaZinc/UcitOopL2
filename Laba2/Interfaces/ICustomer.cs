using Laba2.Classes;
using Laba2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Laba2.Classes.Customer;

namespace Laba2.Interfaces
{
    interface ICustomer:IHuman
    {
        PaymentTypes PaymentMethod { get; }
    }
}
