# 🛡️ CyberSecurity Chatbot (WPF Desktop Application)

## 📌 Project Overview
The CyberSecurity Chatbot is a Windows desktop application developed using C# and WPF (.NET).  
It is designed to provide users with basic cybersecurity awareness through interactive, keyword-driven conversations.

The system simulates a chatbot experience by interpreting user input and returning contextually relevant security advice, greetings, and fallback responses when input is not recognized.

This project demonstrates the implementation of layered architecture, event-driven programming, and basic natural language pattern matching in a desktop environment.

---

## 🎯 Project Objectives
- Develop an interactive chatbot using C# and WPF
- Provide basic cybersecurity awareness to users
- Implement keyword-based response handling
- Apply separation of concerns (UI vs logic layer)
- Build a maintainable and scalable application structure

---

## ⚙️ Key Features
- 💬 Interactive chat interface (WPF UI)
- 🔐 Cybersecurity-focused responses (password safety, phishing awareness, etc.)
- 🧠 Keyword recognition system for input processing
- 🔄 Randomized responses for natural interaction feel
- ⚠️ Default fallback response for unknown inputs
- 🧩 Modular architecture (UI layer + logic layer separation)

---

## 🧠 System Design & Architecture

The application follows a **layered architecture approach**:

### 1. Presentation Layer (UI)
- Built using `MainWindow.xaml`
- Handles user interaction (input/output)
- Sends user messages to backend logic
- Displays chatbot responses in chat window

### 2. Logic Layer
- Contains core chatbot functionality:
  - `Chatbot.cs` → Main processing engine
  - `ResponseManager.cs` → Handles keyword-response mapping
  - `MemoryStore.cs` → Stores conversation or contextual data

### 3. Event Flow
1. User enters message in input box  
2. Clicks “Send” button  
3. Input is passed to chatbot logic  
4. Keyword matching is performed  
5. Response is returned and displayed in UI  

---

## 🧩 Core Functionality

### 🔹 Keyword-Based Response System
User inputs are matched against a dictionary of predefined keywords.

Example:
- Input: `"hello"`
- Output: `"Hi there! Need cybersecurity help?"`

- Input: `"password"`
- Output: `"Use strong passwords with numbers and symbols."`

---

### 🔹 Fallback Handling
If the input does not match any known keyword, the system responds with:
> "I'm not sure about that. Try asking about cybersecurity tips like passwords or phishing."

---

## 🏗️ Project Structure

## 🧪 How to Run the Project

1. Clone the repository:
```bash
git clone https://github.com/Kcleophas/CybersecurityChatbot.git 
