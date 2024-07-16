namespace Bookmark.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Text { get; set; }

        public Article(string? title, string? text)
        {
            Title = title;
            Text = text;
        }
    }
}
