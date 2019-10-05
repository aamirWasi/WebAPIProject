﻿using System.Collections.Generic;

namespace LibraryApi.Services
{
    public interface IStudentService
    {
        Student GetStudent(int? studnetId);
        bool SaveStudent(Student student);
        List<Student> GetStudentList();
        bool EditStudent(Student student);
        bool RemoveStudent(Student student);
        decimal CheckFineAmount(int? studentId);
        decimal RemainingFineBalance(decimal fineAmount, decimal paymentAmount);
        void ReceiveStudentFine(Student student, decimal amount);

    }
}
