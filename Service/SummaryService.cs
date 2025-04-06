using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PurchaseCalculator.Model;
using PurchaseCalculator.Service.Interfaces;

namespace PurchaseCalculator.Service
{
    public class SummaryService : ISummaryService
    {
        public void ShowPurchaseSummary(State selectedState, List<Product> cart)
        {
            decimal subtotal = cart.Sum(i => i.Cost);
            decimal tax = subtotal * selectedState.TaxRate;
            decimal total = subtotal + tax;

            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

            foreach (var item in cart)
            {
                Console.WriteLine($"{textInfo.ToTitleCase(item.Name)}: ${item.Cost:F2}");
            }

            Console.WriteLine($"\nSUBTOTAL: ${subtotal:F2}");
            Console.WriteLine($"TAX: ${tax:F2}");
            Console.WriteLine($"TOTAL: ${total:F2}");
        }
    }
}
