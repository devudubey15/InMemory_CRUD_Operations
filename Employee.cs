using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//table Employee having column name Id, Name, Salary, Adderess

namespace Exercise_by_maam
{
	public class Employee 
	{
		

		public int Id { get; set; }
		public string Name { get; set; }
		public double Salary { get; set; }
		public string Address { get; set; }

		public override string ToString()
		{
			return string.Format($"ID: {Id} name: {Name} salary:{Salary} address: {Address}");
		}



	}

}

	

