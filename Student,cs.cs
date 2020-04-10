using System;

public class Student : Person
{
	public string StudentId { get; set; }
	public string Email { get; set; }

	public Student(string mName, int mAge, string mStudentId, string mEmail) : base(mName, mAge)
	{
		StudentId = mStudentId;
		StudentId = mEmail;
	}
}
