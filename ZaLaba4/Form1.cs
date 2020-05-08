using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            cnisok.Items.Add("Москва");
            cnisok.Items.Add("Париж");
            cnisok.Items.Add("Лондон");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SecondLocal_Click(object sender, EventArgs e)
        {


        }


        private void cnisok_SelectedIndexChanged(object sender, EventArgs e)
        {

           



        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Invoke(new Action(() =>
            {
                DateTime now = DateTime.Now;
                hourLocal.Text = now.Hour.ToString();
                MinuteLocal.Text = now.Minute.ToString();
                SecondLocal.Text = now.Second.ToString();

                DateTime UtcNow = DateTime.UtcNow;
                hourUT.Text = UtcNow.Hour.ToString();
                MinuteUT.Text = UtcNow.Minute.ToString();
                SecondUT.Text = UtcNow.Second.ToString();

                if (cnisok.SelectedIndex == 0)
                {


                    hourTime.Text = now.AddHours(-1).Hour.ToString();
                    MinuteTime.Text = now.Minute.ToString();
                    SecondTime.Text = now.Second.ToString();
                }
                if (cnisok.SelectedIndex == 1)
                {


                    hourTime.Text = now.AddHours(-2).Hour.ToString();
                    MinuteTime.Text = now.AddMinutes(+2).Minute.ToString();
                    SecondTime.Text = now.Second.ToString();
                }
                if (cnisok.SelectedIndex == 2)
                {

                    hourTime.Text = now.AddHours(-3).Hour.ToString();
                    MinuteTime.Text = now.AddMinutes(+3).Minute.ToString();
                    SecondTime.Text = now.Second.ToString();
                }
            }));
        }
    }
}




