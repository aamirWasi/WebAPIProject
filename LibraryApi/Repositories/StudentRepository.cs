using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyModel;

namespace LibraryApi.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private LibraryContext _context;
        public StudentRepository(LibraryContext context)
        {
            _context = context;
        }

        public Student GetStudentById(int? studentId)
        {
            return _context.Students.Where(s => s.Id == studentId).FirstOrDefault();
        }

        public void Insert(Student student)
        {
            _context.Students.Add(student);
            Save();
        }

        private void Save()
        {
            Save();
        }

        public List<Student> GetAllStudents()
        {
            var students = _context.Students.OrderBy(s => s.Id).ToList();
            return students;
        }

        public void UpdateStudent(Student student)
        {
            _context.Students.Update(student);
            Save();
        }

        public void DeleteStudent(Student student)
        {
            _context.Students.Remove(student);
            Save();
        }

        public decimal CheckFine(int? studentId)
        {
            return _context.Students
                    .Where(s => s.Id == studentId)
                    .Select(s => s.FineAmount)
                    .FirstOrDefault();
        }

        public void ReceiveFine(Student student, decimal paymentAmount)
        {
            student.FineAmount = paymentAmount;
            _context.Students.Update(student);
            Save();
        }
    }
}
