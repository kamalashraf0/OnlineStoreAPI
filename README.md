# Online Store Management API

## Overview

The **Online Store Management API** is a fully functional Web API designed to manage an online store's products, customers, and orders. This API adheres to best practices in web development, including robust security measures, performance optimization, and comprehensive documentation.

## Table of Contents

- [Features](#features)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
  - [Configuration](#configuration)
- [Usage](#usage)
  - [Endpoints](#endpoints)
  - [API Documentation](#api-documentation)
- [Testing](#testing)
- [Security](#security)
- [Contributing](#contributing)
- [License](#license)

## Features

- **CRUD Operations**: Manage products, customers, and orders with full CRUD functionality.
- **Authentication**: Secure endpoints using JWT tokens.
- **API Key Validation**: Middleware to validate API keys.
- **Request Logging**: Middleware to log all incoming requests.
- **Comprehensive Validation**: Input validation for data integrity.
- **Data Validation**: Ensures input data integrity and validity.
- **Performance Optimization**: Efficient handling of concurrent requests.
- **Swagger Documentation**: Auto-generated documentation for ease of use.

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Postman](https://www.postman.com/downloads) (for testing API endpoints)

### Installation

1. **Clone the Repository**:
    ```bash
    git clone https://github.com/yourusername/online-store-management-api.git
    ```

2. **Navigate to the Project Directory**:
    ```bash
    cd online-store-management-api
    ```

3. **Restore Dependencies**:
    ```bash
    dotnet restore
    ```
### Configuration

4. **Update the Connection String**:
    Modify `appsettings.json` to include your SQL Server connection string:
    ```json
    "ConnectionStrings": {
      "DefaultConnection": "Server=your_server;Database=your_database;User Id=your_user;Password=your_password;"
    }
    ```

5. **Apply Migrations**:
    ```bash
    update-database
    ```

6. **Run the Application**:
    ```bash
    dotnet run
    ```

## Usage

### Endpoints

- **Products**
  - `GET /api/products` - Retrieve all products.
  - `GET /api/products/{id}` - Retrieve a product by ID.
  - `POST /api/products` - Add a new product.
  - `PUT /api/products/{id}` - Update an existing product.
  - `DELETE /api/products/{id}` - Delete a product.

- **Customers**
  - `GET /api/customers` - Retrieve all customers.
  - `GET /api/customers/{id}` - Retrieve a customer by ID.
  - `POST /api/customers` - Add a new customer.
  - `PUT /api/customers/{id}` - Update an existing customer.
  - `DELETE /api/customers/{id}` - Delete a customer.

- **Orders**
  - `GET /api/orders` - Retrieve all orders.
  - `GET /api/orders/{id}` - Retrieve an order by ID.
  - `POST /api/orders` - Add a new order.
  - `PUT /api/orders/{id}` - Update an existing order.
  - `DELETE /api/orders/{id}` - Delete an order.

### API Documentation

For detailed API documentation, navigate to [Swagger UI](http://localhost:5000/swagger) once the application is running. It includes information on endpoints, required parameters, and possible responses.

## Testing

### Postman Collection

A Postman collection is included in the `Postman_Collection` folder. Import this collection into Postman to test the API endpoints.

## Security

- **JWT Authentication**: Secures endpoints and ensures only authorized access.
- **API Key Validation**: Verifies the presence and validity of API keys.
- **Data Validation**: Ensures all input data is validated before processing.

## Contributing

Contributions are welcome! If you have suggestions or improvements, please follow these steps:

1. **Fork the repository**.
2. **Create a new branch**:
    ```bash
    git checkout -b feature/your-feature
    ```
3. **Commit your changes**:
    ```bash
    git commit -am 'Add new feature'
    ```
4. **Push to the branch**:
    ```bash
    git push origin feature/your-feature
    ```
5. **Create a new Pull Request**.

## License

This project is licensed under the MIT License.
