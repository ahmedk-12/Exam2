#region Question Class
abstract class Question
{
    public string Header { get; set; }
    public string Body { get; set; }
    public int Mark { get; set; }
    public List<Answer> AnswerList { get; set; }
    public Answer RightAnswer { get; set; }

    public Question(string header, string body, int mark, List<Answer> answerList, Answer rightAnswer)
    {
        Header = header;
        Body = body;
        Mark = mark;
        AnswerList = answerList;
        RightAnswer = rightAnswer;
    }

    public abstract void Display();
}
#endregion