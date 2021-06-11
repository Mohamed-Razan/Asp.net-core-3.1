using Microsoft.AspNetCore.Mvc;
using practice01.Models;
using practice01.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practice01.Controllers
{
    [ApiController]
    public class StudentController : ControllerBase
    {
        private StudentService service;

        public StudentController(StudentService service)
        {
            this.service = service;
        }

        [Route("/addStudent"), HttpPost]
        public Student addStudent(Student student)
        {
            return service.addStudent(student);
        }

        [Route("/getStudentById/{id}"), HttpGet]
        public Student getStudentById(int id)
        {
            return service.getStudentById(id);
        }

        [Route("/getAllStudents"), HttpGet]
        public List<Student> getAllStudents()
        {
            return service.getAllStudents();
        }

        [Route("/updateStudent"), HttpPut]
        public void updateStudent(Student student)
        {
            service.updateStudent(student);
        }

        [Route("/deleteStudent/{id}"), HttpDelete]
        public Student deleteStudent(int id)
        {
            return service.deleteStudent(id);
        }
    }
}
