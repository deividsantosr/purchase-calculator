# Purchase Calculator

A simple C# console application that calculates the total cost of a product based on the selected U.S. state and product type, applying tax rules according to the challenge specifications.

## 🛠 Features

- List of predefined U.S. states with individual tax rates
- Product selection with predefined prices
- Automatic calculation of total cost including tax
- Clean and structured code using models, services, and interfaces

## 🧪 How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/deividsantosr/purchase-calculator.git
   cd purchase-calculator
   ```

2. Open the project with **Visual Studio** or run with .NET CLI:
   ```bash
   dotnet run
   ```

## 📁 Project Structure

```
PurchaseCalculator/
├── Models/               # Domain models (Product, State)
├── Services/             # Business logic
│   └── Interfaces/       # Interfaces for service abstraction
├── Program.cs            # Entry point of the application
├── PurchaseCalculator.csproj
└── .gitignore
```

## 💡 Example

Input:

```bash
=== PURCHASE CALCULATOR ===

Select your state (type the number):
1 - California (0.08)
2 - Texas (0.08)
3 - New York (0.08)
4 - Florida (0.08)
5 - Washington (0.05)
6 - Oregon (0.05)
7 - Idaho (0.05)
8 - Utah (0.05)
9 - Montana (0.05)
10 - New Mexico (0.05)
11 - Arizona (0.05)
12 - Wyoming (0.05)
13 - Kansas (0.05)
14 - Arkansas (0.05)
15 - Georgia (0.05)
16 - Alabama (0.05)
17 - Lousiana (0.05)
18 - Alaska (0.00)
19 - Colorado (0.00)
20 - Delaware (0.00)
21 - Nevada (0.00)
22 - New Jersey (0.00)
23 - North Carolina (0.00)
24 - Ohio (0.00)
25 - Washington D.C (0.00)

State number: 3

You selected: New York (0.08)

Enter product details (or press ENTER to finish):
Enter product name: Computer
Enter product price: $200
Enter product name: Smartphone
Enter product price: $50
Enter product name: Keyboard
Enter product price: $15
Enter product name:
```

Output:

```bash
=== PURCHASE SUMMARY ===
Computer: $200.00
Smartphone: $50.00
Keyboard: $15.00

SUBTOTAL: $265.00
TAX: $21.20
TOTAL: $286.20
```


## 📌 Requirements

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)
- Visual Studio 2022+ or any C#-compatible IDE