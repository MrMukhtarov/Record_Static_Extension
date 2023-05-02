namespace Record_Static_Extension.Models;

internal class Student
{
    public int Id { get; }
    private static int Count { get; set; }

    public Student()
    {
        Count++;
        Id = Count;
    }


}
