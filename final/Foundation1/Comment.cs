using System;
public class Comment
{
    private string _author;
    private string _text;

    public Comment(string author, string text)
    {
        _author = author;
        _text = text;
    }

    public void DisplayComment()
    {
        Console.WriteLine($" - name: {_author}");
        Console.WriteLine($" - {_text}");
    }
}