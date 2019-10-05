using AssignmentWebAPIProject;
using System;

namespace LibraryApi
{
    public class BookIssue: BookIssueCommonBookCode
    {
        
        public DateTime IssueDate { get; set; }
    }
}
