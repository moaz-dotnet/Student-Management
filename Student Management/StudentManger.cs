class StudentManger
{
    List<Student> Students = new List<Student>();
    List<Course> Courses = new List<Course>();
    List<Instructor> Instructors = new List<Instructor>();
    public bool AddStudent(Student student)
    {
        Students.Add(student);
        return true;
    }
    public bool AddCourse(Course course)
    {
        Courses.Add(course);

        return true;
    }
    public bool AddInstructor(Instructor instructor)
    {
        Instructors.Add(instructor);
        return true;
    }
    public void ShowAllStudents()
    {
        if (Students.Count == 0)
        {
            Console.WriteLine("No students found.");
            return;

        }
        Console.WriteLine("=== All Students ===");
        for (int i = 0; i < Students.Count; i++)
        {
            Console.WriteLine(Students[i].PrintDetails());
        }
    }
    public void ShowAllCourses()
    {
        if (Courses.Count == 0)
        {
            Console.WriteLine("No courses found.");
            
        }

        Console.WriteLine("=== All Courses ===");
        for (int i = 0; i < Courses.Count; i++)
        {
            Console.WriteLine(Courses[i].PrintDetails());
        }
    }
    public void ShowAllInstructor()
    {
        if (Instructors.Count == 0)
        {
            Console.WriteLine("No instrutor found. ");
        }
        Console.WriteLine("=== All Instrutor ===");
        for (int i = 0; i < Instructors.Count; i++)
        {
            Console.WriteLine(Instructors[i].PrintDetails());
        }
    }
   public Student? FindStudent(int studentId)
    {

        for (int i = 0; i < Students.Count; i++)
        {
            if (Students[i].StudentId == studentId)
            {

                return Students[i];
            }


        }

        return null;
    }


  public  Course? FindCourse(int courseId)
    {
        for (int i = 0; i < Courses.Count; i++)
        {
            if (Courses[i].CourseId == courseId)
            {

                return Courses[i];
            }


        }

        return null;

    }
   public Instructor? FindInstructor(int instructorId)
    {
        for (int i = 0; i < Instructors.Count; i++)
        {
            if (Instructors[i].InstructorId == instructorId)
            {
                return Instructors[i];
            }
        }
        return null;
    }
  public  bool EnrollStudentInCourse(int studentId, int courseId)
    {
      Student? x=  FindStudent(studentId);//Studentالواحد ضاع في افكاره لحد معرف نوع الداتا تيب هبقي 
        Course? y=   FindCourse(courseId);
        if (x  == null|| y  == null)
        {
            return false;
        }
      

        return x.Enroll(y); 
    }

}



