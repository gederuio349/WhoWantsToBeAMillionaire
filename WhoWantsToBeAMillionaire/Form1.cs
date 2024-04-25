using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhoWantsToBeAMillionaire
{
    public partial class Form1 : Form
    {

        List<Question> questions = new List<Question>();
        private Random rnd = new Random();
        int level = 0;
        bool margin_bool = false; // флаг для подсказки право на ошибку
        Question currentQuestion;
        Question new_currentQuestion; // для замены вопроса на тот же уровень

        public Form1()
        {

            InitializeComponent();
            ReadFile();
            startGame();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ReadFile()
        {
            string path = @"Вопросы.txt";

            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    questions.Add(new Question(line.Split('\t')));
                }
            }
        }

        private void ShowQuestion(Question q)
        {
            lblQuestion.Text = q.Text;
            btnAnswerA.Text = q.Answers[0];
            btnAnswerB.Text = q.Answers[1];
            btnAnswerC.Text = q.Answers[2];
            btnAnswerD.Text = q.Answers[3];
        }

        private void ShowQuestion_with_three_btn(Question q, Button btn) // Функция, для подсказки право на ошибку, которая показывает три варианта ответа
        {
            lblQuestion.Text = q.Text;
            btnAnswerA.Text = q.Answers[0];
            btnAnswerB.Text = q.Answers[1];
            btnAnswerC.Text = q.Answers[2];
            btnAnswerD.Text = q.Answers[3];
            btn.Enabled = false;
        }

        //private Question GetQuestion(int level)
        //{
        //    var questionsWithLevel = questions.Where(q => q.Level == level).ToList();
        //    return questionsWithLevel[rnd.Next(questionsWithLevel.Count)];
        //}

        private Question GetQuestion(int level)
        {
            SQLiteConnection cn = new SQLiteConnection();
            cn.ConnectionString = @"Data Source=WhoWantsToBeAMillionaire.db;Version=3";

            cn.Open();

            var cmd = new SQLiteCommand($@"select * from Questions WHERE Level={level} 
                                            order by Random() LIMIT 1", cn);

            var dr = cmd.ExecuteReader();
            dr.Read();
            Question q = new Question(dr);

            return q;
        }


        private void NextStep()
        {
            Button[] btns = new Button[] { btnAnswerA, btnAnswerB, btnAnswerC, btnAnswerD };

            foreach (Button btn in btns)
                btn.Enabled = true;

            level++;
            currentQuestion = GetQuestion(level);
            ShowQuestion(currentQuestion);
            lstLevel.SelectedIndex = lstLevel.Items.Count - level;
        }


        private void ChangeQuestion()  //замена вопроса на другой с тем же уровнем
        {
            Button[] btns = new Button[] { btnAnswerA, btnAnswerB, btnAnswerC, btnAnswerC };

            foreach (Button btn in btns)
                btn.Enabled = true;

            new_currentQuestion = GetQuestion(level);
            while (new_currentQuestion == currentQuestion) {
                new_currentQuestion = GetQuestion(level);
            }
            currentQuestion = new_currentQuestion;
            ShowQuestion(currentQuestion);
            lstLevel.SelectedIndex = lstLevel.Items.Count - level;
        }

        private void startGame()
        {
            level = 0;
            btnFiftyFifty.Enabled = true;
            btnMarginError.Enabled = true;
            btnChangeQuestion.Enabled = true;
            btnCallFriend.Enabled = true;
            bthHelpGuests.Enabled = true;
            NextStep();
        }


        private void btnAnswerA_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (currentQuestion.RightAnswer == int.Parse(button.Tag.ToString()))
                NextStep();
            else
            {
                if (margin_bool != true)
                {
                    MessageBox.Show("Неверный ответ!");
                    startGame();
                }
                else
                {
                    margin_bool = false;
                    ShowQuestion_with_three_btn(currentQuestion, btnAnswerA);
                }
            }
        }

        private void btnAnswerB_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (currentQuestion.RightAnswer == int.Parse(button.Tag.ToString()))
                NextStep();
            else
            {
                if (margin_bool != true)
                {
                    MessageBox.Show("Неверный ответ!");
                    startGame();
                }
                else
                {
                    margin_bool = false;
                    ShowQuestion_with_three_btn(currentQuestion, btnAnswerB);
                }
            }
        }

        private void btnAnswerC_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (currentQuestion.RightAnswer == int.Parse(button.Tag.ToString()))
                NextStep();
            else
            {
                if (margin_bool != true)
                {
                    MessageBox.Show("Неверный ответ!");
                    startGame();
                }
                else
                {
                    margin_bool = false;
                    ShowQuestion_with_three_btn(currentQuestion, btnAnswerC);
                }
            }
        }

        private void btnAnswerD_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (currentQuestion.RightAnswer == int.Parse(button.Tag.ToString()))
                NextStep();
            else
            {
                if (margin_bool != true)
                {
                    MessageBox.Show("Неверный ответ!");
                    startGame();
                }
                else 
                {
                    margin_bool = false;
                    ShowQuestion_with_three_btn(currentQuestion, btnAnswerD);
                }
            }
        }

        private void btnFiftyFifty_Click_1(object sender, EventArgs e)
        {


            Button[] btns = new Button[] { btnAnswerA, btnAnswerB,
                btnAnswerC, btnAnswerC };

            int count = 0;
            while (count < 2)
            {
                int n = rnd.Next(4);
                int answer = int.Parse(btns[n].Tag.ToString());

                if (answer != currentQuestion.RightAnswer && btns[n].Enabled)
                {
                    btns[n].Enabled = false;
                    count++;
                }

            btnFiftyFifty.Enabled = false;
            }
        }

        private void btnMarginError_Click(object sender, EventArgs e)
        {
            btnMarginError.Enabled = false;
            margin_bool = true;
        }

        private void btnChangeQuestion_Click(object sender, EventArgs e)
        {
            btnChangeQuestion.Enabled = false;
            ChangeQuestion();
            
        }

        private void btnCallFriend_Click(object sender, EventArgs e)
        {
            btnCallFriend.Enabled = false;
            // вывести новое окно с таймеров и маской телефона
        }

        private void bthHelpGuests_Click(object sender, EventArgs e)
        {
            bthHelpGuests.Enabled = false;
            // выводим диаграмму
        }
    }
}
