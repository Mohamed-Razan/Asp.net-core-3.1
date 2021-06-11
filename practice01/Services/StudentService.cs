using practice01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practice01.Services
{
    public class StudentService
    {
        private MyPracticeDbContext myPractice;

        public StudentService(MyPracticeDbContext myPractice)
        {
            this.myPractice = myPractice;
        }

        public Student addStudent(Student student)
        {
            myPractice.Student.Add(student);
            myPractice.SaveChanges();

            return student;
        }

        public Student getStudentById(int id)
        {
            return myPractice.Student.FirstOrDefault(x => x.Id == id);
        }

        public List<Student> getAllStudents()
        {
            return myPractice.Student.ToList();
        }

        public void updateStudent(Student student)
        {
             myPractice.Student.Update(student);
            myPractice.SaveChanges();
        }

        public Student deleteStudent(int id)
        {
            Student student = getStudentById(id);
            myPractice.Student.Remove(student);
            myPractice.SaveChanges();

            return student;
        }
    }
}
