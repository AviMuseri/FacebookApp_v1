using System.Globalization;
using System.Collections.Generic;
using System;
using FacebookWrapper.ObjectModel;
using static FacebookWrapper.ObjectModel.User;

namespace BasicFacebookFeatures
{
    public class FriendQuizLogic
    {
        #region Members

        private const int k_LowResult = 2;
        private const int k_MediumResult = 4;
        private const int k_AmountOfAnswersPerQuestion = 4;
        private readonly User r_Friend;
        private readonly Random r_RandomQuestionAnswer = new Random();
        private readonly Dictionary<int, string> m_QuestionsBank = new Dictionary<int, string>
        {
            { 1, "In which year your friend born?" },
            { 2, "In which month your friend born?" },
            { 3, "In which day of the month your friend born?" },
            { 4, "What is the realationship status of your friend" }
        };

        private int m_AmountOfQuestionsThatWasAnswered;
        private Dictionary<int, string> m_QuestionsAnswers;
        private List<int> m_QuestionsAnswersNumbersForButtons;
        private int m_CorrectAnswers;
        private int m_CurrentQuestionIndex;
        private List<int> m_QuestionsNumbersThatWasAsked;

        #endregion

        #region Constructor

        public FriendQuizLogic(User i_Friend)
        {
            r_Friend = i_Friend;
            m_CorrectAnswers = 0;
            m_AmountOfQuestionsThatWasAnswered = 0;
            m_QuestionsNumbersThatWasAsked = new List<int>();
            initializeQuestionsAnswers();
            initializeQuestionsAnswersNumbersForButtons();
        }

        #endregion

        #region Properties

        public string FriendPhotoURL
        {
            get
            {
                return r_Friend.PictureNormalURL;
            }
        }

        public string FriendName
        {
            get
            {
                return r_Friend.Name;
            }
        }

        #endregion

        private void initializeQuestionsAnswers()
        {
            string formatBirthday = "d";
            CultureInfo providerForBirthDay = CultureInfo.InvariantCulture;

            DateTime friendBirthday = DateTime.ParseExact(r_Friend.Birthday, formatBirthday, providerForBirthDay);

            m_QuestionsAnswers = new Dictionary<int, string>
            {
                { 1, friendBirthday.Year.ToString() },
                { 2, friendBirthday.Month.ToString() },
                { 3, friendBirthday.Day.ToString() },
                { 4, r_Friend.RelationshipStatus.ToString() }
            };
        }

        private void initializeQuestionsAnswersNumbersForButtons()
        {
            m_QuestionsAnswersNumbersForButtons = new List<int>();
            for (int i = 0; i < m_QuestionsBank.Count; i++)
            {
                m_QuestionsAnswersNumbersForButtons.Add(r_RandomQuestionAnswer.Next(1, m_QuestionsBank.Count + 1));
            }
        }

        private string calculateTheResult()
        {
            string resultForQuiz;
            const string lowKnowYourFriend = "You do not know your friend at all.";
            const string midKnowYourFriend = "You know your friend but not to much.";
            const string perfectKnowYourFriend = "You know your friend superbly!";

            if (m_CorrectAnswers >= 0 && m_CorrectAnswers <= k_LowResult)
            {
                resultForQuiz = lowKnowYourFriend;
            }
            else if (m_CorrectAnswers >= k_LowResult && m_CorrectAnswers <= k_MediumResult)
            {
                resultForQuiz = midKnowYourFriend;
            }
            else
            {
                resultForQuiz = perfectKnowYourFriend;
            }

            return resultForQuiz;
        }

