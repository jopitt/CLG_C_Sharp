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
			var students = new List<string>{"alice", "gwen", "meg", "nelly"};
			// Create list of courses at the university
			var courses = new List<string>{"business", "chemistry", "mathematics", "medicine"};
			// Create list of students and the courses they're enrolled in (haven't learnt how to do this another way yet)
			var alice = new List<string>{"chemistry", "medicine"};
			var gwen = new List<string>{"business"};
			var meg = new List<string>{"medicine"};
			var nelly = new List<string>{"mathematics", "medicine"};
			// Create list for each course to alert user for enrolment limit						
			var chemistry = new string[]{"alice"};
			var business = new string[]{"gwen"};
			var mathematics = new string[]{"nelly"};
			var medicine = new string[]{"alice", "meg", "nelly"};
			
			
			while (true)
			{
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
						    Console.WriteLine($"\t" + char.ToUpper(student[0]) + student.Substring(1));
						}						
						break;
						
					case "courses":
						Console.WriteLine("Here is a list of courses offered:");
						foreach(var course in courses)
						{       
						    Console.WriteLine($"\t" + char.ToUpper(course[0]) + course.Substring(1));
						}						
						break;

					case "enrol":					
						//Ask user to check if student is already enrolled
						Console.WriteLine("Enter student's name to check if the student is currently enrolled:");
						// User input converted to lower case
						var checkStudent = Console.ReadLine().ToLower();
						// Determine if student is enrolled is true
						bool isStudentEnrolled = students.Contains(checkStudent);
						// Output result
						Console.WriteLine($"{(char.ToUpper(checkStudent[0]) + checkStudent.Substring(1))} is enrolled: {isStudentEnrolled}");
						
						// If true, user is exited from the application. 
						if(isStudentEnrolled == true)
						{
							break;
						}
						
						// Create new list to add new student/s
						var studentInput = new List<string>();

						//Ask user to input new students
        					Console.WriteLine("To enrol a new student, enter student's name:");
						// User input converted to lower case
        					var input = Console.ReadLine().ToLower();

						// While the input contains text
        					while (!string.IsNullOrEmpty(input))
						{
							//Add user input to new list
							studentInput.Add(input);
							// Ask the user to enrol another student
							Console.WriteLine("To enrol another student, enter student's name (otherwise, hit Enter):");
							// User input converted to lower case
							input = Console.ReadLine().ToLower();
      						}		
	
						//if there are students in the new list, list the new students
						if (studentInput.Count > 0)
						{
							Console.WriteLine($"You have entered {studentInput.Count} students:");
							foreach (var student in studentInput)
							{
								Console.WriteLine($"\t" + char.ToUpper(student[0]) + student.Substring(1));
							}
						Console.WriteLine(); //blank line - maybe a better way
						}

						//Add new students to existing student list
						students.AddRange(studentInput);

						students.Sort(); //sort list alphabetically

						//User has exited while loop, output complete updated students list
						Console.WriteLine("The updated list of students is:");
		
						foreach(var student in students)
						{
							// Capitalise first letter in student's name
							Console.WriteLine("\t" + char.ToUpper(student[0]) + student.Substring(1));
						}
						break;
						
					case "unenrol":
						//Create new list for unenrolled students
						var removeStudentInput = new List<string>();

						//Ask user to enter student name
						Console.WriteLine("To unenrol a student, enter the student's name:");
						var unenrolStudent = Console.ReadLine().ToLower();

						//While input contains text
						while (!string.IsNullOrEmpty(unenrolStudent))
						{
							//Input is added to new list for removed courses
							removeStudentInput.Add(unenrolStudent);
							//Ask user to enter another course name
							Console.WriteLine("To unenrol another student, enter the student's name (otherwise, hit enter):");
							unenrolStudent = Console.ReadLine().ToLower();
						}
						//Remove courses in new list from existing list
						foreach(var student in removeStudentInput)
						{
								students.Remove(student);	
						}

						//Output list of courses to be removed
						if (removeStudentInput.Count >0)
						{
							Console.WriteLine($"You have entered {removeStudentInput.Count} students:");
							foreach (var student in removeStudentInput)
							{
								Console.WriteLine($"\t" + char.ToUpper(student[0]) + student.Substring(1));
							}
						}
						//Output complete updated list of courses
						Console.WriteLine("The updated list of students is:");
						foreach(var student in students)
						{
							Console.WriteLine($"\t" + char.ToUpper(student[0]) + student.Substring(1));
						}
						break;
													
					case "addcourse":
						//Ask user to check if course is already listed
						Console.WriteLine("Enter the course name to check if the course is currently listed:");
						// User input converted to lower case
						var checkCourse = Console.ReadLine().ToLower();
						
						// Determine if course is current listed is true
						bool isCourseListed = courses.Contains(checkCourse);
						//Output result	
						Console.WriteLine($"{(char.ToUpper(checkCourse[0]) + checkCourse.Substring(1))} is enrolled: {isCourseListed}");
						
						// If true, user is exited from the system
						if(isCourseListed == true)
						{
							break;
						}

						//Create new list to add new course/s
						var courseInput = new List<string>();
		
						//Ask user to input new course name
        					Console.Write("To add a course, enter course name: ");
						//User input converted to lower case
        					var newCourse = Console.ReadLine().ToLower();
						
						//While input contains text
						while (!string.IsNullOrEmpty(newCourse))
						{
								//New course added to new course  list
								courseInput.Add(newCourse);
								//Ask the user to enter another course
								Console.WriteLine("To add another course, enter course name (otherwise, hit Enter):");
								//User input converted to lower case
								newCourse = Console.ReadLine().ToLower();
						}		
	
						//if there are courses in the new list, list the new courses
						if (courseInput.Count > 0)
						{
							Console.WriteLine($"You have entered {courseInput.Count} courses:");
							foreach (var course in courseInput)
							{
								Console.WriteLine("\t" + char.ToUpper(course[0]) + course.Substring(1));
							}
						Console.WriteLine();
						}

						//Add new courses to existing course list
						courses.AddRange(courseInput);

						courses.Sort(); //sort list alphabetically

						//Output complete updated course list
						Console.WriteLine("The updated list of courses is:");
		
						foreach(var course in courses)
						{
							Console.WriteLine("\t" + char.ToUpper(course[0]) + course.Substring(1));
						}
						break;
						
						
					case "removecourse":
						//Create new list for removed courses
						var removeCourseInput = new List<string>();

						//Ask user to enter course to remove
						Console.WriteLine("List the course you want to remove:");
						var removeCourse = Console.ReadLine().ToLower();

						//While input contains text
						while (!string.IsNullOrEmpty(removeCourse))
						{
							//Input is added to new list for removed courses
							removeCourseInput.Add(removeCourse);
							//Ask user to enter another course name
							Console.WriteLine("Please enter another course (otherwise, please press enter): ");
							removeCourse = Console.ReadLine().ToLower();
						}
						
						//Output list of courses to be removed
						if (removeCourseInput.Count >0)
						{
							Console.WriteLine($"You have entered {removeCourseInput.Count} courses:");
							foreach (var course in removeCourseInput)
							{
								Console.WriteLine($"\t" + char.ToUpper(course[0]) + course.Substring(1));
							}
						}
						//Remove courses in new list from existing list
						foreach(var course in removeCourseInput)
						{
								courses.Remove(course);	
						}

						//Output complete updated list of courses
						Console.WriteLine("The updated list of courses is:");
						foreach(var course in courses)
						{
							Console.WriteLine($"\t" + char.ToUpper(course[0]) + course.Substring(1));
						}
						break;
						
					case "studentcourse":
						// List courses a student is enrolled in
						Console.WriteLine("To see a list of courses a student is enrolled in, enter the student's name:");
						var studentCourse = Console.ReadLine().ToLower();
						
						switch (studentCourse)
						{
							case "alice":
								foreach(var course in alice)
								{       
									Console.WriteLine($"\t" + char.ToUpper(course[0]) + course.Substring(1));
								}
								break;

							case "gwen":
								foreach(var course in gwen)
								{
									Console.WriteLine($"\t" + char.ToUpper(course[0]) + course.Substring(1));
								}
								break;
								
							case "meg":
								foreach(var course in meg)
								{       
									Console.WriteLine($"\t" + char.ToUpper(course[0]) + course.Substring(1));
								}
								break;

							case "nelly":
								foreach(var course in nelly)
								{       
									Console.WriteLine($"\t" + char.ToUpper(course[0]) + course.Substring(1));
								}
								break;
								
							//If user input is not matched to a student's name
							default:
								Console.WriteLine("I didn't recognise that command.");
								break;
						}
						break;
						
					case "courseenrol":
						Console.WriteLine("Enter the course name to check if the course has an enrolment limit:");
						var enrolCourse = Console.ReadLine().ToLower();
						if(enrolCourse == "chemistry")
						{
						   	Console.Write($"The enrolment limit for this course is 5. The number of students enrolled in this course is: ");
							Console.WriteLine(chemistry.Length);
						}
						else
						{
							Console.WriteLine("This course does not have an enrolment limit.");
						}
						//Add a course to a student's course list
						Console.WriteLine("To enrol a student in a course, enter the student's name (otherwise, hit Enter):");
						//User input converted to lowercase
						var nameStudent = Console.ReadLine().ToLower();
						
						//Match user input to a condition
						if (nameStudent == "alice")
						{
							Console.Write("Enter course: ");
							//User input converted to lowercase
							enrolCourse = Console.ReadLine().ToLower();
							
							//While user input contains text
							while (!string.IsNullOrEmpty(enrolCourse))
							{
							//New course is added to student's course list
							alice.Add(enrolCourse);
							//Ask user to input another course or hit enter to exit loop
							Console.WriteLine("Enter another course (otherwise, hit Enter):");
							//Convert user input to lowercase
							enrolCourse = Console.ReadLine().ToLower();
							}
							
							//sort course alphabetically
							alice.Sort();
							
							//List complete updated course list for student after exiting from while loop
							Console.WriteLine("Enrolled courses:");
							foreach(var course in alice)
							{
								Console.WriteLine($"\t" + char.ToUpper(course[0]) + course.Substring(1));
							}
							break;
						}
											
						
						if (nameStudent == "gwen")
						{
							Console.Write("Enter course: ");
							enrolCourse = Console.ReadLine().ToLower();
							
							while (!string.IsNullOrEmpty(enrolCourse))
							{
								gwen.Add(enrolCourse);
								Console.WriteLine("Enter another course (otherwise, hit Enter):");
								enrolCourse = Console.ReadLine().ToLower();
							}
							
							gwen.Sort();
							
							Console.WriteLine("Enrolled courses:");
							foreach(var course in gwen)
							{
								Console.WriteLine($"\t" + char.ToUpper(course[0]) + course.Substring(1));
							}
							break;
						}
						if (nameStudent == "meg")
						{
							Console.Write("Enter course: ");
							enrolCourse = Console.ReadLine().ToLower();
						
							while (!string.IsNullOrEmpty(enrolCourse))
							{
								meg.Add(enrolCourse);
								Console.WriteLine("Enter another course (otherwise, hit Enter):");
								enrolCourse = Console.ReadLine().ToLower();
							}
							
							meg.Sort();

							Console.WriteLine("Enrolled courses:");
							foreach(var course in meg)
							{
								Console.WriteLine($"\t" + char.ToUpper(course[0]) + course.Substring(1));
							}
							break;
						}
						if (nameStudent == "nelly")
						{
							Console.Write("Enter course: ");
							enrolCourse = Console.ReadLine();
							
							while (!string.IsNullOrEmpty(enrolCourse))
							{
								nelly.Add(enrolCourse);
								Console.WriteLine("Enter another course (otherwise, hit Enter):");
								enrolCourse = Console.ReadLine().ToLower();
							}
							
							nelly.Sort();
							
							Console.WriteLine("Enrolled courses:");
							foreach(var course in nelly)
							{
								Console.WriteLine($"\t" + char.ToUpper(course[0]) + course.Substring(1));
							}
							break;
						}
						break;
						
							
					default:
						Console.WriteLine("I didn't recognise that command.");
						break;
				}
				Console.WriteLine("Press any key to continue");
				Console.ReadKey();
			}
		}
	}
}
