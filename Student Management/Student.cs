class Student
{
   public int StudentId;

   public string Name;
   public int Age;
   public List<Course> Courses = new List<Course>();

    public Student(int studentId, string name, int age )
    {
        StudentId = studentId;
        Name = name;
        Age = age;
       
    }

   public bool Enroll(Course course)
    {
        Courses.Add(course);
        return true;

    }
   public string PrintDetails() 
    {
        return $"Student ID: {StudentId}, Name: {Name}, Age: {Age}, Number of the courses: {Courses.Count}";
    }
}



