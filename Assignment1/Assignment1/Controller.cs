using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class Controller
    {

        public void Play()
        {
            int counter;
            string response = "Y";


            Welcome();

            do
            {
                Console.Clear();
                counter = PlayAgain();
                if (counter == 0)
                    response = "N";
                else
                {

                    Console.Write("\n\nWould you like to play again? (Y or N): ");
                    response = Console.ReadLine().ToUpper();
                    if (response.Length > 0)
                        response = response.Substring(0, 1);
                }
            }
            while (response == "Y");

            
        }

        public int PlayAgain()
        {
            int index = 0;
            int questionCount = 0;
            int totalCorrect;
            string userAnswer;
            string theCorrectAnswer;
            string[] possibleAnswers = new string[4];

            Question_Bank myQuestions = new Question_Bank();
            try
            {
                questionCount = myQuestions.ReadQuestionFile();
            }

            catch (System.IO.IOException exc)
            {
                Console.WriteLine("\n\n");
                Console.WriteLine(exc.Message);
            }


            totalCorrect = 0;

            while (index < questionCount)
            {
                Console.WriteLine("\n\n\n");
                Console.WriteLine("Question " + (index + 1) + ": \n");
                Console.WriteLine(myQuestions.GetQuestion(index));
                possibleAnswers = myQuestions.GetAnswers(index);
                Console.WriteLine("\n  A. " + possibleAnswers[0] + "\tB. " + possibleAnswers[1]);
                Console.WriteLine(" C. " + possibleAnswers[2] + "\tD. " + possibleAnswers[3]);

                Console.Write("\n\nWhat is your answer: ");
                userAnswer = Console.ReadLine().ToUpper();

                theCorrectAnswer = myQuestions.GetCorrectAnswer(index);

                if (userAnswer == theCorrectAnswer)
                {
                    Console.WriteLine("\nYou are correct!");
                    totalCorrect++;
                }
                else
                {
                    Console.WriteLine("\nSorry you are wrong\nThe correct answer is " + theCorrectAnswer);
                }

                Console.WriteLine("\n" + myQuestions.GetExplanation(index));

                index++;

                Console.WriteLine("\n\n\nPlease press the Enter key when you are ready to contnue");
                Console.ReadLine();
                Console.Clear();
            }



            if (questionCount != 0)
            {
                Console.Clear();
                Console.WriteLine("\n\n\n");
                Console.WriteLine("You had " + totalCorrect + " correct answers out of " + questionCount + " questions.");
                Console.WriteLine("This gives you a percentage of {0:P}", (double)totalCorrect / questionCount);
            }
            return questionCount;
        }

        public void UserInputAdd()
        {
            Question_Bank myQuestions = new Question_Bank();

            string question;
            string fPAnswer;
            string sPAnswer;
            string tPAnswer;
            string fthPAnswer;
            string answer;
            string explaintion;

            Console.Write("\n\nWhat is the question you want to add? ");
            question = Console.ReadLine();
            Console.Write("\n\nWhat is the first possible answer? ");
            fPAnswer = Console.ReadLine();
            Console.Write("\n\nWhat is the second possible answer? ");
            sPAnswer = Console.ReadLine();
            Console.Write("\n\nWhat is the third possible answer? ");
            tPAnswer = Console.ReadLine();
            Console.Write("\n\nWhat is the forth possible answer? ");
            fthPAnswer = Console.ReadLine();
            Console.Write("\n\nWhat is the Letter for the answer? (First = A, second = B, third = C, forth = D)");
            answer = Console.ReadLine().ToUpper();
            Console.Write("\n\nWhat is the explaintion of the answer for the question?");
            explaintion = Console.ReadLine();


            myQuestions.AddAQuestion(question, fPAnswer, sPAnswer, tPAnswer, fthPAnswer, answer, explaintion);
        }


        public void Welcome()
        {

            Console.WriteLine("\n\n\n");
            Console.WriteLine("\tLet's play a game of trivia.  You will be shown a series of questions,");
            Console.WriteLine("\tone at a time.  Each question will have four possible answers, only one");
            Console.WriteLine("\tis the correct answer.  Your job is to pick the correct answer.");
            Console.Write("\n\nPress the Enter key when you are ready to begin.  Good Luck     ");
            Console.ReadLine();

        }

        public void Exit()
        {
            Console.WriteLine("Thanks for Playing!");
            Console.WriteLine("Press Enter to Exit.");
        }


    }
}
