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

        public static string? GetTitle(Article? article)
        {
            if (article != null && article.Title != null)
            {
                string? title = article.Title.TrimStart("<h1>".ToCharArray());
                title = title.TrimEnd("</h1>".ToCharArray());

                if (title != null)
                {
                    return title;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
