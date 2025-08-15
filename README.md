# SOLID-Principles-Demo-CSharp
A C# console application demonstrating all 5 SOLID principles in a simple online order management system.
## Features

- **Single Responsibility Principle (SRP)**: `Product` and `Order` classes handle separate responsibilities.  
- **Open/Closed Principle (OCP)**: Flexible discount system (`FixedDiscount`, `PercentageDiscount`).  
- **Liskov Substitution Principle (LSP)**: Payment types (`MobileBankingPayment`, `EWalletPayment`) can be substituted without breaking the program.  
- **Interface Segregation Principle (ISP)**: Small, focused interfaces for order processing and invoice generation.  
- **Dependency Inversion Principle (DIP)**: `OrderService` depends on an `IPayment` abstraction rather than concrete payment classes.

## How to Run

1. Clone the repository:
git clone https://github.com/Sushant-bidari/SOLID-Principles-Demo-CSharp.git
2. Open the project in Visual Studio 2022 (or later).
3. Build and run the project. You will see demonstrations of all 5 SOLID principles in the console output.

Author
Sushant Bidari
