using AssignmentWebAPIProject;
using System;

namespace LibraryApi
{
    public class ReturnBook: BookIssueCommonBookCode
    {
        public DateTime ReturnDate { get; set; }
    }
}
