using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhoWantsToBeAMillionaire
{
    public partial class StartForm : Form
    {
        string username;

        public StartForm()
        {
            InitializeComponent();
        }



        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{
        //    username = ((TextBox)sender).Text;
        //    username2 = ((TextBox)sender).Text;

        //    this.Hide();
        //    var frm = new Form1();
        //    frm.ShowDialog();
        //}

        private void btnStart_Click(object sender, EventArgs e)
        {
            username = textBox1.Text;
            //прописать проверку на пустоту

            SQLiteConnection cn = new SQLiteConnection();
            cn.ConnectionString = @"Data Source=WhoWantsToBeAMillionaire.db;Version=3";
            cn.Open();

            var cmd = new SQLiteCommand($@"INSERT INTO Records(NAME, RECORD) VALUES({username}, {0})", cn); //тут дорабоатать


            this.Hide();
            var frm = new Form1();
            frm.ShowDialog();
        }
    }
}
