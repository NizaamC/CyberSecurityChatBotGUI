# CyberSecurity Awareness Chatbot (POE Part 3)

## Student Information

- Student Name: nizaam hoosian 
- Student Number: ST10367051
- Module: Programming
- Project: CyberSecurity Awareness Chatbot (POE Part 3)

---

# Project Overview

The CyberSecurity Awareness Chatbot is a GUI-based desktop application developed in C# using WPF and XAML.

The purpose of the chatbot is to educate users about cybersecurity topics while providing interactive features such as task management, quizzes, reminders, activity logging, and Natural Language Processing (NLP) simulation.

The application helps users improve their cybersecurity awareness and encourages safe online practices.

---

# Features

## Part 1 Features

- Keyword recognition
- Dynamic chatbot responses
- Cybersecurity awareness tips
- Personalized responses
- Sentiment detection
- User memory functionality

---

## Part 2 Features

- GUI developed using WPF and XAML
- Modern chatbot interface
- Audio greeting on startup
- Enhanced chatbot interactions

---

## Part 3 Features

### Task Assistant

Users can:

- Add cybersecurity-related tasks
- View all tasks
- Delete tasks
- Mark tasks as completed
- Set reminders for tasks

Examples:

```text
Add task: Enable 2FA
Show tasks
Delete task: Enable 2FA
Complete task: Enable 2FA
Set reminder: Enable 2FA, 7
```

---

### Database Integration

The application uses MySQL to store tasks permanently.

Database information stored includes:

- Task Title
- Description
- Reminder Date
- Completion Status

---

### Cybersecurity Quiz

The chatbot includes a cybersecurity quiz that:

- Presents one question at a time
- Contains more than 10 questions
- Provides immediate feedback
- Tracks the user's final score

Example command:

```text
Start Quiz
```

---

### Natural Language Processing (NLP) Simulation

The chatbot recognises different user phrases using keyword detection and string matching.

Examples:

```text
I need to enable 2FA
Please update password
Review my privacy settings
```

The chatbot interprets these phrases and performs the correct action automatically.

---

### Activity Log

The chatbot records important actions performed by the user.

Examples:

- Task Added
- Task Deleted
- Task Completed
- Reminder Set
- Quiz Started
- Quiz Completed

Users can view the log by typing:

```text
Show activity log
```

or

```text
What have you done for me?
```

---

# Technologies Used

- C#
- WPF
- XAML
- .NET Framework
- MySQL
- MySQL Workbench
- Visual Studio 2022
- GitHub

---

# Database Setup

## Create Database

Open MySQL Workbench and execute the following SQL script:

```sql
CREATE DATABASE CyberSecurityBotDB;

USE CyberSecurityBotDB;

CREATE TABLE Tasks
(
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Title VARCHAR(100) NOT NULL,
    Description TEXT,
    ReminderDate DATETIME,
    IsCompleted BOOLEAN DEFAULT FALSE
);
```

---

## Update Connection String

Open:

```text
DatabaseManager.cs
```

Update the connection string if necessary:

```csharp
private string connectionString =
"server=localhost;database=CyberSecurityBotDB;uid=root;pwd=YOUR_PASSWORD;";
```

---

# How to Run the Application

1. Clone or download the repository.
2. Open the solution in Visual Studio 2022.
3. Ensure MySQL Server is running.
4. Create the database using the provided SQL script.
5. Update the MySQL connection string.
6. Build and run the project.

---



## Main Chatbot Interface



---

## Task Assistant



---

## Quiz Feature



---

## Activity Log


---

# Example Commands

```text
Add task: Enable 2FA
Show tasks
Delete task: Enable 2FA
Complete task: Enable 2FA
Set reminder: Enable 2FA, 7

Start Quiz

Show activity log

I need to enable 2FA
Please update password
```

---

# Future Improvements

Possible future enhancements include:

- Real-time notifications
- Email reminders
- AI-powered NLP
- User authentication
- Cloud database integration

---

# GitHub Repository

https://github.com/NizaamC/CyberSecurityChatBotGUI/edit/version-3

---

# Author
nizaam hoosian
ST0367051

CyberSecurity Awareness Chatbot POE - Final Submission
