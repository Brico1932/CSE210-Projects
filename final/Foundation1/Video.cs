using System;
public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }
    public List<Comment> GetComments()
    {
        return _comments;
    }

    public int CountComments(Video vid)
    {
        List<Comment>Comments = vid.GetComments();
        int num_comments =0;
        foreach (Comment comment in Comments)
        {
            num_comments++;
        }
        return num_comments;
    }
    public void DisplayVidInfo(Video vid, int num_comments)
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of comments: {num_comments}");
    }
}