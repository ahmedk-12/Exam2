#region Final Exam
class FinalExam : Exam
{
    public FinalExam(int time, int numberOfQuestions, List<Question> questions)
        : base(time, numberOfQuestions, questions) { }

    public override void ShowExam()
    {
        int grade = 0;
        Console.WriteLine("Final Exam:");
        foreach (var question in Questions)
        {
            question.Display();
            Console.Write("Enter your answer: ");
            int userAnswer = int.Parse(Console.ReadLine());
            if (question.AnswerList[userAnswer - 1] == question.RightAnswer)
            {
                grade += question.Mark;
            }
        }
        Console.WriteLine($"Exam Completed.\n Your Grade: {grade}");
    }
}
#endregion