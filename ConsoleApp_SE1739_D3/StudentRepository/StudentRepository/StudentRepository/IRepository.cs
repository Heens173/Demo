using StudentRepository.Entities;

namespace StudentRepository.Repo;

public interface IRepository
{
    void Add(Student entity);
    void Update(Student entity);
    void Delete(Student entity);
    void Delete(int id);

    Student[] GetAll();
    Student Find(int id);

}