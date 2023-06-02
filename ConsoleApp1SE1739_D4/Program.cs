namespace ConsoleApp1SE1739_D4;
using StudentRepository.Repo;
using StudentRepository.Entities;
using StudentRepository.Repository;
namespace ConsoleAppOopDemo.Programming
{
    public class Program
    {
        static void Main(string[] args)
        {

            /*
              - Cho phep nhap n sinh vien
              - Sap xep tang dan theo mark cua sinh vien
              - Update thong tin 1 sinh vien theo Id bat ky
              - Lay ra tat ca cac sinh vien do diem >=8.0
              - In thong tin ra man hinh

           */
            IRepository<Student> repo = new Repository();
            Student s1 = new Student(3, "Bao Thanh Thien", "Quan 1", 9.5);

            repo.Add(new Student(1, "Ma Van Meo", "Quan 1", 8.5));
            repo.Add(new Student(2, "Phi Van Long", "Quan 1", 3.5));
            repo.Add(s1);
            repo.Add(new Student(4, "Ton Ngo Khong", "Quan 1", 7));
            repo.Add(new Student(5, "Nguyen Cong PHuong", "Quan 1", 7.4));

            repo.Display();

            repo.Delete(s1);
            Console.WriteLine("=============================");

            repo.Add(s1);
            //repo.Delete(s1);

            repo.Display();
            Console.WriteLine("=============================");

            IEnumerable<Student> students = repo.FindAll(7.0);

            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }

            Console.ReadLine();

        }
    }
}