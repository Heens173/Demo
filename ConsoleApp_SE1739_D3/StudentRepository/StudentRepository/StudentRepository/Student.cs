namespace StudentRepository.Entities;
public class Student
{
    //fields
    private int id;
    public int Id { get => id; set => id = value; }
    //properties
    public string Name;
    public string Address { get; set; }
    public double Mark { get; set; }


    public Student()
    {
        this.id = 0;
    }

    public Student(int id, string name, string address, double mark)
    {
        Id = id;
        Name = name;
        Address = address;
        Mark = mark;
    }

    public override string ToString() => $"ID: {Id}, Name: {Name}, Address: {Address}, Mark: {Mark}";

}
