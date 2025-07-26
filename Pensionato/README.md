# 🛏️ Pensionato - Room Rental CLI System

A C# console-based application that simulates a small guesthouse (pensionato) system. Users can rent rooms to clients, input personal data, and display occupied room information in a friendly, text-based interface.

---

## 📋 Features

- Initializes a virtual pensionato with 10 rooms
- User specifies how many rooms will be rented
- For each room: prompts for client's name and email
- Validates room number and email format
- Displays summary of all rented rooms
- Stylish terminal banner and logging system

---

## 🛠️ Technologies Used

- **.NET / C#** — Core development language  
- **Console Interface** — Interactive input/output  
- **Custom Logger** — Structured terminal messages with timestamp and color  
- **Modular OOP Design** — Classes for Room, Client, Email, Logging, Initialization, and Manager logic

---

## 🧠 Project Structure

```bash
Pensionato/
│
├── Program.cs # Entry point
├── Manager.cs # Application core logic
├── Models/
│ ├── Cliente.cs # Client data structure
│ ├── Email.cs # Email validation
│ └── Room.cs # Room assignment logic
├── Utils/
│ ├── Initialize.cs # Displays header and initializes session
│ └── Logger.cs # Color-coded logging utility
```

---

## 📦 Requirements

- [.NET SDK](https://dotnet.microsoft.com/en-us/download) (.NET 8 or newer)

---

## 🚀 Example Session

```bash
dotnet run
############################################################
#                    Pensão Dona Libania                   #
############################################################
v1.0.0
Autor: Lukas Lujan Moreira
Criado em: 26/07/2025

[INFO]: Manager initialized with 10 rooms available.
[INFO]: Pensionato application started.
[INFO]: How many rooms will be rented? 3

Please enter the number room: 1
Datas from Client.
Enter the client's name: João
Enter the client's email: joao@gmail.com

Room #1
Nome: João
Email: joao@gmail.com
Room: 1

[...]

```

🔒 Email Validation
Only accepts emails ending with:

	- @gmail.com
	- @yahoo.com
	- @hotmail.com

If not matched, displays as: Email inválido.

👤 Author
Lukas Lujan Moreira
Created on: 26/07/2025