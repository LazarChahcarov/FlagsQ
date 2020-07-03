using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlagsQuiz
{
    public partial class Form2 : Form
    {
        Random rnd = new Random();
        int questionNumber;
        int correctAnswer;
        int score = 0;
        int percentage;
        int totalQuestions;
        public Form2()
        {
            InitializeComponent();
            questionNumber = rnd.Next(1, 41);
            totalQuestions = questionNumber + 9;
            askQuestion(questionNumber);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new Form3()).Show();
            this.Hide();
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (PictureBox)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if (buttonTag == correctAnswer)
            {
                score++;
            }
            if (questionNumber == totalQuestions)
            {
                percentage = (int)Math.Round((double)(score * 100) / 10);
                MessageBox.Show(
                    "The Quiz is Done" + Environment.NewLine +
                    "You have answered " + score + " questions right" + Environment.NewLine +
                    "Your total percentage is " + percentage + "%" + Environment.NewLine +
                    "Thank you for playing"
                    );

                (new Form3()).Show();
                this.Hide();
            }
            questionNumber++;
            askQuestion(questionNumber);
        }

        private void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
               
                    lblQuestion.Text = "Guess the flag of Albania";
                    pictureBox1.Image = Properties.Resources.flag_of_Chile;
                    pictureBox2.Image = Properties.Resources.flag_of_Cambodia;
                    pictureBox3.Image = Properties.Resources.flag_of_Albania;
                    pictureBox4.Image = Properties.Resources.flag_of_Bulgaria;
                    correctAnswer = 3;
                    break;

                case 2:

                    lblQuestion.Text = "Guess the flag of Angola";
                    pictureBox1.Image = Properties.Resources.flag_of_China;
                    pictureBox2.Image = Properties.Resources.flag_of_Angola;
                    pictureBox3.Image = Properties.Resources.flag_of_Italy;
                    pictureBox4.Image = Properties.Resources.flag_of_Laos;
                    correctAnswer = 2;
                    break;

                case 3:

                    lblQuestion.Text = "Guess the flag of Argentina";
                    pictureBox1.Image = Properties.Resources.flag_of_Libya;
                    pictureBox2.Image = Properties.Resources.flag_of_Latvia;
                    pictureBox3.Image = Properties.Resources.flag_of_India;
                    pictureBox4.Image = Properties.Resources.flag_of_Argentina;
                    correctAnswer = 4;
                    break;

                case 4:

                    lblQuestion.Text = "Guess the flag of Australia";
                    pictureBox1.Image = Properties.Resources.flag_of_Australia;
                    pictureBox2.Image = Properties.Resources.flag_of_France;
                    pictureBox3.Image = Properties.Resources.flag_of_Georgia;
                    pictureBox4.Image = Properties.Resources.flag_of_Brazil;
                    correctAnswer = 1;
                    break;

                case 5:

                    lblQuestion.Text = "Guess the flag of Barbados";
                    pictureBox1.Image = Properties.Resources.flag_of_China;
                    pictureBox2.Image = Properties.Resources.flag_of_Barbados;
                    pictureBox3.Image = Properties.Resources.flag_of_Finland;
                    pictureBox4.Image = Properties.Resources.flag_of_Denmark;
                    correctAnswer = 2;
                    break;

                case 6:

                    lblQuestion.Text = "Guess the flag of Benin";
                    pictureBox1.Image = Properties.Resources.flag_of_Netherlands;
                    pictureBox2.Image = Properties.Resources.flag_of_Yemen;
                    pictureBox3.Image = Properties.Resources.flag_of_Ukraine;
                    pictureBox4.Image = Properties.Resources.flag_of_Benin;
                    correctAnswer = 4;
                    break;

                case 7:

                    lblQuestion.Text = "Guess the flag of Brazil";
                    pictureBox1.Image = Properties.Resources.flag_of_Tanzania;
                    pictureBox2.Image = Properties.Resources.flag_of_Brazil;
                    pictureBox3.Image = Properties.Resources.flag_of_South_Africa;
                    pictureBox4.Image = Properties.Resources.flag_of_Palau;
                    correctAnswer = 2;
                    break;

                case 8:

                    lblQuestion.Text = "Guess the flag of Bulgaria";
                    pictureBox1.Image = Properties.Resources.flag_of_Poland;
                    pictureBox2.Image = Properties.Resources.flag_of_Mexico;
                    pictureBox3.Image = Properties.Resources.flag_of_India;
                    pictureBox4.Image = Properties.Resources.flag_of_Bulgaria;
                    correctAnswer = 4;
                    break;

                case 9:

                    lblQuestion.Text = "Guess the flag of Cambodia";
                    pictureBox1.Image = Properties.Resources.flag_of_Cambodia;
                    pictureBox2.Image = Properties.Resources.flag_of_Germany;
                    pictureBox3.Image = Properties.Resources.flag_of_Israel;
                    pictureBox4.Image = Properties.Resources.flag_of_Jamaica;
                    correctAnswer = 1;
                    break;

                case 10:

                    lblQuestion.Text = "Guess the flag of Canada";
                    pictureBox1.Image = Properties.Resources.flag_of_Norway;
                    pictureBox2.Image = Properties.Resources.flag_of_Canada;
                    pictureBox3.Image = Properties.Resources.flag_of_Slovenia;
                    pictureBox4.Image = Properties.Resources.flag_of_Yemen;
                    correctAnswer = 2;
                    break;

                case 11:

                    lblQuestion.Text = "Guess the flag of Chile";
                    pictureBox1.Image = Properties.Resources.flag_of_Chile;
                    pictureBox2.Image = Properties.Resources.flag_of_Turkey;
                    pictureBox3.Image = Properties.Resources.flag_of_South_Africa;
                    pictureBox4.Image = Properties.Resources.flag_of_Romania;
                    correctAnswer = 1;
                    break;

                case 12:

                    lblQuestion.Text = "Guess the flag of China";
                    pictureBox1.Image = Properties.Resources.flag_of_Netherlands;
                    pictureBox2.Image = Properties.Resources.flag_of_China;
                    pictureBox3.Image = Properties.Resources.flag_of_Germany;
                    pictureBox4.Image = Properties.Resources.flag_of_Argentina;
                    correctAnswer = 2;
                    break;

                case 13:

                    lblQuestion.Text = "Guess the flag of Croatia";
                    pictureBox1.Image = Properties.Resources.flag_of_Benin;
                    pictureBox2.Image = Properties.Resources.flag_of_Germany;
                    pictureBox3.Image = Properties.Resources.flag_of_Croatia;
                    pictureBox4.Image = Properties.Resources.flag_of_Latvia;
                    correctAnswer = 3;
                    break;

                case 14:

                    lblQuestion.Text = "Guess the flag of Denmark";
                    pictureBox1.Image = Properties.Resources.flag_of_United_States_of_America;
                    pictureBox2.Image = Properties.Resources.flag_of_Denmark;
                    pictureBox3.Image = Properties.Resources.flag_of_Turkey;
                    pictureBox4.Image = Properties.Resources.flag_of_Georgia;
                    correctAnswer = 2;
                    break;

                case 15:

                    lblQuestion.Text = "Guess the flag of Finland";
                    pictureBox1.Image = Properties.Resources.flag_of_Australia;
                    pictureBox2.Image = Properties.Resources.flag_of_Hungary;
                    pictureBox3.Image = Properties.Resources.flag_of_Jamaica;
                    pictureBox4.Image = Properties.Resources.flag_of_Finland;
                    correctAnswer = 4;
                    break;

                case 16:

                    lblQuestion.Text = "Guess the flag of France";
                    pictureBox1.Image = Properties.Resources.flag_of_Latvia;
                    pictureBox2.Image = Properties.Resources.flag_of_Poland;
                    pictureBox3.Image = Properties.Resources.flag_of_France;
                    pictureBox4.Image = Properties.Resources.flag_of_Russia;
                    correctAnswer = 3;
                    break;

                case 17:

                    lblQuestion.Text = "Guess the flag of Georgia";
                    pictureBox1.Image = Properties.Resources.flag_of_Sweden;
                    pictureBox2.Image = Properties.Resources.flag_of_Georgia;
                    pictureBox3.Image = Properties.Resources.flag_of_Yemen;
                    pictureBox4.Image = Properties.Resources.flag_of_Tanzania;
                    correctAnswer = 2;
                    break;

                case 18:

                    lblQuestion.Text = "Guess the flag of Germany";
                    pictureBox1.Image = Properties.Resources.flag_of_Germany;
                    pictureBox2.Image = Properties.Resources.flag_of_Switzerland;
                    pictureBox3.Image = Properties.Resources.flag_of_South_Africa;
                    pictureBox4.Image = Properties.Resources.flag_of_Romania;
                    correctAnswer = 1;
                    break;

                case 19:

                    lblQuestion.Text = "Guess the flag of Hungary";
                    pictureBox1.Image = Properties.Resources.flag_of_Hungary;
                    pictureBox2.Image = Properties.Resources.flag_of_India;
                    pictureBox3.Image = Properties.Resources.flag_of_Jamaica;
                    pictureBox4.Image = Properties.Resources.flag_of_Laos;
                    correctAnswer = 1;
                    break;

                case 20:

                    lblQuestion.Text = "Guess the flag of India";
                    pictureBox1.Image = Properties.Resources.flag_of_North_Macedonia;
                    pictureBox2.Image = Properties.Resources.flag_of_Libya;
                    pictureBox3.Image = Properties.Resources.flag_of_India;
                    pictureBox4.Image = Properties.Resources.flag_of_Mexico;
                    correctAnswer = 4;
                    break;

                case 21:

                    lblQuestion.Text = "Guess the flag of Israel";
                    pictureBox1.Image = Properties.Resources.flag_of_Italy;
                    pictureBox2.Image = Properties.Resources.flag_of_Israel;
                    pictureBox3.Image = Properties.Resources.flag_of_Albania;
                    pictureBox4.Image = Properties.Resources.flag_of_Argentina;
                    correctAnswer = 2;
                    break;

                case 22:

                    lblQuestion.Text = "Guess the flag of Italy";
                    pictureBox1.Image = Properties.Resources.flag_of_Italy;
                    pictureBox2.Image = Properties.Resources.flag_of_Brazil;
                    pictureBox3.Image = Properties.Resources.flag_of_Chile;
                    pictureBox4.Image = Properties.Resources.flag_of_Denmark;
                    correctAnswer = 1;
                    break;

                case 23:

                    lblQuestion.Text = "Guess the flag of Jamaica";
                    pictureBox1.Image = Properties.Resources.flag_of_Germany;
                    pictureBox2.Image = Properties.Resources.flag_of_New_Zealand;
                    pictureBox3.Image = Properties.Resources.flag_of_Jamaica;
                    pictureBox4.Image = Properties.Resources.flag_of_Palau;
                    correctAnswer = 3;
                    break;

                case 24:

                    lblQuestion.Text = "Guess the flag of Japan";
                    pictureBox1.Image = Properties.Resources.flag_of_Poland;
                    pictureBox2.Image = Properties.Resources.flag_of_Slovenia;
                    pictureBox3.Image = Properties.Resources.flag_of_Yemen;
                    pictureBox4.Image = Properties.Resources.flag_of_Japan;
                    correctAnswer = 4;
                    break;

                case 25:

                    lblQuestion.Text = "Guess the flag of Laos";
                    pictureBox1.Image = Properties.Resources.flag_of_Tanzania;
                    pictureBox2.Image = Properties.Resources.flag_of_Laos;
                    pictureBox3.Image = Properties.Resources.flag_of_Portugal;
                    pictureBox4.Image = Properties.Resources.flag_of_Argentina;
                    correctAnswer = 2;
                    break;

                case 26:

                    lblQuestion.Text = "Guess the flag of Latvia";
                    pictureBox1.Image = Properties.Resources.flag_of_Australia;
                    pictureBox2.Image = Properties.Resources.flag_of_Brazil;
                    pictureBox3.Image = Properties.Resources.flag_of_Latvia;
                    pictureBox4.Image = Properties.Resources.flag_of_Canada;
                    correctAnswer = 3;
                    break;

                case 27:

                    lblQuestion.Text = "Guess the flag of Libya";
                    pictureBox1.Image = Properties.Resources.flag_of_Croatia;
                    pictureBox2.Image = Properties.Resources.flag_of_Georgia;
                    pictureBox3.Image = Properties.Resources.flag_of_Netherlands;
                    pictureBox4.Image = Properties.Resources.flag_of_Libya;
                    correctAnswer = 4;
                    break;

                case 28:

                    lblQuestion.Text = "Guess the flag of Mexico";
                    pictureBox1.Image = Properties.Resources.flag_of_Mexico;
                    pictureBox2.Image = Properties.Resources.flag_of_Norway;
                    pictureBox3.Image = Properties.Resources.flag_of_Portugal;
                    pictureBox4.Image = Properties.Resources.flag_of_Slovenia;
                    correctAnswer = 1;
                    break;

                case 29:

                    lblQuestion.Text = "Guess the flag of Netherlands";
                    pictureBox1.Image = Properties.Resources.flag_of_Spain;
                    pictureBox2.Image = Properties.Resources.flag_of_Tanzania;
                    pictureBox3.Image = Properties.Resources.flag_of_Netherlands;
                    pictureBox4.Image = Properties.Resources.flag_of_Ukraine;
                    correctAnswer = 3;
                    break;

                case 30:

                    lblQuestion.Text = "Guess the flag of New_Zealand";
                    pictureBox1.Image = Properties.Resources.flag_of_New_Zealand;
                    pictureBox2.Image = Properties.Resources.flag_of_United_Kingdom;
                    pictureBox3.Image = Properties.Resources.flag_of_Australia;
                    pictureBox4.Image = Properties.Resources.flag_of_Jamaica;
                    correctAnswer =1 ;
                    break;

                case 31:

                    lblQuestion.Text = "Guess the flag of Macedonia";
                    pictureBox1.Image = Properties.Resources.flag_of_Latvia;
                    pictureBox2.Image = Properties.Resources.flag_of_Mexico;
                    pictureBox3.Image = Properties.Resources.flag_of_Libya;
                    pictureBox4.Image = Properties.Resources.flag_of_North_Macedonia;
                    correctAnswer = 4;
                    break;

                case 32:

                    lblQuestion.Text = "Guess the flag of Norway";
                    pictureBox1.Image = Properties.Resources.flag_of_Japan;
                    pictureBox2.Image = Properties.Resources.flag_of_Brazil;
                    pictureBox3.Image = Properties.Resources.flag_of_Norway;
                    pictureBox4.Image = Properties.Resources.flag_of_Benin;
                    correctAnswer =3;
                    break;

                case 33:

                    lblQuestion.Text = "Guess the flag of Palau";
                    pictureBox1.Image = Properties.Resources.flag_of_Albania;
                    pictureBox2.Image = Properties.Resources.flag_of_Angola;
                    pictureBox3.Image = Properties.Resources.flag_of_Palau;
                    pictureBox4.Image = Properties.Resources.flag_of_Barbados;
                    correctAnswer = 3;
                    break;

                case 34:

                    lblQuestion.Text = "Guess the flag of Poland";
                    pictureBox1.Image = Properties.Resources.flag_of_Cambodia;
                    pictureBox2.Image = Properties.Resources.flag_of_China;
                    pictureBox3.Image = Properties.Resources.flag_of_Poland;
                    pictureBox4.Image = Properties.Resources.flag_of_Finland;
                    correctAnswer = 3;
                    break;

                case 35:

                    lblQuestion.Text = "Guess the flag of Portugal";
                    pictureBox1.Image = Properties.Resources.flag_of_France;
                    pictureBox2.Image = Properties.Resources.flag_of_Portugal;
                    pictureBox3.Image = Properties.Resources.flag_of_Germany;
                    pictureBox4.Image = Properties.Resources.flag_of_Italy;
                    correctAnswer =2;
                    break;

                case 36:

                    lblQuestion.Text = "Guess the flag of Romania";
                    pictureBox1.Image = Properties.Resources.flag_of_Romania;
                    pictureBox2.Image = Properties.Resources.flag_of_Laos;
                    pictureBox3.Image = Properties.Resources.flag_of_Mexico;
                    pictureBox4.Image = Properties.Resources.flag_of_Norway;
                    correctAnswer = 1;
                    break;

                case 37:

                    lblQuestion.Text = "Guess the flag of Russia";
                    pictureBox1.Image = Properties.Resources.flag_of_Portugal;
                    pictureBox2.Image = Properties.Resources.flag_of_Slovenia;
                    pictureBox3.Image = Properties.Resources.flag_of_South_Africa;
                    pictureBox4.Image = Properties.Resources.flag_of_Russia;
                    correctAnswer = 4;
                    break;

                case 38:

                    lblQuestion.Text = "Guess the flag of Slovenia";
                    pictureBox1.Image = Properties.Resources.flag_of_Slovenia;
                    pictureBox2.Image = Properties.Resources.flag_of_Tanzania;
                    pictureBox3.Image = Properties.Resources.flag_of_Togo;
                    pictureBox4.Image = Properties.Resources.flag_of_Norway;
                    correctAnswer =1 ;
                    break;

                case 39:

                    lblQuestion.Text = "Guess the flag of South Africa";
                    pictureBox1.Image = Properties.Resources.flag_of_Poland;
                    pictureBox2.Image = Properties.Resources.flag_of_Norway;
                    pictureBox3.Image = Properties.Resources.flag_of_Israel;
                    pictureBox4.Image = Properties.Resources.flag_of_South_Africa;
                    correctAnswer = 4;
                    break;

                case 40:

                    lblQuestion.Text = "Guess the flag of Spain";
                    pictureBox1.Image = Properties.Resources.flag_of_Jamaica;
                    pictureBox2.Image = Properties.Resources.flag_of_Spain;
                    pictureBox3.Image = Properties.Resources.flag_of_Canada;
                    pictureBox4.Image = Properties.Resources.flag_of_Brazil;
                    correctAnswer = 2;
                    break;

                case 41:

                    lblQuestion.Text = "Guess the flag of Sweden";
                    pictureBox1.Image = Properties.Resources.flag_of_Bulgaria;
                    pictureBox2.Image = Properties.Resources.flag_of_Barbados;
                    pictureBox3.Image = Properties.Resources.flag_of_Sweden;
                    pictureBox4.Image = Properties.Resources.flag_of_Angola;
                    correctAnswer =3 ;
                    break;

                case 42:

                    lblQuestion.Text = "Guess the flag of Switzerland";
                    pictureBox1.Image = Properties.Resources.flag_of_Barbados;
                    pictureBox2.Image = Properties.Resources.flag_of_Bulgaria;
                    pictureBox3.Image = Properties.Resources.flag_of_Switzerland;
                    pictureBox4.Image = Properties.Resources.flag_of_Cambodia;
                    correctAnswer =3 ;
                    break;

                case 43:

                    lblQuestion.Text = "Guess the flag of Tanzania";
                    pictureBox1.Image = Properties.Resources.flag_of_Tanzania;
                    pictureBox2.Image = Properties.Resources.flag_of_China;
                    pictureBox3.Image = Properties.Resources.flag_of_France;
                    pictureBox4.Image = Properties.Resources.flag_of_Germany;
                    correctAnswer =1;
                    break;

                case 44:

                    lblQuestion.Text = "Guess the flag of Thailand";
                    pictureBox1.Image = Properties.Resources.flag_of_Israel;
                    pictureBox2.Image = Properties.Resources.flag_of_Thailand;
                    pictureBox3.Image = Properties.Resources.flag_of_Jamaica;
                    pictureBox4.Image = Properties.Resources.flag_of_Libya;
                    correctAnswer = 2;
                    break;

                case 45:

                    lblQuestion.Text = "Guess the flag of Togo";
                    pictureBox1.Image = Properties.Resources.flag_of_New_Zealand;
                    pictureBox2.Image = Properties.Resources.flag_of_Palau;
                    pictureBox3.Image = Properties.Resources.flag_of_Togo;
                    pictureBox4.Image = Properties.Resources.flag_of_United_States_of_America;
                    correctAnswer = 3;
                    break;

                case 46:

                    lblQuestion.Text = "Guess the flag of Turkey";
                    pictureBox1.Image = Properties.Resources.flag_of_Turkey;
                    pictureBox2.Image = Properties.Resources.flag_of_Yemen;
                    pictureBox3.Image = Properties.Resources.flag_of_Romania;
                    pictureBox4.Image = Properties.Resources.flag_of_Russia;
                    correctAnswer =1 ;
                    break;

                case 47:

                    lblQuestion.Text = "Guess the flag of Ukraine";
                    pictureBox1.Image = Properties.Resources.flag_of_Romania;
                    pictureBox2.Image = Properties.Resources.flag_of_Ukraine;
                    pictureBox3.Image = Properties.Resources.flag_of_Netherlands;
                    pictureBox4.Image = Properties.Resources.flag_of_Georgia;
                    correctAnswer =2;
                    break;

                case 48:

                    lblQuestion.Text = "Guess the flag of UK";
                    pictureBox1.Image = Properties.Resources.flag_of_Germany;
                    pictureBox2.Image = Properties.Resources.flag_of_Benin;
                    pictureBox3.Image = Properties.Resources.flag_of_Barbados;
                    pictureBox4.Image = Properties.Resources.flag_of_United_Kingdom;
                    correctAnswer = 4;
                    break;

                case 49:

                    lblQuestion.Text = "Guess the flag of USA";
                    pictureBox1.Image = Properties.Resources.flag_of_Australia;
                    pictureBox2.Image = Properties.Resources.flag_of_Bulgaria;
                    pictureBox3.Image = Properties.Resources.flag_of_United_States_of_America;
                    pictureBox4.Image = Properties.Resources.flag_of_China;
                    correctAnswer = 3;
                    break;

                case 50:

                    lblQuestion.Text = "Guess the flag of Yemen";
                    pictureBox1.Image = Properties.Resources.flag_of_Yemen;
                    pictureBox2.Image = Properties.Resources.flag_of_Denmark;
                    pictureBox3.Image = Properties.Resources.flag_of_Jamaica;
                    pictureBox4.Image = Properties.Resources.flag_of_Portugal;
                    correctAnswer = 1;
                    break;

                


            }
        }
    }
}
