using System;
using System.Collections.Generic;
using ExamCentre.Models;

namespace ExamCentre
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exam Centre");
            Console.WriteLine();
            
            var exam = new Exam("Physiology");
            
            var student1 = new Student("Ally", 1111);
            var student2 = new Student("Bella", 1112);
            var student3 = new Student("Casey", 1113);
            
            exam.AddStudent(student1);
            exam.AddStudent(student2);
            exam.AddStudent(student3);
            
            exam.MarkPaper(1111, 55);
            exam.MarkPaper(1112, 73);
            exam.MarkPaper(1113, 98);

            Console.WriteLine(exam.Subject);
            foreach (var student in exam.Students)
            {
                Console.WriteLine($"{student.CandidateNumber}: {student.Score}");
		    }	
        }  
    }
}
