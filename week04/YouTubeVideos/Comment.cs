using System;

public class Comment
{
    private string _name;
    private string _text;

    public Comment(string commenterName, string commentText)
    {
        _name = commenterName;
        _text = commentText;
    }


    public string GetCommenterName()
    {
        return _name;
    }
    public string GetComment()
    {
        return _text;
    }
}