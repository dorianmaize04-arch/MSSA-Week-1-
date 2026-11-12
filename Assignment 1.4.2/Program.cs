

 class Student

{

  private int studentID;
  private string studentFirstname = " ";
  private string studentLname = " ";
  private char studentGrade;

  public int StudentID {get { return studentID; } set { studentID = value; }}
  public string StudentFirstname{ get { return studentFirstname; } set { studentFirstname = value; }}
  public string StudentLastname {get { return studentLname; } set { studentLname = value; }}
  public char StudentGrade {get { return studentGrade; } set { studentGrade = value; }}

}

class Program
{
  static void Main()
  {



Student student1 = new Student();
student1.StudentID = 930939;
student1.StudentFirstname = "Dorian";
student1.StudentLastname = "Gray";
student1.StudentGrade = 'A';

Console.WriteLine($"Student ID: {student1.StudentID}");
Console.WriteLine($"Student First Name: {student1.StudentFirstname}");
Console.WriteLine($"Student Last Name: {student1.StudentLastname}");
Console.WriteLine($"Student Grade: {student1.StudentGrade}");
}
}





