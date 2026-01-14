using System.Dynamic;
using System.Text;

namespace LibraryManagementSystem.Lib
{
    public record LoanRecord(int BookId, int BorrowedId, string BorrowDate, string DueDate, string? ReturnedDate)
    {
        public int BookId { get; set; } = BookId;
        public int BorrowerId { get; set; } = BorrowedId;
        public string BorrowDate { get; set; } = BorrowDate;
        public string DueDate { get; set; } = DueDate;
        public string? ReturnedDate { get; set; } = ReturnedDate;

        public override string ToString()
        {
            StringBuilder output = new();
            output.Append($"BookId: {BookId}");
            output.Append($"BorrowerId: {BorrowedId}");
            output.Append($"BorrowDate: {BorrowDate}");
            output.Append($"DueDate: {DueDate}");
            output.Append($"ReturnDate: {ReturnedDate}");
            return output.ToString();
        }
    }
}