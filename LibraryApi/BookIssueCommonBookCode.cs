using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentWebAPIProject
{
    public class BookIssueCommonBookCode
    {
        public int BookIssueId { get; set; }
        public int StudentId { get; set; }
        public string Barcode { get; set; }
        public int BookId { get; set; }
    }
}
