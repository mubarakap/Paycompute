using System;
using System.Collections.Generic;
using System.Text;

namespace Paycompute.Serivces
{
    public interface INationalInsuranceCountributionService
    {
        decimal NIContribution(decimal totalAmount);
    }
}
