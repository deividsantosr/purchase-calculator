using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PurchaseCalculator.Model;
using PurchaseCalculator.Service.Interfaces;

namespace PurchaseCalculator.Service
{
    public class StateService : IStateService
    {
        public State SelectState()
        {
            Console.WriteLine("Select your state (type the number):");

            for (int i = 0; i < State.All.Length; i++)
            {
                Console.WriteLine($"{i + 1} - {State.All[i].Name} ({State.All[i].TaxRate})");
            }

            int selectedIndex;

            do
            {
                Console.Write("\nState number: ");
            }
            while (!int.TryParse(Console.ReadLine(), out selectedIndex) || selectedIndex < 1 || selectedIndex > State.All.Length);

            State selectedState = State.All[selectedIndex - 1];

            Console.WriteLine($"\nYou selected: {selectedState.Name} ({selectedState.TaxRate})\n");

            return selectedState;
        }
    }
}
