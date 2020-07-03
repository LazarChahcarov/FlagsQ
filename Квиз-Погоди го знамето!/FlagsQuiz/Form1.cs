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
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int questionNumber;
        int correctAnswer;
        int score=0;
        int percentage;
        int totalQuestions;
        

        public Form1()
        {
            InitializeComponent();
            questionNumber = rnd.Next(1, 41);
            totalQuestions = questionNumber+9;
            askQuestion(questionNumber);
        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }
        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
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
                    "You have answered "+score+ " questions right" +Environment.NewLine +
                    "Your total percentage is "+percentage+"%" + Environment.NewLine +
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
                    pictureBox1.Image = Properties.Resources.flag_of_Albania;
                    lblQuestion.Text = "Guess the flag";
                    button1.Text = "Yemen";
                    button2.Text = "Chile";
                    button3.Text = "Albania";
                    button4.Text = "Iran";
                    correctAnswer =3;
                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.flag_of_Angola;
                    lblQuestion.Text = "Guess the flag";
                    button1.Text = "Uruguay";
                    button2.Text = "Moldova";
                    button3.Text = "Azerbaijan";
                    button4.Text = "Angola";
                    correctAnswer =4;
                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.flag_of_Argentina;
                    lblQuestion.Text = "Guess the flag";
                    button1.Text = "Argentina";
                    button2.Text = "Belarus";
                    button3.Text = "Nepal";
                    button4.Text = "Oman";
                    correctAnswer =1;
                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.flag_of_Australia;
                    lblQuestion.Text = "Guess the flag";
                    button1.Text = "Malta";
                    button2.Text = "Australia";
                    button3.Text = "Taiwan";
                    button4.Text = "Liechtenstein";
                    correctAnswer =2;
                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.flag_of_Barbados;
                    lblQuestion.Text = "Guess the flag";
                    button1.Text = "Botswana";
                    button2.Text = "Barbados";
                    button3.Text = "Haiti";
                    button4.Text = "Iceland";
                    correctAnswer =2;
                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.flag_of_Benin;
                    lblQuestion.Text = "Guess the flag";
                    button1.Text = "Cameroon";
                    button2.Text = "Albania";
                    button3.Text = "Guatemala";
                    button4.Text = "Benin";
                    correctAnswer =4;
                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.flag_of_Brazil;
                    lblQuestion.Text = "Guess the flag";
                    button1.Text = "Brazil";
                    button2.Text = "Panama";
                    button3.Text = "Philippines";
                    button4.Text = "Lesotho";
                    correctAnswer =1;
                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources.flag_of_Bulgaria;
                    lblQuestion.Text = "Guess the flag";
                    button1.Text = "Cuba";
                    button2.Text = "Montenegro";
                    button3.Text = "Bulgaria";
                    button4.Text = "Liechtenstein";
                    correctAnswer =3;
                    break;

                case 9:
                    pictureBox1.Image = Properties.Resources.flag_of_Cambodia;
                    lblQuestion.Text = "Guess the flag";
                    button1.Text = "Albania";
                    button2.Text = "Kenya";
                    button3.Text = "Kiribati";
                    button4.Text = "Cambodia";
                    correctAnswer =4;
                    break;

                case 10:
                    pictureBox1.Image = Properties.Resources.flag_of_Canada;
                    lblQuestion.Text = "Guess the flag";
                    button1.Text = "San Marino";
                    button2.Text = "Canada";
                    button3.Text = "Chile";
                    button4.Text = "Hungary";
                    correctAnswer =2;
                    break;

                case 11:
                    pictureBox1.Image = Properties.Resources.flag_of_Chile;
                    lblQuestion.Text = "Guess the flag";
                    button1.Text = "Guinea";
                    button2.Text = "Chile";
                    button3.Text = "Serbia";
                    button4.Text = "Egypt";
                    correctAnswer =2;
                    break;

                case 12:
                    pictureBox1.Image = Properties.Resources.flag_of_China;
                    lblQuestion.Text = "Guess the flag";
                    button1.Text = "Haiti";
                    button2.Text = "Yemen";
                    button3.Text = "China";
                    button4.Text = "Albania";
                    correctAnswer =3;
                    break;

                case 13:
                    pictureBox1.Image = Properties.Resources.flag_of_Croatia;
                    lblQuestion.Text = "Guess the flag";
                    button1.Text = "Croatia";
                    button2.Text = "Angola";
                    button3.Text = "Iraq";
                    button4.Text = "Indonesia";
                    correctAnswer =1;
                    break;

                case 14:
                    pictureBox1.Image = Properties.Resources.flag_of_Denmark;
                    lblQuestion.Text = "Guess the flag";
                    button1.Text = "Taiwan";
                    button2.Text = "Oman";
                    button3.Text = "Denmark";
                    button4.Text = "Iceland";
                    correctAnswer =3;
                    break;

                case 15:
                    pictureBox1.Image = Properties.Resources.flag_of_Finland;
                    lblQuestion.Text = "Guess the flag";
                    button1.Text = "Jordan";
                    button2.Text = "Finland";
                    button3.Text = "Panama";
                    button4.Text = "Indonesia";
                    correctAnswer =2;
                    break;

                case 16:
                    pictureBox1.Image = Properties.Resources.flag_of_France;
                    lblQuestion.Text = "Guess the flag";
                    button1.Text = "Lebanon";
                    button2.Text = "Iran";
                    button3.Text = "Belarus";
                    button4.Text = "France";
                    correctAnswer =4;
                    break;

                case 17:
                    pictureBox1.Image = Properties.Resources.flag_of_Georgia;
                    lblQuestion.Text = "Guess the flag";
                    button1.Text = "Malta";
                    button2.Text = "Georgia";
                    button3.Text = "Nepal";
                    button4.Text = "Zambia";
                    correctAnswer =2;
                    break;

                case 18:
                    pictureBox1.Image = Properties.Resources.flag_of_Germany;
                    lblQuestion.Text = "Guess the flag";
                    button1.Text = "Yemen";
                    button2.Text = "Philippines";
                    button3.Text = "Botswana";
                    button4.Text = "Germany";
                    correctAnswer =4;
                    break;

                case 19:
                    pictureBox1.Image = Properties.Resources.flag_of_Hungary;
                    lblQuestion.Text = "Guess the flag";
                    button1.Text = "Moldova";
                    button2.Text = "Cameroon";
                    button3.Text = "Hungary";
                    button4.Text = "Kenya";
                    correctAnswer =3;
                    break;

                case 20:
                    pictureBox1.Image = Properties.Resources.flag_of_India;
                    lblQuestion.Text = "Guess the flag";
                    button1.Text = "Ghana";
                    button2.Text = "Montenegro";
                    button3.Text = "Azerbaijan";
                    button4.Text = "India";
                    correctAnswer =4;
                    break;

                case 21:
                    pictureBox1.Image = Properties.Resources.flag_of_Israel;
                    lblQuestion.Text = "Guess the flag";
                    button1.Text = "Israel";
                    button2.Text = "South Korea";
                    button3.Text = "Taiwan";
                    button4.Text = "Switzerland";
                    correctAnswer =1;
                    break;

                case 22:
                    pictureBox1.Image = Properties.Resources.flag_of_Italy;
                    lblQuestion.Text = "Guess the flag";
                    button1.Text = "Lesotho";
                    button2.Text = "Italy";
                    button3.Text = "Croatia";
                    button4.Text = "Poland";
                    correctAnswer =2;
                    break;

                case 23:
                    pictureBox1.Image = Properties.Resources.flag_of_Jamaica;
                    lblQuestion.Text = "Guess the flag";
                    button1.Text = "Switzerland";
                    button2.Text = "Jamaica";
                    button3.Text = "Cuba";
                    button4.Text = "Guinea";
                    correctAnswer =2;
                    break;

                case 24:
                    pictureBox1.Image = Properties.Resources.flag_of_Japan;
                    lblQuestion.Text = "Guess the flag";
                    button1.Text = "Oman";
                    button2.Text = "Japan";
                    button3.Text = "Uruguay";
                    button4.Text = "Malta";
                    correctAnswer =2;
                    break;

                case 25:
                    pictureBox1.Image = Properties.Resources.flag_of_Laos;
                    lblQuestion.Text = "Guess the flag";
                    button1.Text = "Philippines";
                    button2.Text = "Nepal";
                    button3.Text = "Laos";
                    button4.Text = "Serbia";
                    correctAnswer =3;
                    break;

                case 26:
                    pictureBox1.Image = Properties.Resources.flag_of_Latvia;
                    lblQuestion.Text = "Guess the flag";
                    button1.Text = "Latvia";
                    button2.Text = "Belarus";
                    button3.Text = "Panama";
                    button4.Text = "Kiribati";
                    correctAnswer =1;
                    break;

                case 27:
                    pictureBox1.Image = Properties.Resources.flag_of_Libya;
                    lblQuestion.Text = "Guess the flag";
                    button1.Text = "Libya";
                    button2.Text = "Guinea";
                    button3.Text = "Suriname";
                    button4.Text = "Sudan";
                    correctAnswer =1;
                    break;

                case 28:
                    pictureBox1.Image = Properties.Resources.flag_of_Mexico;
                    lblQuestion.Text = "Guess the flag";
                    button1.Text = "San Marino";
                    button2.Text = "Albania";
                    button3.Text = "Egypt";
                    button4.Text = "Mexico";
                    correctAnswer =4;
                    break;

                case 29:
                    pictureBox1.Image = Properties.Resources.flag_of_Netherlands;
                    lblQuestion.Text = "Guess the flag";
                    button1.Text = "Georgia";
                    button2.Text = "Yemen";
                    button3.Text = "Netherlands";
                    button4.Text = "Estonia";
                    correctAnswer =3;
                    break;

                case 30:
                    pictureBox1.Image = Properties.Resources.flag_of_New_Zealand;
                    lblQuestion.Text = "Guess the flag";
                    button1.Text = "Iran";
                    button2.Text = "Kenya";
                    button3.Text = "New_Zealand";
                    button4.Text = "Poland";
                    correctAnswer =3;
                    break;

                case 31:
                    pictureBox1.Image = Properties.Resources.flag_of_North_Macedonia;
                    lblQuestion.Text = "Guess the flag";
                    button1.Text = "Oman";
                    button2.Text = "Macedonia";
                    button3.Text = "Chile";
                    button4.Text = "Iceland";
                    correctAnswer =2;
                    break;

                case 32:
                    pictureBox1.Image = Properties.Resources.flag_of_Norway;
                    lblQuestion.Text = "Guess the flag";
                    button1.Text = "Norway";
                    button2.Text = "Angola";
                    button3.Text = "Hungary";
                    button4.Text = "Guinea";
                    correctAnswer =1;
                    break;

                case 33:
                    pictureBox1.Image = Properties.Resources.flag_of_Palau;
                    lblQuestion.Text = "Guess the flag";
                    button1.Text = "Moldova";
                    button2.Text = "Albania";
                    button3.Text = "Palau";
                    button4.Text = "Cameroon";
                    correctAnswer =3;
                    break;

                case 34:
                    pictureBox1.Image = Properties.Resources.flag_of_Poland;
                    lblQuestion.Text = "Guess the flag";
                    button1.Text = "Uruguay";
                    button2.Text = "Montenegro";
                    button3.Text = "Poland";
                    button4.Text = "Malta";
                    correctAnswer =3;
                    break;

                case 35:
                    pictureBox1.Image = Properties.Resources.flag_of_Portugal;
                    lblQuestion.Text = "Guess the flag";
                    button1.Text = "Greece";
                    button2.Text = "San Marino";
                    button3.Text = "Azerbaijan";
                    button4.Text = "Portugal";
                    correctAnswer =4;
                    break;

                case 36:
                    pictureBox1.Image = Properties.Resources.flag_of_Romania;
                    lblQuestion.Text = "Guess the flag";
                    button1.Text = "Romania";
                    button2.Text = "South Korea";
                    button3.Text = "Yemen";
                    button4.Text = "Cuba";
                    correctAnswer =1;
                    break;

                case 37:
                    pictureBox1.Image = Properties.Resources.flag_of_Russia;
                    lblQuestion.Text = "Guess the flag";
                    button1.Text = "Hungary";
                    button2.Text = "Russia";
                    button3.Text = "Lesotho";
                    button4.Text = "Kosovo";
                    correctAnswer =2;
                    break;

                case 38:
                    pictureBox1.Image = Properties.Resources.flag_of_Slovenia;
                    lblQuestion.Text = "Guess the flag";
                    button1.Text = "Slovakia";
                    button2.Text = "Panama";
                    button3.Text = "Slovenia";
                    button4.Text = "Guatemala";
                    correctAnswer =3;
                    break;

                case 39:
                    pictureBox1.Image = Properties.Resources.flag_of_South_Africa;
                    lblQuestion.Text = "Guess the flag";
                    button1.Text = "Moldova";
                    button2.Text = "South Africa";
                    button3.Text = "Croatia";
                    button4.Text = "Guatemala";
                    correctAnswer =2;
                    break;

                case 40:
                    pictureBox1.Image = Properties.Resources.flag_of_Spain;
                    lblQuestion.Text = "Guess the flag";
                    button1.Text = "Philippines";
                    button2.Text = "Cameroon";
                    button3.Text = "Botswana";
                    button4.Text = "Spain";
                    correctAnswer =4;
                    break;

                case 41:
                    pictureBox1.Image = Properties.Resources.flag_of_Sweden;
                    lblQuestion.Text = "Guess the flag";
                    button1.Text = "Georgia";
                    button2.Text = "Sweden";
                    button3.Text = "Egypt";
                    button4.Text = "Kiribati";
                    correctAnswer =2;
                    break;

                case 42:
                    pictureBox1.Image = Properties.Resources.flag_of_Switzerland;
                    lblQuestion.Text = "Guess the flag";
                    button1.Text = "Nepal";
                    button2.Text = "Oman";
                    button3.Text = "Switzerland";
                    button4.Text = "Panama";
                    correctAnswer =3;
                    break;

                case 43:
                    pictureBox1.Image = Properties.Resources.flag_of_Tanzania;
                    lblQuestion.Text = "Guess the flag";
                    button1.Text = "Iran";
                    button2.Text = "Serbia";
                    button3.Text = "Azerbaijan";
                    button4.Text = "Tanzania";
                    correctAnswer =4;
                    break;

                case 44:
                    pictureBox1.Image = Properties.Resources.flag_of_Thailand;
                    lblQuestion.Text = "Guess the flag";
                    button1.Text = "Kenya";
                    button2.Text = "Angola";
                    button3.Text = "Kosovo";
                    button4.Text = "Thailand";
                    correctAnswer =4;
                    break;

                case 45:
                    pictureBox1.Image = Properties.Resources.flag_of_Togo;
                    lblQuestion.Text = "Guess the flag";
                    button1.Text = "Nepal";
                    button2.Text = "Chile";
                    button3.Text = "Malta";
                    button4.Text = "Togo";
                    correctAnswer =4;
                    break;

                case 46:
                    pictureBox1.Image = Properties.Resources.flag_of_Turkey;
                    lblQuestion.Text = "Guess the flag";
                    button1.Text = "Greece";
                    button2.Text = "Turkey";
                    button3.Text = "Yemen";
                    button4.Text = "Estonia";
                    correctAnswer =2;
                    break;

                case 47:
                    pictureBox1.Image = Properties.Resources.flag_of_Ukraine;
                    lblQuestion.Text = "Guess the flag";
                    button1.Text = "Uruguay";
                    button2.Text = "Slovakia";
                    button3.Text = "Belarus";
                    button4.Text = "Ukraine";
                    correctAnswer =4;
                    break;

                case 48:
                    pictureBox1.Image = Properties.Resources.flag_of_United_Kingdom;
                    lblQuestion.Text = "Guess the flag";
                    button1.Text = "Taiwan";
                    button2.Text = "South Korea";
                    button3.Text = "UK";
                    button4.Text = "Albania";
                    correctAnswer =3;
                    break;

                case 49:
                    pictureBox1.Image = Properties.Resources.flag_of_United_States_of_America;
                    lblQuestion.Text = "Guess the flag";
                    button1.Text = "San Marino";
                    button2.Text = "Montenegro";
                    button3.Text = "USA";
                    button4.Text = "Philippines";
                    correctAnswer =3;
                    break;

                case 50:
                    pictureBox1.Image = Properties.Resources.flag_of_Yemen;
                    lblQuestion.Text = "Guess the flag";
                    button1.Text = "Yemen";
                    button2.Text = "Moldova";
                    button3.Text = "Angola";
                    button4.Text = "Botswana";
                    correctAnswer =1;
                    break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            (new Form3()).Show();
            this.Hide();
        }
    }
}
