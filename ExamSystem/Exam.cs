#region Exam Class
abstract class Exam
{
    public int Time { get; set; }
    public int NumberOfQuestions { get; set; }
    public List<Question> Questions { get; set; }

    public Exam(int time, int numberOfQuestions, List<Question> questions)
    {
        Time = time;
        NumberOfQuestions = numberOfQuestions;
        Questions = questions;
    }

    public abstract void ShowExam();
}
#endregion