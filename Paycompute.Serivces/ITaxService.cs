using System;
using System.Collections.Generic;
using System.Text;

namespace Paycompute.Serivces
{
    public interface ITaxService
    {
        decimal TaxAmount(decimal totalAmount);
    }
}
