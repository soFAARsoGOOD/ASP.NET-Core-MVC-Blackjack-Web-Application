# 🃏 ASP.NET Core MVC Blackjack Web Application

A professional web application that implements a classic **Blackjack card game** built on the **ASP.NET Core MVC framework**. It features dependency injection for decoupled game engine operations and utilizes `TempData` to manage flash state notifications across stateless HTTP post-back loops.

---

## 📋 Table of Contents
- [About the Project](#-about-the-project)
- [Key Features](#-key-features)
- [Built With](#-built-with)
- [Architecture Details](#-architecture-details)
- [Getting Started](#-getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation & Execution](#installation--execution)
- [Game Engine Rules Workflow](#-game-engine-rules-workflow)
- [License](#-license)
- [Contact](#-contact)

---

## 🔍 About the Project

This web-based card game leverages an asynchronous MVC model structure. The `HomeController` manages user interactions—dealing cards, hitting, or standing—by mapping UI post actions directly to an interchangeable `IGame` simulation framework.

### Game State Outcomes Tracked
* **Blackjacks:** Automatic wins or pushes on matching starting indices.
* **Bust States:** Conditional assessment if standard threshold counts override target rules (exceeding 21).
* **Dealer Automated Turns:** Iterative calculations handled over a stateless callback framework.
* **Shoe Management:** Integrated deck maintenance indicators that flash notification banners when the shoe needs to be re-shuffled.

---

## ✨ Key Features

* **Injected Engine Lifecycle:** Fully utilizes ASP.NET Core **Dependency Injection (DI)** by binding operations cleanly to an abstract `IGame` contract interface.
* **Dynamic Notifications UI:** Pairs layout notification messages alongside specialized CSS class strings (`danger`, `success`, `info`) via volatile state dictionaries (`TempData`).
* **Clean HTTP Actions Structure:** Uses strict `[HttpPost]` action handlers to secure state manipulation, feeding back to view files via uniform post-back redirects (`RedirectToAction`).
* **Console Trace Auditing:** Employs explicit diagnostics pipelines to map action handler execution steps in real time.

---

## 🛠️ Built With

| Technology | Purpose | Documentation |
| :--- | :--- | :--- |
| **C# 12 / 11** | Core Programming Language | [://microsoft.com](https://microsoft.com) |
| **ASP.NET Core MVC** | Web Application Architecture Grid | [://microsoft.com](https://microsoft.com) |
| **.NET SDK** | Compilation & App Execution Runtime | [/dotnet](https://microsoft.com) |

---

## 🏗️ Architecture Details

The program uses the following controller design:

* **`Index()` (GET):** Standard execution landing step that passes the active instance of `game` down to render your primary View.
* **`Deal()` (POST):** Instantiates round settings, parsing natural start configurations or pushing multi-blackjack notifications.
* **`Hit()` (POST):** Appends single items onto active player data and screens for sudden over-limit flags.
* **`Stand()` (POST):** Evaluates ongoing card requirements or finishes automated matching logic to score the ultimate round winner.

---

## 🚀 Getting Started

Follow these steps to build and run the application locally on your computer.

### Prerequisites
* Ensure you have the **.NET SDK** (v8.0 or v9.0) installed.
* An IDE such as **Visual Studio 2022**, **Visual Studio Code**, or **JetBrains Rider**.

### Installation & Execution

1. **Clone the Repository**
   ```bash
   git clone https://github.com
   cd blackjack-mvc
   ```

2. **Restore Dependencies**
   ```bash
   dotnet restore
   ```

3. **Run the Application**
   ```bash
   dotnet run
   ```
   *The terminal console will display local hosting URLs (e.g., `http://localhost:5000` or `https://localhost:5001`). Open these addresses inside your web browser to play.*

---

## 📊 Game Engine Rules Workflow

The application evaluates game states returned by the domain layer and matches them to specific dynamic visual themes:

| Game Result | Message Dispatched | Visual Theme |
| :--- | :--- | :--- |
| `PlayerBlackJack` | "Blackjack! You win!" | **Success** (Green) |
| `DealerBlackJack` | "Dang! Dealer got a Blackjack! You lose." | **Danger** (Red) |
| `PlayerBust` | "BUST! You lose." | **Danger** (Red) |
| `DealerBust` | "Dealer BUST! You win!" | **Success** (Green) |
| `Shuffling` | "Shuffling. Press [Action] to continue." | **Info** (Blue) |
| `Continue` | "Dealer needs another card. Hit Stand to continue." | **Info** (Blue) |

---

## 📄 License

Distributed under the **MIT License**.

---

## ✉️ Contact
* **Author:** Jarrion Harris  
* **Development Date:** October 2024  
* **Project Link:** [https://github.com](https://github.com)
