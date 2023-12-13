using System;
using System.Collections.Generic;

// Base class for comments
public class Comment
{
    // Attributes
    private string _commenterName;
    private string _commentText;

    // Constructor
    public Comment(string commenterName, string commentText)
    {
        _commenterName = commenterName;
        _commentText = commentText;
    }

    // Display comment details
    public void DisplayComment()
    {
        Console.WriteLine($"Comment by {_commenterName}: {_commentText}");
    }
}
