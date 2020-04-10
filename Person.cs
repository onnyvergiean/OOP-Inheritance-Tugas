using System;

public class Person
{
	public string Name { get; set; }
	public int Age { get; set; }

	public void GetNameAndAge()
	{
		Console.WriteLine("Nama : {0} dan Age : {1}", Name, Age);
	}
}
