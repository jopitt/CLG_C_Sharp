using System;
using System.Collections.Generic;


namespace ExamCentre.Models

{
    public class Exam
    {
        public string Subject;
	internal List<Student> Students;
		
	public Exam(string subject)
	{
		Subject = subject { get; set; }
		Students = new List<Student>() { get; set; }
	}

	public Exam()
	{

	}

	public void AddStudent(Student student)
	{
		Students.Add(student);
	}

	public void MarkPaper(int candidateNumber, int examMark)
	{
		var student = Students.Find(x => x.CandidateNumber == candidateNumber);
		student.AddScore(examMark);
	}
    }
}
