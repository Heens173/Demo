using StudentRepository.Entities;
using StudentRepository.Repo;

namespace StudentRepository.Repository;

public class Repository : IRepository<Student>
{
    private LinkedList<Student> _students;
    /*
    private Student[] _students;
    private int _size;
    */
    public Repository()
    {
        this._students = new LinkedList<Student>();
        /*
         * _students = new Student[2];
        *_size = 0;
        */
    }
    
    public void Add(Student entity)
        => this._students.AddFirst(entity);


    public void Delete(Student entity)
        => this._students.Remove(entity);

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }


    public Student Find(int id)
    {
        return this._students.FirstOrDefault(x => x.Id == id);
    }

    public IEnumerable<Student> GetAll()
        => this._students;


    public void Update(Student entity)
    {
        this._students.Single(s => s.Id == entity.Id).Name = entity.Name;
    }

    public void Display()
    {
        foreach (Student student in _students)
        {
            Console.WriteLine(student);
        }
    }

    public IEnumerable<Student> FindAll(double mark)
    {
        return this._students
            .Where(s => s.Mark >= mark)
            .OrderByDescending(s => s.Mark) //sorted
            .ToList();


    }

    public IEnumerable<Student> FindAll()
    {
        throw new NotImplementedException();
    }

    public override bool Equals(object? obj)
    {
        return obj is Repository repository &&
               EqualityComparer<LinkedList<Student>>.Default.Equals(_students, repository._students);
    }
}
//}
///*

//public void Add(Student entity) =>
//    this._students.add;
///* {

//    if (_size >= _students.Length)
//    {
//        //mo rong mang _students
//        Student[] temp = new Student[_size * 2];
//        //di chuyen toan bo du lieu tu _students sang temp
//        Array.Copy(_students, 0, temp, 0, _size);
//        _students = temp;

//    }
//    _students[_size++] = entity;

//}*/

//public void Delete(Student entity) => this._students.Remove(entity);
//    /*{
        

        
//        Student s = Find(entity.Id);
//        if (s != null)
//        {
//            //1. tim vi tri cua s
//            int pos = _getPos(s);//lay vi tri can xoa

//            for (int i = pos + 1; i < _size; i++)
//            {
//                _students[i - 1] = _students[i];
//            }
//            _students[--_size] = null;

//        }
//        */

//}

//public void Delete(int id)
//    {
//        throw new NotImplementedException();
//    }
//    private int _getPos(Student s)
//    {
//        for (int i = 0; i < _size; i++)
//        {
//            if (_students[i].Id.Equals(s.Id))
//            {
//                return i;
//            }

//        }
//        return -1;

//    }

//private bool _find(Student s)
//{
//    return s.Id == 1;
//}
//    public Student Find(int id) 
//    {
//    return this._students.FirstOrDefault(x => x.Id == id);
///*
//        for (int i = 0; i < _size; i++)
//        {
//            if (_students[i].Id.Equals(id))
//            {
//                return _students[i];
//            }

//        }
//        return null;
//*/
//    }
//public IEnumerable<Student> 

//    public Student[] GetAll()
//    {
//        return _students;
//    }

//    public void Update(Student entity)
//    {
//        throw new NotImplementedException();
//    }

//    public void Display()
//    {
//        foreach (Student student in _students)
//        {
//            Console.WriteLine(student);
//        }
//    }

//public IEnumerable<Student> FinAll(double mark)
//{
//    return this._students
//        .Where(x => x.Mark >= mark)
//        .OrderBy(k = k.mark)                    
//        .ToList();

//}
//*/

//}

