using System;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comment;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comment = new List<Comment>();
    }
    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetLengthSeconds()
    {
        return _length;
    }
    public void AddComment(string commenterName, string commentText)
    {
        _comment.Add(new Comment(commenterName, commentText));
    }
    public int GetNumberOfComment()
    {
        return _comment.Count;
    }
    public List<Comment> GetComments()
    {
        return new List<Comment>(_comment);
    }
}