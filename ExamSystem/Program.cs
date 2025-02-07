internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter number of questions: ");
        int numQuestions = int.Parse(Console.ReadLine());

        List<Question> questions = new List<Question>();

        for (int i = 1; i <= numQuestions; i++)
        {
            Console.Write($"Enter question {i} type (1 for True/False, 2 for MCQ): ");
            int type = int.Parse(Console.ReadLine());

            Console.Write("Enter question header: ");
            string header = Console.ReadLine();

            Console.Write("Enter question body: ");
            string body = Console.ReadLine();

            Console.Write("Enter question mark: ");
            int mark = int.Parse(Console.ReadLine());

            List<Answer> answers = new List<Answer>();
            Console.Write("Enter number of answers: ");
            int numAnswers = int.Parse(Console.ReadLine());

            for (int j = 1; j <= numAnswers; j++)
            {
                Console.Write($"Enter answer {j}: ");
                string answerText = Console.ReadLine();
                answers.Add(new Answer(j, answerText));
            }

            Console.Write("Enter the correct answer number: ");
            int correctAnswerIndex = int.Parse(Console.ReadLine()) - 1;
            Answer rightAnswer = answers[correctAnswerIndex];

            if (type == 1)
                questions.Add(new TrueFalseQuestion(header, body, mark, answers, rightAnswer));
            else
                questions.Add(new MCQQuestion(header, body, mark, answers, rightAnswer));
        }

        Console.Write("Enter exam duration in minutes: ");
        int time = int.Parse(Console.ReadLine());

        Console.Write("Enter exam type (1 for Final, 2 for Practical): ");
        int examType = int.Parse(Console.ReadLine());

        Exam exam = examType == 1 ? new FinalExam(time, numQuestions, questions) : new PracticalExam(time, numQuestions, questions);

        Console.Write("Enter subject ID: ");
        int subjectId = int.Parse(Console.ReadLine());

        Console.Write("Enter subject name: ");
        string subjectName = Console.ReadLine();

        Subject subject = new Subject(subjectId, subjectName, exam);
        subject.StartExam();
    }
}
