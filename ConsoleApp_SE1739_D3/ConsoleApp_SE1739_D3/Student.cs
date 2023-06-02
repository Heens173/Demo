namespace ConsoleApp_SE1739_D3.Entities;
public class Student
{
    //fields
    private int id;
    public int StudentId { get => id; set => id = value; }
    //properties
    public string Name;
    public string Address { get; set; }
    public string Mark { get; set; }
}
}
