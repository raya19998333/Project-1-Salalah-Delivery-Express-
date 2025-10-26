<h1 align="center">🚚 Project 1 — Salalah Delivery Express</h1>

<p align="center">
  <img src="https://img.shields.io/badge/Status-Completed-success?style=for-the-badge" alt="Status">
  <img src="https://img.shields.io/badge/Language-C%23-blue?style=for-the-badge" alt="C#">
  <img src="https://img.shields.io/badge/Concepts-OOP%2C%20Classes%2C%20Lists%2C%20Enum-lightgrey?style=for-the-badge" alt="Concepts">
  <img src="https://img.shields.io/badge/Author-Raya_Al_Amri-blueviolet?style=for-the-badge" alt="Author">
</p>

---

## 🗂️ Table of Contents
- [📖 Story](#-story)
- [👨‍💻 System Components](#-system-components)
- [🧩 Features](#-features)
- [💻 Code Structure](#-code-structure)
- [⚙️ Technologies Used](#️-technologies-used)
- [👩🏻‍💻 Author](#-author)

---

## 📖 Story
A small local delivery company in the **Salalah Industrial Area** struggled to manage delivery requests efficiently.  

This project demonstrates a **console-based C# application** to track:  
- **Customers**  
- **Drivers**  
- **Deliveries with status**  

Each delivery has:  
- **Customer**  
- **Driver**  
- **Status:** `"Pending"`, `"On The Way"`, `"Delivered"`  

**Rules:**  
- Drivers can handle multiple deliveries  
- Each delivery is assigned to **one driver only**

---

## 👨‍💻 System Components
<div style="background-color:#f0f4f8; padding:10px; border-radius:8px;">
<b>Customer</b>: Stores customer name and address. <br>
<b>Driver</b>: Stores driver name, phone, and list of assigned deliveries. <br>
<b>Delivery</b>: Links a customer with a driver and tracks delivery status. <br>
<b>DeliveryStatus (Enum)</b>: Pending, OnTheWay, Delivered. <br>
</div>

---

## 🧩 Features
- Add new **drivers** and **customers**  
- Create **delivery requests** and assign them to a driver  
- Update **delivery status** dynamically  
- Display **all deliveries** for a specific driver or customer  
- Console interface with structured output for clarity  

---

## 💻 Code Structure

### 1️⃣ Enum: `DeliveryStatus`
```csharp
enum DeliveryStatus { Pending, OnTheWay, Delivered }
