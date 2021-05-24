using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRS
{
    public partial class Form1 : Form
    {
        //объявление переменных
        int num; // счетчик
        int number1, number2; // множители
        public Form1()
        {
            InitializeComponent();
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (num == 0)
            {
                // Считываем данные с ListBox
                number1 = Convert.ToInt32(listBox1.SelectedItem);
                num++;
            }
            else
            {
                // Считываем данные с ListBox
                number2 = Convert.ToInt32(listBox1.SelectedItem);

                int pr;
                pr = number1 * number2;

                label1.Text = pr.ToString(); //запись в Label

                num = 0; // обнуление счетчика
            }
            
        }
    }
}
