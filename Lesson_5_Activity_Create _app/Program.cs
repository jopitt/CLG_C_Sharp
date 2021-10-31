using System;
using System.Collections.Generic;

namespace CourseCoordinator
{
	public class Program
	{
		public static void Main()
		{
			Console.WriteLine("Hello World!");
			// Create list of students
			var students = new List<string>{"Alice", "Gwen", "Meg", "Nelly"};
			// Create list of courses at the university
			var courses = new List<string>{"Business", "Chemistry", "Mathematics", "Medicine"};
			var Alice = new List<string>{"Chemistry", "Medicine"};
			var Gwen = new List<string>{"Business"};
			var Meg = new List<string>{"Medicine"};
			var Nelly = new List<string>{"Mathematics", "Medicine"};
			
			while (true)
			{
				Console.WriteLine("-------------------------------------------------------------------");
				Console.WriteLine("What would you like to see or do?");
				// list what options the user can enter
				Console.WriteLine("Students = See a list of students at the university");
				Console.WriteLine("Courses = See a list of courses at the university");
				Console.WriteLine("Enrol = Enrol a new student at the university");
				Console.WriteLine("Unenrol = Unenrol a student");
				Console.WriteLine("StudentCourse = See the courses a student is enrolled");
				Console.WriteLine("AddCourse = Add a new course to the university catalogue");
				Console.WriteLine("RemoveCourse = Remove a course from the university catalogue");
				Console.WriteLine("CourseEnrol = Add course to student's enrolment");
				Console.WriteLine("X = Exit");
				var userInput = Console.ReadLine();
				// exit the code if a user inputs X
				if (userInput == "X")
				{
					break;
				}

				// respond to the user command
				switch (userInput.ToLower())
				{
					case "students":
						Console.WriteLine("Here is a list of students:");
						foreach(var student in students)
                        {       
                            Console.WriteLine($"\t" + student);
                        }						
						break;
						
					case "courses":
						Console.WriteLine("Here is a list of courses offered:");
						foreach(var course in courses)
                        {       
                            Console.WriteLine($"\t" + course);
                        }						
						break;
						
					case "enrol":
						var studentInput = new List<string>();
		
						//Ask user to input new students
        				Console.Write("Enter student's name: ");
        				var input = Console.ReadLine();

        				while (!string.IsNullOrEmpty(input)) //for user input
        				{
							studentInput.Add(input);
							Console.WriteLine("Enter another student's name (otherwise, hit Enter):");
							input = Console.ReadLine();
      					}		
	
						//if there are students in the new list, output result
						if (studentInput.Count > 0)
						{
							Console.WriteLine($"You have entered {studentInput.Count} students: ");
							foreach (var student in studentInput)
							{
								Console.WriteLine($"\t" + student);
							}
						Console.WriteLine(); //blank line - maybe a better way
						}

						//Add new students to existing student list
						students.AddRange(studentInput);

						students.Sort(); //sort list alphabetically

						//Output updated students list
						Console.WriteLine("The updated list of students is: ");
		
						for(var i=0; i<students.Count; i++)
						{
							Console.WriteLine("\t" + students[i]);
						}
						break;
						
					case "unenrol":
						//Ask user to enter student to remove
						Console.WriteLine("Enter the student you want to unenrol:");
						var unenrolStudent = Console.ReadLine();
		
						//Remove course from list 
						students.Remove($"{unenrolStudent}");
		
						//Ask user to enter another student to remove
						while (!string.IsNullOrEmpty(unenrolStudent)) //while user student, the student is removed from the list
        				{
							Console.WriteLine("Enter another student (otherwise, hit Enter):");
          					unenrolStudent = Console.ReadLine();
							students.Remove($"{unenrolStudent}");
						}
						
						students.Sort(); //sort list alphabetically

						//User has pressed enter
						Console.WriteLine("The updated list of students is:");
		
						//for loop to go through all of the remaining students in the list
						for(var i=0; i<students.Count; i++)
						{
							Console.WriteLine($"\t" + students[i]);
						}
						break;
													
					case "addcourse":
						//Create list for new courses
						var courseInput = new List<string>();
		
						//Ask user to input new course
        				Console.Write("Enter course name: ");
        				var newCourse = Console.ReadLine();

        				while (!string.IsNullOrEmpty(newCourse)) //for user input
        				{
							courseInput.Add(newCourse);
							Console.WriteLine("Enter another course name (otherwise, hit Enter):");
							newCourse = Console.ReadLine();
      					}		
	
						//if there are courses in the new list, output result
						if (courseInput.Count > 0)
						{
							Console.WriteLine($"You have entered {courseInput.Count} courses:");
							foreach (var course in courseInput)
							{
								Console.WriteLine($"\t" + course);
							}
						Console.WriteLine(); //blank line - maybe a better way
						}

						//Add new courses to existing course list
						courses.AddRange(courseInput);

						courses.Sort(); //sort list alphabetically

						//Output updated course list
						Console.WriteLine("The updated list of courses is:");
		
						for(var i=0; i<courses.Count; i++)
						{
							Console.WriteLine($"\t" + courses[i]);
						}
						break;
						
						
					case "removecourse":
						Console.WriteLine("List the course you want to remove:");
						var removeCourse = Console.ReadLine();
		
						//Remove course from list 
						courses.Remove($"{removeCourse}");
		
						//Ask user to enter another course to remove

						while (!string.IsNullOrEmpty(removeCourse)) //while user enters course, it is removed from the list
        				{
							Console.WriteLine("Enter another course (otherwise, hit Enter):");
          					removeCourse = Console.ReadLine();
							courses.Remove($"{removeCourse}");
						}
						
						courses.Sort(); //sort list alphabetically

						//User has pressed enter
						Console.WriteLine("The updated list of courses is:");
		
						//for loop to go through all of the remaining courses in the list
						for(var i=0; i<courses.Count; i++)
						{
							Console.WriteLine($"\t" + courses[i]);
						}
						break;
						
					case "studentcourse":
						// Create list of courses at the university
	
						while(true)
						{
							Console.WriteLine("Enter student name to list enrolled courses (or X to exit):");
							var enrolCourse = Console.ReadLine();
							if (enrolCourse == "X")
							{
								break;
							}
							switch (enrolCourse)
							{
								case "Alice":
									foreach(var course in Alice)
									{       
										Console.WriteLine($"\t" + course);
									}
									break;

								case "Gwen":
									foreach(var course in Gwen)
									{
										Console.WriteLine($"\t" + course);
									}
									break;

								case "Meg":
									foreach(var course in Meg)
									{       
										Console.WriteLine($"\t" + course);
									}
									break;

								case "Anjen":
									foreach(var course in Nelly)
									{       
										Console.WriteLine($"\t" + course);
									}
									break;

								default:
									Console.WriteLine("I didn't recognise that command.");
									break;
							}
						}
						break;
						
					case "courseenrol":
					
						Console.WriteLine("Enter student's name:");
						var nameStudent = Console.ReadLine();
						if (nameStudent == "Alice")
						{
							Console.Write("Enter course: ");
							var enrolCourse = Console.ReadLine();
							
							while (!string.IsNullOrEmpty(enrolCourse))
							{
								Alice.Add(enrolCourse);
								Console.WriteLine("Enter another course (otherwise, hit Enter):");
								enrolCourse = Console.ReadLine();
							}
							
							Console.WriteLine("Enrolled courses:");
							foreach(var course in Alice)
							{
								Console.WriteLine($"\t" + course);
							}
							break;
						}
						if (nameStudent == "Gwen")
						{
							Console.Write("Enter course: ");
							var enrolCourse = Console.ReadLine();
							
							while (!string.IsNullOrEmpty(enrolCourse))
							{
								Gwen.Add(enrolCourse);
								Console.WriteLine("Enter another course (otherwise, hit Enter):");
								enrolCourse = Console.ReadLine();
							}
							
							Console.WriteLine("Enrolled courses:");
							foreach(var course in Gwen)
							{
								Console.WriteLine($"\t" + course);
							}
							break;
						}
						if (nameStudent == "Meg")
						{
							Console.Write("Enter course: ");
							var enrolCourse = Console.ReadLine();
						
							while (!string.IsNullOrEmpty(enrolCourse))
							{
								Meg.Add(enrolCourse);
								Console.WriteLine("Enter another course (otherwise, hit Enter):");
								enrolCourse = Console.ReadLine();
							}
							
							Console.WriteLine("Enrolled courses:");
							foreach(var course in Meg)
							{
								Console.WriteLine($"\t" + course);
							}
							break;
						}
						if (nameStudent == "Nelly")
						{
							Console.Write("Enter course: ");
							var enrolCourse = Console.ReadLine();
							
							while (!string.IsNullOrEmpty(enrolCourse))
							{
								Nelly.Add(enrolCourse);
								Console.WriteLine("Enter another course (otherwise, hit Enter):");
								enrolCourse = Console.ReadLine();
							}
							
							Console.WriteLine("Enrolled courses:");
							foreach(var course in Nelly)
							{
								Console.WriteLine($"\t" + course);
							}
							break;
						}
						break;
						
							
					// add more case statements to allow for more options
					default:
						Console.WriteLine("I didn't recognise that command.");
						break;
				}
			}
		}
	}
}