# In Memory CRUD

## Overview

The "In Memory CRUD" project is a demonstration of basic CRUD (Create, Read, Update, Delete) operations implemented in C# for managing employee records in an in-memory database. The application provides a straightforward example of how to interact with data using an interface, `IEmployeeRepository`, and its corresponding implementation class, `cha`.

## Project Structure

- **cha.cs**: Implementation of the `IEmployeeRepository` interface, containing a list of employees stored in memory and methods for CRUD operations.
- **Program.cs**: Entry point of the application, showcasing the usage of `cha` methods for CRUD operations.
- **IEmpployeeRepository.cs**: Interface defining the contract for interacting with employee data.

## Usage

1. **Get Employee by ID**
    ```csharp
    Employee employee = cha.getemployee(1234);
    Console.WriteLine("Employee details: " + employee);
    ```

2. **Get All Employees**
    ```csharp
    foreach (Employee employee in cha.GetAllEmployee())
    {
        Console.WriteLine("Employee details: " + employee);
    }
    ```

3. **Add Employee**
    ```csharp
    Employee newEmployee = new Employee() { Id = 99980, Name = "king", Salary = 900098, Address = "Rajsthan, India" };
    Employee addedEmployee = cha.Add(newEmployee);
    Console.WriteLine("Added Employee details: " + addedEmployee);
    ```

4. **Update Employee**
    ```csharp
    Employee updatedEmployee = cha.Update(new Employee() { Id = 4567, Name = "kohli", Salary = 9000998, Address = "delhi, India" });
    Console.WriteLine("Updated Employee details: " + updatedEmployee);
    ```

5. **Delete Employee by ID**
    ```csharp
    Employee deletedEmployee = cha.Delete(3456);
    Console.WriteLine("Deleted Employee details: " + deletedEmployee);
    ```

6. **Additional Query Example**
    ```csharp
    // Example of querying employees with a specific address
    foreach (Employee employee in from i in cha.employeeslist where i.Address == "Auraiya, uttar pradesh" select i)
    {
        Console.WriteLine("Filtered Employee details: " + employee);
    }
    ```

## How to Run

1. Clone the repository to your local machine.
2. Open the solution in Visual Studio or any C# IDE.
3. Build and run the project.

## Notes

- This project serves as a basic example of in-memory CRUD operations and does not persist data beyond the application's lifetime.
- Feel free to extend and modify the code for more complex scenarios or integrate with a database for persistent storage.

## Contributions

Contributions are welcome! Feel free to explore, modify, and use this project as a foundation for your own C# CRUD applications. If you encounter any issues or have suggestions for improvement, please open an issue or submit a pull request.
