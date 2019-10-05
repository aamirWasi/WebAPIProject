using System;

namespace LibraryApi
{
    public class ReturnBook
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string Barcode { get; set; }
        public int BookId { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
