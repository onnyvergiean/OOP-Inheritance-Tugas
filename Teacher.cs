using System;

public class Teacher : Person
{
	public string TeacherId { get; set; }
	public string Subject { get; set; }

	public Teacher(string mName, int mAge, string mTeacherId, string mSubject) :base(mName,mAge)
	{
		TeacherId = mTeacherId;
		Subject = mSubject;
	}
}
