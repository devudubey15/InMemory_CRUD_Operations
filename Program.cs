using Exercise_by_maam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


//create a database HR with table Employee having column name Id, Name, Salary, Adderess.
//create Interface  IEmployeeRepository
//with functions:
//Employee getemployee(int Id);
//Inumarable<Employee> GetAllEmployee();
//Employee Add(Emploee employee);
//Employee Update(Employee employeechanges);
//Employee Delete(int Id);


//.create class which will implements IEmployeeRepository.
//.in Entry class call the methods and complete CRUD.


namespace Exercise_by_maam
{
	internal class Program
	{
		static void Main(string[] args)
		{
			cha cha = new cha();
			Console.WriteLine("calling GetEmloyee" + cha.getemployee(1234));

			foreach (Employee b in cha.GetAllEmployee())
			{
				Console.WriteLine("calling GetAllEmloyee()" + b);
			}
			Console.WriteLine("calling Add function"+ cha.Add(new Employee() { Id = 99980, Name = "king", Salary = 900098, Address = "Rajsthan, India" }));
			Console.WriteLine("calling update" + cha.Update(new Employee() {  Id = 4567, Name = "kohli", Salary = 9000998, Address = "delhi, India"  }));
			Console.WriteLine("calling Delete"+ cha.Delete(3456));
			foreach (Employee b in cha.GetAllEmployee())
			{
				Console.WriteLine("calling GetAllEmloyee()" + b);
			}

			foreach (Employee b in from i in cha.employeeslist where  i.Address == "Auraiya, uttar pradesh" select i)
			{
				Console.WriteLine("jalwa hai"+ b);
			}
			Console.ReadKey();
		}
	}
}
