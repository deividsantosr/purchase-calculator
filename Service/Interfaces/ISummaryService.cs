using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PurchaseCalculator.Model;

namespace PurchaseCalculator.Service.Interfaces
{
    public interface ISummaryService
    {
        void ShowPurchaseSummary(State selectedState, List<Product> cart);
    }
}
