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
    public partial class Form4 : Form
    {
        Random rnd = new Random();
        int questionNumber;
        string correctAnswer;
        int score = 0;
        int percentage;
        int totalQuestions;
        public Form4()
        {
            InitializeComponent();
            questionNumber = rnd.Next(1, 41);
            totalQuestions = questionNumber + 9;
            askQuestion(questionNumber);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToLower() ==correctAnswer)
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
            switch(qnum){

                case 1:
                    pictureBox1.Image = Properties.Resources.flag_of_Albania;
                    label1.Text = "Guess the flag";
                    correctAnswer = "albania";
                    textBox1.Text = "";
                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.flag_of_Angola;
                    label1.Text = "Guess the flag";
                    correctAnswer = "angola";
                    textBox1.Text = "";
                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.flag_of_Argentina;
                    label1.Text = "Guess the flag";
                    correctAnswer = "argentin";
                    textBox1.Text = "";
                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.flag_of_Australia;
                    label1.Text = "Guess the flag";
                    correctAnswer = "australia";
                    textBox1.Text = "";
                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.flag_of_Barbados;
                    label1.Text = "Guess the flag";
                    correctAnswer = "barbados";
                    textBox1.Text = "";
                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.flag_of_Benin;
                    label1.Text = "Guess the flag";
                    correctAnswer = "benin";
                    textBox1.Text = "";
                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.flag_of_Brazil;
                    label1.Text = "Guess the flag";
                    correctAnswer = "brazil";
                    textBox1.Text = "";
                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources.flag_of_Bulgaria;
                    label1.Text = "Guess the flag";
                    correctAnswer = "bulgaria";
                    textBox1.Text = "";
                    break;

                case 9:
                    pictureBox1.Image = Properties.Resources.flag_of_Cambodia;
                    label1.Text = "Guess the flag";
                    correctAnswer = "cambodia";
                    textBox1.Text = "";
                    break;

                case 10:
                    pictureBox1.Image = Properties.Resources.flag_of_Canada;
                    label1.Text = "Guess the flag";
                    correctAnswer = "canada";
                    textBox1.Text = "";
                    break;

                case 11:
                    pictureBox1.Image = Properties.Resources.flag_of_Chile;
                    label1.Text = "Guess the flag";
                    correctAnswer = "chile";
                    textBox1.Text = "";
                    break;

                case 12:
                    pictureBox1.Image = Properties.Resources.flag_of_China;
                    label1.Text = "Guess the flag";
                    correctAnswer = "china";
                    textBox1.Text = "";
                    break;

                case 13:
                    pictureBox1.Image = Properties.Resources.flag_of_Croatia;
                    label1.Text = "Guess the flag";
                    correctAnswer = "croatia";
                    textBox1.Text = "";
                    break;

                case 14:
                    pictureBox1.Image = Properties.Resources.flag_of_Denmark;
                    label1.Text = "Guess the flag";
                    correctAnswer = "denmark";
                    textBox1.Text = "";
                    break;

                case 15:
                    pictureBox1.Image = Properties.Resources.flag_of_Finland;
                    label1.Text = "Guess the flag";
                    correctAnswer = "finland";
                    textBox1.Text = "";
                    break;

                case 16:
                    pictureBox1.Image = Properties.Resources.flag_of_France;
                    label1.Text = "Guess the flag";
                    correctAnswer = "france";
                    textBox1.Text = "";
                    break;

                case 17:
                    pictureBox1.Image = Properties.Resources.flag_of_Georgia;
                    label1.Text = "Guess the flag";
                    correctAnswer = "georgia";
                    textBox1.Text = "";
                    break;

                case 18:
                    pictureBox1.Image = Properties.Resources.flag_of_Germany;
                    label1.Text = "Guess the flag";
                    correctAnswer = "germany";
                    textBox1.Text = "";
                    break;

                case 19:
                    pictureBox1.Image = Properties.Resources.flag_of_Hungary;
                    label1.Text = "Guess the flag";
                    correctAnswer = "hungary";
                    textBox1.Text = "";
                    break;

                case 20:
                    pictureBox1.Image = Properties.Resources.flag_of_India;
                    label1.Text = "Guess the flag";
                    correctAnswer = "india";
                    textBox1.Text = "";
                    break;

                case 21:
                    pictureBox1.Image = Properties.Resources.flag_of_Israel;
                    label1.Text = "Guess the flag";
                    correctAnswer = "israel";
                    textBox1.Text = "";
                    break;

                case 22:
                    pictureBox1.Image = Properties.Resources.flag_of_Italy;
                    label1.Text = "Guess the flag";
                    correctAnswer = "italy";
                    textBox1.Text = "";
                    break;

                case 23:
                    pictureBox1.Image = Properties.Resources.flag_of_Jamaica;
                    label1.Text = "Guess the flag";
                    correctAnswer = "jamaica";
                    textBox1.Text = "";
                    break;

                case 24:
                    pictureBox1.Image = Properties.Resources.flag_of_Japan;
                    label1.Text = "Guess the flag";
                    correctAnswer = "japan";
                    textBox1.Text = "";
                    break;

                case 25:
                    pictureBox1.Image = Properties.Resources.flag_of_Laos;
                    label1.Text = "Guess the flag";
                    correctAnswer = "laos";
                    textBox1.Text = "";
                    break;

                case 26:
                    pictureBox1.Image = Properties.Resources.flag_of_Latvia;
                    label1.Text = "Guess the flag";
                    correctAnswer = "latvia";
                    textBox1.Text = "";
                    break;

                case 27:
                    pictureBox1.Image = Properties.Resources.flag_of_Libya;
                    label1.Text = "Guess the flag";
                    correctAnswer = "libya";
                    textBox1.Text = "";
                    break;

                case 28:
                    pictureBox1.Image = Properties.Resources.flag_of_Mexico;
                    label1.Text = "Guess the flag";
                    correctAnswer = "mexico";
                    textBox1.Text = "";
                    break;

                case 29:
                    pictureBox1.Image = Properties.Resources.flag_of_Netherlands;
                    label1.Text = "Guess the flag";
                    correctAnswer = "netherlands";
                    textBox1.Text = "";
                    break;

                case 30:
                    pictureBox1.Image = Properties.Resources.flag_of_New_Zealand;
                    label1.Text = "Guess the flag";
                    correctAnswer = "new zealand";
                    textBox1.Text = "";
                    break;

                case 31:
                    pictureBox1.Image = Properties.Resources.flag_of_North_Macedonia;
                    label1.Text = "Guess the flag";
                    correctAnswer = "macedonia";
                    textBox1.Text = "";
                    break;

                case 32:
                    pictureBox1.Image = Properties.Resources.flag_of_Norway;
                    label1.Text = "Guess the flag";
                    correctAnswer = "norway";
                    textBox1.Text = "";
                    break;

                case 33:
                    pictureBox1.Image = Properties.Resources.flag_of_Palau;
                    label1.Text = "Guess the flag";
                    correctAnswer = "palau";
                    textBox1.Text = "";
                    break;

                case 34:
                    pictureBox1.Image = Properties.Resources.flag_of_Poland;
                    label1.Text = "Guess the flag";
                    correctAnswer = "poland";
                    textBox1.Text = "";
                    break;

                case 35:
                    pictureBox1.Image = Properties.Resources.flag_of_Portugal;
                    label1.Text = "Guess the flag";
                    correctAnswer = "portugal";
                    textBox1.Text = "";
                    break;

                case 36:
                    pictureBox1.Image = Properties.Resources.flag_of_Romania;
                    label1.Text = "Guess the flag";
                    correctAnswer = "romania";
                    textBox1.Text = "";
                    break;

                case 37:
                    pictureBox1.Image = Properties.Resources.flag_of_Russia;
                    label1.Text = "Guess the flag";
                    correctAnswer = "russia";
                    textBox1.Text = "";
                    break;

                case 38:
                    pictureBox1.Image = Properties.Resources.flag_of_Slovenia;
                    label1.Text = "Guess the flag";
                    correctAnswer = "slovenia";
                    textBox1.Text = "";
                    break;

                case 39:
                    pictureBox1.Image = Properties.Resources.flag_of_South_Africa;
                    label1.Text = "Guess the flag";
                    correctAnswer = "south africa";
                    textBox1.Text = "";
                    break;

                case 40:
                    pictureBox1.Image = Properties.Resources.flag_of_Spain;
                    label1.Text = "Guess the flag";
                    correctAnswer = "spain";
                    textBox1.Text = "";
                    break;

                case 41:
                    pictureBox1.Image = Properties.Resources.flag_of_Sweden;
                    label1.Text = "Guess the flag";
                    correctAnswer = "sweden";
                    textBox1.Text = "";
                    break;

                case 42:
                    pictureBox1.Image = Properties.Resources.flag_of_Switzerland;
                    label1.Text = "Guess the flag";
                    correctAnswer = "switzerland";
                    textBox1.Text = "";
                    break;

                case 43:
                    pictureBox1.Image = Properties.Resources.flag_of_Tanzania;
                    label1.Text = "Guess the flag";
                    correctAnswer = "tanzania";
                    textBox1.Text = "";
                    break;

                case 44:
                    pictureBox1.Image = Properties.Resources.flag_of_Thailand;
                    label1.Text = "Guess the flag";
                    correctAnswer = "thailand";
                    textBox1.Text = "";
                    break;

                case 45:
                    pictureBox1.Image = Properties.Resources.flag_of_Togo;
                    label1.Text = "Guess the flag";
                    correctAnswer = "togo";
                    textBox1.Text = "";
                    break;

                case 46:
                    pictureBox1.Image = Properties.Resources.flag_of_Turkey;
                    label1.Text = "Guess the flag";
                    correctAnswer = "turkey";
                    textBox1.Text = "";
                    break;

                case 47:
                    pictureBox1.Image = Properties.Resources.flag_of_Ukraine;
                    label1.Text = "Guess the flag";
                    correctAnswer = "ukraine";
                    textBox1.Text = "";
                    break;

                case 48:
                    pictureBox1.Image = Properties.Resources.flag_of_United_Kingdom;
                    label1.Text = "Guess the flag";
                    correctAnswer = "uk";
                    textBox1.Text = "";
                    break;

                case 49:
                    pictureBox1.Image = Properties.Resources.flag_of_United_States_of_America;
                    label1.Text = "Guess the flag";
                    correctAnswer = "usa";
                    textBox1.Text = "";
                    break;

                case 50:
                    pictureBox1.Image = Properties.Resources.flag_of_Yemen;
                    label1.Text = "Guess the flag";
                    correctAnswer = "yemen";
                    textBox1.Text = "";
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new Form3()).Show();
            this.Hide();
        }

       
    }
}
