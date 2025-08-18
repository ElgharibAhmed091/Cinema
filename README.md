# Cinema Web Application

A web-based cinema management system built using **ASP.NET Core MVC** with features for user management, movie catalog, shopping cart, and Stripe payment integration.

---

## Features

* User registration and login using **ASP.NET Core Identity**.
* Role management: Admin and User.
* Movie catalog with CRUD operations.
* Shopping cart for selecting movies.
* Stripe payment integration for online checkout.
* Dashboard for Admin to view statistics:

  * Total movies
  * Total users
  * Total orders
  * Latest orders and order details
* Email confirmation and user account management.
* Responsive UI with Bootstrap.

---

## File Structure

```
Cinema/
│
├─ Controllers/
│   ├─ AccountController.cs      # User registration, login, authentication
│   ├─ MovieController.cs        # CRUD operations for movies
│   ├─ CartController.cs         # Shopping cart management
│   ├─ PaymentController.cs      # Stripe payment integration
│   ├─ DashboardController.cs    # Admin dashboard
│
├─ Models/
│   ├─ ApplicationUser.cs        # Identity user
│   ├─ Movie.cs                  # Movie model
│   ├─ CartItem.cs               # Cart item model
│   ├─ Order.cs                  # Order model
│   ├─ OrderItem.cs              # Order item model
│
├─ Data/
│   ├─ AppDbContext.cs           # Entity Framework Core DbContext
│
├─ Views/
│   ├─ Account/                  # Login, Register, etc.
│   ├─ Movie/                    # Index, Create, Edit, Details, Delete
│   ├─ Cart/                     # Cart index
│   ├─ Payment/                  # Success.cshtml, Cancel.cshtml
│   ├─ Dashboard/                # Admin dashboard
│
├─ wwwroot/
│   ├─ css/
│   ├─ js/
│   ├─ images/
│
├─ appsettings.json               # Database connection and Stripe keys
├─ Program.cs                     # ASP.NET Core setup
└─ README.md                      # Project documentation
```

---

## Setup Instructions

1. **Clone the repository:**

```bash
git clone <repository-url>
cd Cinema
```

2. **Configure database:**

* Open `appsettings.json`
* Set your SQL Server connection string:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=CinemaDB;Trusted_Connection=True;"
}
```

3. **Apply migrations and create database:**

```bash
dotnet ef database update
```

4. **Configure Stripe keys in `appsettings.json`:**

```json
"Stripe": {
  "SecretKey": "your-secret-key",
  "PublishableKey": "your-publishable-key"
}
```

5. **Run the application:**

```bash
dotnet run
```

6. **Access the app:**

* User: Register and login
* Admin: Use the dashboard for managing movies and viewing orders.

---

## Technologies Used

* ASP.NET Core MVC
* Entity Framework Core
* ASP.NET Core Identity
* Stripe Payment Gateway
* Bootstrap 5
* SQL Server

---

## Notes

* Only Admin users can access the dashboard.
* Orders are linked to users and cart items.
* Make sure to seed admin user or create one manually.

![Cinema Screenshot](https://github.com/user-attachments/assets/4c8d8be9-f9c0-4942-9303-3ef812a5c379 "Cinema App Screenshot")
