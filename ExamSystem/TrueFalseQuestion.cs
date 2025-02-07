#region True/False Question
class TrueFalseQuestion : Question
{
    public TrueFalseQuestion(string header, string body, int mark, List<Answer> answerList, Answer rightAnswer)
        : base(header, body, mark, answerList, rightAnswer) { }

    public override void Display()
    {
        Console.WriteLine($"{Header}\n{Body} (Mark: {Mark})");
        foreach (var ans in AnswerList)
        {
            Console.WriteLine($"{ans.AnswerId}. {ans.AnswerText}");
        }
    }
}
#endregion