# DoctorAppointment

**DoctorAppointment** is a Windows Forms (WinForms) desktop application built using C# and Visual Studio. The system is designed to manage doctor appointment scheduling, providing an interface for patients, doctors, and administrators to interact with and manage medical appointments efficiently.

---

## 🩺 Features

- Patient registration and login
- Doctor profile management
- Appointment scheduling and cancellation
- Admin panel to manage users and appointments
- Local image resource usage
- Integrated with a SQL Server database (`.bacpac` format included)

---

## 📁 Project Structure

---

DoctorAppointment/
├── DoctorAppointment/         # Main C# project source code
├── Database/                  # Database backup (.bacpac)
├── Images/                    # Static image assets
├── DoctorAppointment.sln      # Visual Studio solution file
├── Read Me.txt                # Supplementary info (legacy)
└── .vs/                       # Visual Studio config files (ignore in version control)

---

---

## 🧰 Requirements

- Visual Studio 2019 or later (Community Edition is fine)
- .NET Framework (version compatible with your environment)
- SQL Server (for restoring the `.bacpac` database)

---

## 🚀 Getting Started

### 1. Clone the Repository

---bash
git clone https://github.com/your-username/DoctorAppointment.git
cd DoctorAppointment
---

### 2. Open the Solution

* Open `DoctorAppointment.sln` in Visual Studio.

### 3. Restore the Database

* Use **SQL Server Management Studio (SSMS)** to import `drappointment.bacpac` located in the `Database/` folder.

### 4. Build and Run

* Set `DoctorAppointment` as the startup project.
* Press `F5` or click **Start** to run the application.

---


## 📄 License

This project is licensed under the [MIT License](LICENSE). Feel free to use, modify, and distribute.

---

## 👤 Author

Rashedul Islam Refat
GitHub: https://github.com/rashedrefat

---

## 🙌 Contributions

Contributions, issues, and feature requests are welcome! Feel free to fork the repository and submit a pull request.

---
