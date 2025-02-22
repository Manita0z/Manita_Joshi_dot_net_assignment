# Manita_Joshi_dot_net_assignment
This is an order tracking app made in ,net programming language 


 # Note: this repository is recreated since in previous repo there were non-updated and mostly mistake  file and screenshots of the outputs


# What I  did?
a) SSMS connection and server and Visual Studio-> view -> server explorer
b)Server->property->copied the connection string -> Pasted in appsetting.json->eneterd database name
c)created a model->Reviewers->included all necessary entities
d)scaffolded the model with identity->created new controller for Reviewers model->controller->MVC controllers with views, using Entity Framework
e)tools->NuGet Package Manager -> Add-Migration Initial Commit -> update-database
## Project Overview
The **Order Tracking System** is a web application developed using **.NET** to facilitate seamless order management. Users can create, track, and manage their orders while administrators can oversee operations efficiently.

What features I have added?
## Features

### 1. Home Page
- Overview of the system functionalities.
- Quick access to user dashboard and login/signup options.

### 2. User Authentication
- Secure login and signup functionality.
- Role-based access for users and administrators.

### 3. Order Management
- Create new orders with product details.

### 4. Dashboard
- Displays real-time order summaries.

### 5. Admin Panel
- Manage users, orders, and system settings.

### 6. Reports & Analytics
- Generate order reports based on date range.
- Analyze customer purchase trends.

### 7. Delivery Date Tracking
- Estimated delivery date displayed at order placement.
- Updates on actual delivery date for accurate tracking.

## Database Schema
- **Users**: Stores user credentials and roles.
- **Orders**: Stores order details, statuses, and timestamps.
- **Products**: Contains product listings available for order.
- **Delivery**: Tracks estimated and actual delivery dates.

## Technologies Used
- **Backend**: .NET (ASP.NET Core)
- **Frontend**: Razor Pages / MVC
- **Database**: Microsoft SQL Server
- **Tools**: Visual Studio, SSMS

## Installation & Setup
1. Clone the repository.
2. Configure the database in `appsettings.json`.
3. Run migrations: `dotnet ef database update`.
4. Start the application using `dotnet run`.

# Sample Images:
![Screenshot 2025-02-15 081123](https://github.com/Manita0z/Manita_Joshi_dot_net_assignment/blob/main/screenshots%20of%20the%20%20output/Screenshot%202025-02-15%20081123.png)
![Screenshot 2025-02-15 081209](https://github.com/Manita0z/Manita_Joshi_dot_net_assignment/blob/main/screenshots%20of%20the%20%20output/Screenshot%202025-02-15%20081209.png)
![Screenshot 2025-02-15 081520](https://github.com/Manita0z/Manita_Joshi_dot_net_assignment/blob/main/screenshots%20of%20the%20%20output/Screenshot%202025-02-15%20081520.png)
![Screenshot 2025-02-15 081531](https://github.com/Manita0z/Manita_Joshi_dot_net_assignment/blob/main/screenshots%20of%20the%20%20output/Screenshot%202025-02-15%20081531.png)
![Screenshot 2025-02-15 081545](https://github.com/Manita0z/Manita_Joshi_dot_net_assignment/blob/main/screenshots%20of%20the%20%20output/Screenshot%202025-02-15%20081545.png)
![Screenshot 2025-02-15 082005](https://github.com/Manita0z/Manita_Joshi_dot_net_assignment/blob/main/screenshots%20of%20the%20%20output/Screenshot%202025-02-15%20082005.png)
![Screenshot 2025-02-14 123740](https://github.com/Manita0z/Manita_Joshi_dot_net_assignment/blob/main/screenshots%20of%20the%20%20output/Screenshot%202025-02-14%20123740.png)
![Screenshot 2025-02-14 013653](https://github.com/Manita0z/Manita_Joshi_dot_net_assignment/blob/main/screenshots%20of%20the%20%20output/Screenshot%202025-02-14%20013653.png)
![Screenshot 2025-02-13 202830](https://github.com/Manita0z/Manita_Joshi_dot_net_assignment/blob/main/screenshots%20of%20the%20%20output/Screenshot%202025-02-13%20202830.png)
![Screenshot 2025-02-14 024123](https://github.com/Manita0z/Manita_Joshi_dot_net_assignment/blob/main/screenshots%20of%20the%20%20output/Screenshot%202025-02-14%20024123.png)
![Screenshot 2025-02-14 114001](https://github.com/Manita0z/Manita_Joshi_dot_net_assignment/blob/main/screenshots%20of%20the%20%20output/Screenshot%202025-02-14%20114001.png)
# After deleting data becomes
![Screenshot 2025-02-16 124316.png](https://github.com/Manita0z/Manita_Joshi_dot_net_assignment/blob/main/screenshots%20of%20the%20%20output/Screenshot%202025-02-16%20124316.png)
# table after editing
![Screenshot 2025-02-16 124406](https://github.com/Manita0z/Manita_Joshi_dot_net_assignment/blob/main/screenshots%20of%20the%20%20output/Screenshot%202025-02-16%20124406.png)
## Conclusion
This project streamlines order management and improves tracking accuracy, making it an essential tool for businesses managing multiple orders.
