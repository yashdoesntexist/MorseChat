# MorseChat

A real-time chat application built with **Blazor** and **ASP.NET Core**, featuring an optional **Morse code mode** for private, password-protected messages.

---

## 🚀 Tech Stack

* **Frontend:** Blazor (Server)
* **Backend:** ASP.NET Core (SignalR / WebSockets)
* **Database:** PostgreSQL
* **Cache / Pub-Sub:** Redis

---

## ✨ Features

* 🔐 User authentication (email & password)
* 💬 Real-time messaging using SignalR
* 🟢 Online / active user status
* ⌨️ Typing indicators
* 🔒 Secure Morse code mode:

  * Toggle messages into Morse code (`.-`)
  * Protected view requiring password to decode

---

## 🧠 Morse Mode

MorseChat allows users to send messages that can be viewed as Morse code for added privacy.

* Messages can be toggled between:

  * Plain text
  * Morse code
* Morse messages require authentication to decode

---

## ⚙️ Getting Started

### Prerequisites

* .NET SDK
* Docker
* PostgreSQL
* Redis

---

### 1. Clone the repository

```bash
git clone https://github.com/YOUR_USERNAME/MorseChat.git
cd MorseChat
```

---

### 2. Start infrastructure (PostgreSQL + Redis)

```bash
docker-compose up -d
```

---

### 3. Run the backend

```bash
cd src/MorseChat.Api
dotnet run
```

---

### 4. Run the frontend

```bash
cd src/MorseChat.Blazor
dotnet run
```

---

## 📌 Roadmap

* [ ] Message persistence
* [ ] End-to-end encryption
* [ ] Group chats
* [ ] Mobile responsiveness
* [ ] Push notifications

---

## 📖 License

This project is for learning and portfolio purposes.