        public string RandomNextQuizQuestion(out List<string> o_AnswersForQuestion, out bool io_IsTheQuizEnds)
        {
            int nextQuestionIndex = r_RandomQuestionAnswer.Next(1, m_QuestionsBank.Count);

            if (m_AmountOfQuestionsThatWasAnswered < m_QuestionsBank.Count)
            {
                io_IsTheQuizEnds = false;
                while (m_QuestionsNumbersThatWasAsked.Contains(nextQuestionIndex))
                {
                    nextQuestionIndex = r_RandomQuestionAnswer.Next(1, m_QuestionsBank.Count);
                }

                m_CurrentQuestionIndex = nextQuestionIndex;
                m_AmountOfQuestionsThatWasAnswered++;
                o_AnswersForQuestion = randomQuestionsAnswers((eFriendQuestionType)m_CurrentQuestionIndex);
            }
            else
            {
                io_IsTheQuizEnds = true;
                o_AnswersForQuestion = null;
            }

            return io_IsTheQuizEnds ? calculateTheResult() : m_QuestionsBank[nextQuestionIndex];
        }

        public void CheckQuestion(int i_AnswerIndex)
        {
            if (m_QuestionsAnswersNumbersForButtons[m_CurrentQuestionIndex] == i_AnswerIndex)
            {
                m_CorrectAnswers++;
            }
        }

        #region Random Question Answers

        private List<string> randomQuestionsAnswers(eFriendQuestionType i_QuestionType)
        {
            int upperBoundMonth = 12;
            int lowerBoundMonth = 1;
            int upperBoundDay = 31;
            int lowerBoundDay = 1;
            int upperBoundYear = DateTime.Now.Year;
            int lowerBoundYear = 1950;
            List<string> questionAnswers = null;

            switch (i_QuestionType)
            {
                case eFriendQuestionType.Day:
                    questionAnswers = randomMonthDayYearQuestionAnswers(lowerBoundDay, upperBoundDay, i_QuestionType);
                    break;
                case eFriendQuestionType.Month:
                    questionAnswers = randomMonthDayYearQuestionAnswers(lowerBoundMonth, upperBoundMonth, i_QuestionType);
                    break;
                case eFriendQuestionType.Year:
                    questionAnswers = randomMonthDayYearQuestionAnswers(lowerBoundYear, upperBoundYear, i_QuestionType);
                    break;
                case eFriendQuestionType.RealationshipStatus:
                    questionAnswers = randomRealationshipStatusQuestionAnswers();
                    break;
            }

            return questionAnswers;
        }

        private List<string> randomMonthDayYearQuestionAnswers(int i_LowerBoundForRandom, int i_UpperBoundForRandom, eFriendQuestionType i_QuestionType)
        {
            List<string> answersForQuestion = new List<string>();
            string nextAnswer;

            answersForQuestion.Add(m_QuestionsAnswers[(int)i_QuestionType]);

            while (answersForQuestion.Count < k_AmountOfAnswersPerQuestion)
            {
                nextAnswer = r_RandomQuestionAnswer.Next(i_LowerBoundForRandom, i_UpperBoundForRandom + 1).ToString();

                while (answersForQuestion.Contains(nextAnswer))
                {
                    nextAnswer = r_RandomQuestionAnswer.Next(i_LowerBoundForRandom, i_UpperBoundForRandom + 1).ToString();
                }

                answersForQuestion.Add(nextAnswer);
            }

            return answersForQuestion;
        }

        private List<string> randomRealationshipStatusQuestionAnswers()
        {
            List<string> answersForQuestion = new List<string>();
            string nextAnswer;
            int upperBound = Enum.GetValues(typeof(eFriendQuestionType)).GetUpperBound(1);
            int lowerBound = Enum.GetValues(typeof(eFriendQuestionType)).GetLowerBound(1);

            while (answersForQuestion.Count < k_AmountOfAnswersPerQuestion)
            {
                nextAnswer = r_RandomQuestionAnswer.Next(lowerBound, upperBound + 1).ToString();

                while (answersForQuestion.Contains(nextAnswer))
                {
                    nextAnswer = r_RandomQuestionAnswer.Next(lowerBound, upperBound + 1).ToString();
                }

                answersForQuestion.Add(nextAnswer);
            }

            return answersForQuestion;
        }

        #endregion
    }
}
