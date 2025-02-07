#region Subject Class
class Subject
{
    public int SubjectId { get; set; }
    public string SubjectName { get; set; }
    public Exam Exam { get; set; }

    public Subject(int subjectId, string subjectName, Exam exam)
    {
        SubjectId = subjectId;
        SubjectName = subjectName;
        Exam = exam;
    }

    public void StartExam()
    {
        Console.WriteLine($"Starting Exam for Subject: {SubjectName}\n");
        Exam.ShowExam();
    }
}
#endregion