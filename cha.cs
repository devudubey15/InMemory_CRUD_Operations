using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise_by_maam
{
	internal class cha : IEmpployeeRepository
	{
		public static List<Employee> employeeslist;
		public cha()
		{
			employeeslist = new List<Employee>(){
				new Employee() { Id = 1234, Name = "ranvir", Salary = 90009.98, Address = "Auraiya, uttar pradesh" },
				new Employee() { Id = 2345, Name = "Aditya", Salary = 1234508, Address = "chhattisghar" },
				new Employee() { Id = 3456, Name = "ranvir2", Salary = 90009.98, Address = "Auraiya, uttar pradesh" },
				new Employee() { Id = 4567, Name = "Aditya2", Salary = 1234508, Address = "chhattisghar" }
				};
		}

		public Employee getemployee(int Id)
		{
			//FirstOrDefault() is a LINQ (Language Integrated Query) method that returns
			//the first element of a sequence that satisfies a specified condition, or a
			//default value if no such element is found.

			Employee empl;
			empl = employeeslist.FirstOrDefault(e => e.Id == Id);
			//here e represents  individual element within the collection

			return empl;
		}
		public IEnumerable<Employee> GetAllEmployee()
		{
			return employeeslist;
		}
		public Employee Add(Employee employee)
		{
			employee.Id = employeeslist.Max(e => e.Id) + 1;
			//
			//
			employeeslist.Add(employee);
			return employee;

		}
		public Employee Update(Employee employeechanges)
		{
			Employee employee = employeeslist.FirstOrDefault(e => e.Id == employeechanges.Id);
			if (employee != null)
			{
				employee.Id = employeechanges.Id;
				employee.Name = employeechanges.Name;
				employee.Salary = employeechanges.Salary;
				employee.Address = employeechanges.Address;
			}
			return employee;
		}
		public Employee Delete(int Id)
		{
			Employee empdel = employeeslist.FirstOrDefault(e => e.Id == Id);
			if (empdel != null)
			{
				employeeslist.Remove(empdel);
			}
			return empdel;
		}
		
	}
}
