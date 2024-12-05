public class Comment
{
    // Attributes
    private string name;
    private string text;

    // Constructor
    public Comment(string name, string text)
    {
        this.name = name;
        this.text = text;
    }

    // Methods
    public string GetCommentText()
    {
        return $"{name}: {text}";
    }
}
