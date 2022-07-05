using System.Windows.Forms;
using System.Collections.Generic;
using System;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FriendQuizForm : Form
    {
        #region Members

        private FriendQuizLogic m_FriendQuizLogic;

        #endregion

        #region Constructor

        public FriendQuizForm(User i_Friend)
        {
            m_FriendQuizLogic = new FriendQuizLogic(i_Friend);
            InitializeComponent();
            intializeFormQuizFriendProperties();
            setControlsForNextQuestion();
        }

        #endregion

        #region Properties

        public User Friend
        {
            set
            {
                m_FriendQuizLogic = new FriendQuizLogic(value);
                setControlsForQuizToStart();
            }
        }

        #endregion

        private void setControlsForQuizToStart() 
        {
            buttonAnswer1.Enabled = buttonAnswer2.Enabled = buttonAnswer3.Enabled = buttonAnswer4.Enabled = true;
        }

        private void intializeFormQuizFriendProperties()
        {
            const string labelDefaultFormatFriend = "How well do you know";

            pictureBoxFriend.LoadAsync(m_FriendQuizLogic.FriendPhotoURL);
            labelTitleQuiz.Text = $"{labelDefaultFormatFriend}{Environment.NewLine}{m_FriendQuizLogic.FriendName}?";
        }

        private void setControlsForNextQuestion()
        {
            List<string> questionAnswers;
            bool isQuizEnd;

            labelQuestion.Text = m_FriendQuizLogic.RandomNextQuizQuestion(out questionAnswers, out isQuizEnd);

            if (!isQuizEnd)
            {
                buttonAnswer1.Text = $"{questionAnswers[0]}";
                buttonAnswer2.Text = $"{questionAnswers[1]}";
                buttonAnswer3.Text = $"{questionAnswers[2]}";
                buttonAnswer4.Text = $"{questionAnswers[3]}";
            }
            else
            {
                buttonAnswer1.Enabled = buttonAnswer2.Enabled = buttonAnswer3.Enabled = buttonAnswer4.Enabled = false;
            }
        }

        private void buttonAnswer1_Click(object sender, EventArgs e)
        {
            int buttonIndex = 1;

            buttonAnswerClick(buttonIndex);
        }

        private void buttonAnswer2_Click(object sender, EventArgs e)
        {
            int buttonIndex = 2;

            buttonAnswerClick(buttonIndex);
        }

        private void buttonAnswer3_Click(object sender, EventArgs e)
        {
            int buttonIndex = 3;

            buttonAnswerClick(buttonIndex);
        }

        private void buttonAnswer4_Click(object sender, EventArgs e)
        {
            int buttonIndex = 4;

            buttonAnswerClick(buttonIndex);
        }

        private void buttonAnswerClick(int buttonIndex)
        {
            m_FriendQuizLogic.CheckQuestion(buttonIndex);
            setControlsForNextQuestion();
        }
    }
}
