using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_by_maam
{
	public interface IEmpployeeRepository
	{
		Employee getemployee(int Id);
		IEnumerable<Employee> GetAllEmployee();
		Employee Add(Employee employee);
		Employee Update(Employee employeechanges);
		Employee Delete(int Id);
	}
}
