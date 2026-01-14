using System.Text;

namespace LibraryManagementSystem.Lib
{
    public class Book(int id, string title, string author, string genre, bool IsAvailable)
    {
        public int Id { get; set; } = id;
        public string Title { get; set; } = title;
        public string Author { get; set; } = author;
        public string Genre { get; set; } = genre;
        public bool IsAvailable { get; set; } = IsAvailable;

        public void ChangeAvailability()
        {
            IsAvailable = IsAvailable == false;
        }

        public override bool Equals(object? obj)
        {
            var type = obj!.GetType;
            if (!type.Equals(this) || obj == null) return false;
            Book Book = (Book)obj;
            return Book.Id == Id;
        }

        public override string ToString()
        {
            StringBuilder output = new();
            output.AppendLine($"BookId: {Id}");
            output.AppendLine($"BookTitle: {Title}");
            output.AppendLine($"BookAuthor: {Author}");
            output.AppendLine($"BookGenre: {Genre}");
            output.AppendLine($"IsAvaillable: {IsAvailable}");
            return output.ToString();
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}