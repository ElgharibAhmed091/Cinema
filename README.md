![Cinema Screenshot](https://github.com/user-attachments/assets/4c8d8be9-f9c0-4942-9303-3ef812a5c379 "Cinema App Screenshot")

# Cinema Management System

A full-featured cinema management system developed with ASP.NET Core MVC and Web API, offering a complete backend and dashboard for managing movies, cinemas, producers, actors, orders, users, and online payments.

## Tech Stack

* **Backend:** ASP.NET Core MVC & Web API (.NET 8)
* **Database:** Entity Framework Core (EF Core)
* **Authentication & Authorization:** JWT, Role-based access
* **Payment:** Stripe API (with webhooks for transaction confirmation)
* **Tools:** AutoMapper, Swagger, Postman

## Features

* **User Management:** Registration, login, role assignment (Admin, User).
* **Movie Management:** CRUD operations for movies, producers, and actors.
* **Cinema Management:** Add and manage cinemas, showtimes, and seating.
* **Shopping Cart:** Add movies or tickets to cart and process checkout.
* **Orders:** Track and manage user orders, order items, and revenue.
* **Online Payments:** Secure integration with Stripe API.
* **Dashboard:** Admin dashboard displaying stats like movies, users, orders, revenue, and latest transactions.

## Project Structure

```
Cinema/
├─ Controllers/
├─ Models/
├─ Views/
├─ wwwroot/
└─ Program.cs / Startup.cs
```

## How to Run

1. Clone the repository:

```bash
git clone https://github.com/ElgharibAhmed091/Cinema.git
```

2. Navigate to the project folder and restore packages:

```bash
cd Cinema
dotnet restore
```

3. Apply database migrations:

```bash
dotnet ef database update
```

4. Run the project:

```bash
dotnet run
```

5. Open the app in your browser: `https://localhost:5001`

## Additional Notes

* Admin dashboard allows management of users, roles, movies, and orders.
* JWT authentication ensures secure endpoints for sensitive actions.
* Stripe integration includes webhook verification for payment confirmation.

---

**#CinemaManagement #ASPNetCore #EFCore #Stripe #JWT #AdminDashboard #EcommerceBackend #DotNet8**


![Cinema Screenshot]<img width="1812" height="898" alt="image" src="https://github.com/user-attachments/assets/d535b6b6-52da-4032-80f4-0c392fc5784e" />
