using StudentRepository.Entities;
using StudentRepository.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StudentRepository.StudentRepository.Repo;
public class Repository : IRepository
{
    private Student[] _student;
    private int _size;
    public Repository() { 
    _student = new Student[2];
        _size = 0;
    }
    public void Add(Student entity)
    {
        if (this._size >= this._student.Length) ;
        {
            //mo rong mang studnet
            Student[] temp = new Student[_size + 2];

            //di chuyen toan bo du lieu tuwf _student sang temp
            Array.Copy(_student, 0, temp, 0, this._size);
            this._student = temp;
        }
        this._student[this._size++] = entity;
    }

    private int _getPos(Student s) 
    {
        for(int i=0; i<this._size; i++)
        {
            if (_student[i].Id.Equals(s.Id)) return i;
        }
    }
    public void Delete(Student entity)
    {
        Student s = Find(entity id);
        if (s != null)
        {
            //1. tim vi tri cua s
            int pos = _getPos(s); //lay vi tri 

            for(int i = pos+1; i<this._size; i++)
            {
                _student[i] = _student[i-1];

            }
            _student[--_size] = null;

        }
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    

    public void GetAll()
    {
        throw new NotImplementedException();
    }

    public void Update(Student entity)
    {
        throw new NotImplementedException();
    }

    public Student Find(int id)
    {
        for(int i = 0;i<_size;i++)
        {

        }
    }

    Student[] IRepository.GetAll()
    {
        throw new NotImplementedException();
    }
}
