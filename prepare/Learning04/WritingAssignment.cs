using System;

public class WritingAssignment : Assigment
{
    private string _title;

    public WritingAssignment(string studentName, string title, string topic)
    : base(studentName,topic)
    {
        _title = title;
    }
    public string GetWritingInformation(){
        string studentName = GetStudentName();
        return $"{_title} by {studentName}";
    }
}