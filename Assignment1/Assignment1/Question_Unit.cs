using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class Question_Unit
    {
        string question;
        string[] answer = new string[4];
        string correctAnswer;
        string explanation;

        public string Question
        {
            set
            {
                question = value;
            }
            get
            {
                return question;
            }
        }

        public string[] Answer
        {
            set
            {
                answer = value;
            }
            get
            {
                return answer;
            }
        }


        public string CorrectAnswer
        {
            set
            {
                correctAnswer = value;
            }
            get
            {
                return correctAnswer;
            }
        }

        public string Explanation
        {
            set
            {
                explanation = value;
            }
            get
            {
                return explanation;
            }
        }

    }
}
