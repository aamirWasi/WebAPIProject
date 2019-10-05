using System;
namespace LibraryApi.Repositories
{
    public class ReturnBookRepository : IReturnBookRepository
    {
        private LibraryContext _context;
        public ReturnBookRepository(LibraryContext context)
        {
            _context = context;
        }

        public void IncreaseBook(Book book)
        {
            _context.Books.Update(book);
            Save();
        }

        public void InsertReturnBook(ReturnBook returnBook)
        {
            _context.ReturnBooks.Add(returnBook);
            Save();
        }

        private void Save()
        {
            _context.SaveChanges();
        }

        public void UpdateFine(Student student)
        {
            _context.Students.Update(student);
            Save();
        }
    }
}
