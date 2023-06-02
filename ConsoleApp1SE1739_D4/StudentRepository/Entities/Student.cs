
namespace StudentRepository.Entities;
public class Student
{
    //fields
    private int _id;
    public int Id { get => _id; set => _id = value; }
    //properties
    public string Name;
    public string Address { get; set;}
    public double Mark {get; set;}
    //constructors
    public Student() => this._id = 0;
    public Student(int id, string name, string address, double mark)
    {
        Id = id;
        Name = name;
        Address = address;
        Mark = mark;
    }

    public override string? ToString() => $"Id: {Id}, Name: {Name}, " +
        $" Address: {Address} and Mark: {Mark}";
    
}
