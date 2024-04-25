using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhoWantsToBeAMillionaire
{
    internal class Question
    {
        public string Text { get; private set; }
        public string[] Answers { get; private set; }
        public int RightAnswer { get; private set; }
        public int Level { get; private set; }
        public Question(string[] s)
        {
            Text = s[0];
            Answers = new string[4];
            for (int i = 0; i < 4; i++)
                Answers[i] = s[i + 1];
            RightAnswer = int.Parse(s[5]);
            Level = int.Parse(s[6]);
        }

        public Question(SQLiteDataReader dr)
        {
            Text = dr["QuestionText"].ToString();
            RightAnswer = int.Parse(dr["RightAnswer"].ToString());
            Level = int.Parse(dr["Level"].ToString());
            Answers = new string[4] {dr["Answer 1"].ToString(), dr["Answer 2"].ToString(), dr["Answer 3"].ToString(), dr["Answer 4"].ToString()};

        }

    }

}
