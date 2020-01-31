using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Assignment1
{
    class Question_Bank
    {
        const int NO_OF_QUESTIONS = 12;
        const int NO_OF_ANSWERS = 4;

        Question_Unit[] questionBank = new Question_Unit[NO_OF_QUESTIONS];

        string fileName = "Trivia.txt";


        public int ReadQuestionFile()
        {
            string noQuestion;
            int index = 0;

            StreamReader filStream = new StreamReader(fileName);


            noQuestion = filStream.ReadLine();
            while (noQuestion != null)
            {
                questionBank[index] = new Question_Unit();
                questionBank[index].Question = noQuestion;

                for (int x = 0; x < NO_OF_ANSWERS; x++)
                {
                    questionBank[index].Answer[x] = filStream.ReadLine();
                }


                questionBank[index].CorrectAnswer = filStream.ReadLine();
                questionBank[index].Explanation = filStream.ReadLine();

                index++;
                noQuestion = filStream.ReadLine();
            }


            return index;

        }

        public string GetQuestion(int index)
        {
            return questionBank[index].Question;
        }
        public string[] GetAnswers(int index)
        {
            string[] answers = new string[NO_OF_ANSWERS];
            answers = questionBank[index].Answer;

            return answers;
        }
        public string GetCorrectAnswer(int index)
        {
            return questionBank[index].CorrectAnswer;
        }
        public string GetExplanation(int index)
        {
            return questionBank[index].Explanation;
        }

        public void ShowQuestions()
        {
            List<string> lines = new List<string>();
                lines = File.ReadAllLines(fileName).ToList();



            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }

        public void AddAQuestion(string question, string possA1, string possA2, string possA3, string possA4, string answer, string explain)
        {
            string questionasked = question;
            string possibleA1 = possA1;
            string possibleA2 = possA2;
            string possibleA3 = possA3;
            string possibleA4 = possA4;
            string correctanswer = answer;
            string explaination = explain;

            List<string> entries = new List<string>();
            entries = File.ReadAllLines(fileName).ToList();
            entries.Add(questionasked);
            entries.Add(possibleA1);
            entries.Add(possibleA2);
            entries.Add(possibleA3);
            entries.Add(possibleA4);
            entries.Add(correctanswer);
            entries.Add(explaination);

            File.WriteAllLines(fileName, entries);
        }
    }
}
