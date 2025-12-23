class Instructor
{
   public int InstructorId;
    string Name;
    string Specialization;

    public Instructor(int instructorId, string name, string specialization)
    {
        InstructorId = instructorId;
        Name = name;
        Specialization = specialization;
    }

    public string PrintDetails() 
    {
        return $" InstructorId :{InstructorId} , Name :{Name} ,Specialization :{Specialization} ";
    }
}



