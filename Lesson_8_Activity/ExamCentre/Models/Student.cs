using System;

namespace ExamCentre.Models
{
    public class Student
    {
        private string Name;
        internal int CandidateNumber;
        internal int Score;
		
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