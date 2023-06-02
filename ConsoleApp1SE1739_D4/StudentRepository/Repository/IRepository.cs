using StudentRepository.Entities;
namespace StudentRepository.Repo;

public interface IRepository<T> where T : class
{
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
    void Delete(int id);

    IEnumerable<T> GetAll();
    T Find(int id);
    void Display();

    IEnumerable<T> FindAll(double v);// return all stu ma diem >=7
}