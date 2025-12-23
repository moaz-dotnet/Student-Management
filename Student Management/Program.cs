

namespace Student_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool know = false;
            StudentManger manager = new StudentManger();
            
            while (!know) 
            {
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Add Instructor");
                Console.WriteLine("3. Add Course");
                Console.WriteLine("4. Enroll Student in Course");
                Console.WriteLine("5. Show All Students");
                Console.WriteLine("6. Show All Courses");
                Console.WriteLine("7. Show All Instructors");
                Console.WriteLine("8. Find the student by id .");
                Console.WriteLine("9. Find the course by id .");
                Console.WriteLine("10. Exit");
                //---------------------------------------------------------------------------
                
               
                //===========================================================================
                Console.Write("Enter number of operation : ");
                
               
                



                int numEnter = Convert.ToInt32(Console.ReadLine());
                if (numEnter == 1)
                {
                    Console.WriteLine("please Enter the id student ");
                    int sId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("please Enter the name student ");
                    string? sName = Console.ReadLine();
                    Console.WriteLine("Enter your age : ");
                    int sAge = Convert.ToInt32(Console.ReadLine());
                    Student s = new Student(sId, sName, sAge);
                    manager.AddStudent(s);


                }
                else if (numEnter == 2)
                {
                    Console.WriteLine("please Enter the InstructorId : ");
                    int instId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("please Enter the name Instructor ");
                    string? instName = Console.ReadLine();
                    Console.WriteLine("Enter your Specialization : ");
                    string? special = Console.ReadLine();
                    Instructor s = new Instructor(instId, instName, special);
                    manager.AddInstructor(s);
                }
                else if (numEnter == 3)
                {
                    Console.WriteLine("Please enter the CourseId:");
                    int courseId = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Please enter the Course Title:");
                    string? title = Console.ReadLine();

                    Console.WriteLine("Please enter the Instructor ID for this course:");
                    int instId = Convert.ToInt32(Console.ReadLine());

                    Instructor? inst = manager.FindInstructor(instId);

                    if (inst == null)
                    {
                        Console.WriteLine("Instructor not found. Add the instructor first.");
                    }
                    else
                    {
                        Course c = new Course(courseId, title, inst);
                        manager.AddCourse(c);
                        Console.WriteLine("Course added successfully.");
                    }
                }
                else if (numEnter == 4)
                {
                    Console.Write("Enter Student ID: ");
                    int studentId = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Course ID: ");
                    int courseId = Convert.ToInt32(Console.ReadLine());

                    bool success = manager.EnrollStudentInCourse(studentId, courseId);

                    if (success)
                        Console.WriteLine("Student enrolled successfully in the course.");
                    else
                        Console.WriteLine("Enrollment failed. Check IDs or if student is already enrolled.");
                }
                else if (numEnter == 5)
                {
                    manager.ShowAllStudents();
                }
                else if (numEnter == 6)
                {
                    manager.ShowAllCourses();
                }
                else if (numEnter == 7)
                {
                    manager.ShowAllInstructor();
                }
                else if (numEnter == 8)
                {
                    Console.WriteLine("Please Enter studentid or name ");
                    int nameOrId = Convert.ToInt32(Console.ReadLine());
                    Student? found = manager.FindStudent(nameOrId);
                   
                    if (found != null)
                    {
                        Console.WriteLine(found.PrintDetails());
                    }
                    else
                    {
                        Console.WriteLine("Student not found.");
                    }
                }

                else if (numEnter == 9)
                {
                    Console.WriteLine("Please Enter Course id ");
                    int nameOrId = Convert.ToInt32(Console.ReadLine());
                    Course? found = manager.FindCourse(nameOrId);

                    if (found != null)
                    {
                        Console.WriteLine(found.PrintDetails());
                    }
                    else
                    {
                        Console.WriteLine("Student not found.");
                    }
                }
                else if (numEnter == 10)
                {
                   know = true;
                }
            }

            }


        }
    }



