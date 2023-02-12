using lab1;

//Exam practiceExam = new Exam();
//Exam finalExam = new Exam();

Console.WriteLine("hello");


Answer ans1 = new Answer();
ans1.A = true;


AnswersList answers = new AnswersList();
answers.Add(ans1);

Answer ans2 = new Answer();
ans2.C = true;
AnswersList answers2 = new AnswersList();
answers2.Add(ans1);
answers2.Add(ans2);



Question q1 = new Question("q1", "What is your name?", "2", "first Question", "Choose", answers);
Question q2 = new Question("q2", "What is your age?", "5", "second Question", "Choose", answers2);
Question q3 = new Question("q3", "What is your email?", "3", "third Question", "Choose", answers);
QuestionList questions= new QuestionList("questionList1");
questions.Add(q1);
questions.Add(q2);
questions.Add(q3);

Console.ReadLine();