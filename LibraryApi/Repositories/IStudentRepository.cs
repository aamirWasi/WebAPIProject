﻿using System;
using System.Collections.Generic;

namespace LibraryApi.Repositories
{
    public interface IStudentRepository
    {
        Student GetSingleStudent(int? studentId);
        void Insert(Student student);
        List<Student> GetStudents();
        void UpdateStudent(Student student);
        void DeleteStudent(Student student);
        decimal CheckFine(int? studentId);
        void ReceiveFine(Student student, decimal paymentAmount);

    }
}
