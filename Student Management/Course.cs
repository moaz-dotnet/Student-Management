class Course
{
   public int CourseId;
    public string Title;
    Instructor Instructor;

    public Course(int courseId, string title, Instructor instructor)
    {
        CourseId = courseId;
        Title = title;
        Instructor = instructor;
    }

    public string PrintDetails()
    {
        return $"CourseId : {CourseId} , Title : {Title}\n ,Instructor {Instructor.PrintDetails()}";// \nننزل سطر ونطبع تفاصيل المدرب 
    }
}



