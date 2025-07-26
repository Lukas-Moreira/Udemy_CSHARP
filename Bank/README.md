# 💳 Bank CLI System

This is a simple **C# console application** that simulates basic operations of a bank account system. It allows users to create an account, perform deposits and withdrawals, and view account information — all via an interactive terminal interface.

---

## 📋 Features

- Create a bank account with or without an initial deposit  
- Deposit money multiple times  
- Perform withdrawals (with a fixed $5 fee)  
- View account data at any time  
- Custom terminal display with styled messages and banners

---

## 🛠️ Tools & Technologies

- **.NET Core / C#** — Programming language and runtime  
- **Console Application** — Lightweight CLI interface  
- **Custom Logger** — Provides formatted terminal messages (info, success, warnings, errors)  
- **Structured Classes** — Split into:
  - `Program.cs` – Entry point and main flow control
  - `Initialize.cs` – Handles user input and display banner
  - `Manager.cs` – Core business logic (deposit, withdrawal, display)
  - `Logger.cs` – Colored logging for user feedback

---

## 🧠 Project Structure

```bash
Bank/
│
├── Program.cs # Main application loop
├── Utils/
│ ├── Initialize.cs # Initializes the user and account
│ └── Logger.cs # Colored message system
├── Entities/
  └── Manager.cs # Core banking operations


---

## 🧪 Example Usage

```bash
# Run the program
dotnet run

# Output (simplified):
############################################
#      Banco Central Individual (v1.0)     #
############################################
Author: Lukas Lujan Moreira
Created: 26/07/2025

Enter account number: 123
Enter account holder: John Doe
Initial deposit (y/n)? y
Enter deposit amount: 200
Make another deposit (y/n)? n
Make a withdrawal (y/n)? y
Enter withdrawal amount: 50

[Logger]: Withdrawal successful!
Account data: Account 123, John Doe, Balance: $145.00
