using System.Globalization;
using PurchaseCalculator.Model;
using PurchaseCalculator.Service;
using PurchaseCalculator.Service.Interfaces;

namespace PurchaseCalculator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            IStateService stateService = new StateService();
            IProductService productService = new ProductService();
            ISummaryService summaryService = new SummaryService();

            Console.WriteLine("=== PURCHASE CALCULATOR ===\n");

            State selectedState = stateService.SelectState();
            List<Product> cart = productService.AddProducts();

            Console.WriteLine("\n=== PURCHASE SUMMARY ===");
            summaryService.ShowPurchaseSummary(selectedState, cart);
        }
    }
}