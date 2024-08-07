using System;
namespace backend.Models
{
	public class Student
	{
		public Student(string name, string lastName)
		{
			Name = name;
			LastName = lastName;
  		}

        public string Name { get; set; }

        public string LastName { get; set; }
    }
}

