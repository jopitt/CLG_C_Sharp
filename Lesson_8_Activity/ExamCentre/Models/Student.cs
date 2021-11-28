using System;

namespace ExamCentre.Models
{
    public class Student
    {
        private string Name { get; set; }
        internal int CandidateNumber { get; set; }
        internal int Score { get; set; }
		
	public Student(string name, int candidateNumber)
	{
		Name = name;
		CandidateNumber = candidateNumber;
	}

	public void AddScore(int score)
	{
		Score = score;
	}	
    }
}
