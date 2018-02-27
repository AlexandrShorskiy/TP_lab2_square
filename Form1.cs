using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Numerics;

namespace TP_lab2_square
{
    public partial class Form1 : Form
    {
        static string s_x1, s_x2, s_d;

        public Form1()
        {
            InitializeComponent();
        }
        //метод вычисляет дискриминант и значения Х1 и Х2
        private static void Equation1(double a, double b, double c)
        {
            double D = Math.Pow(b, 2) - 4 * a * c;
            double x1 = 0, x2 = 0;
            if (D > 0)
            {
                x1 = (-b - Math.Sqrt(D)) / (2 * a);
                x2 = (-b + Math.Sqrt(D)) / (2 * a);
                s_x1 = "X1 = " + Math.Round(x1, 2).ToString();
                s_x2 = "X2 = " + Math.Round(x2, 2).ToString();
            }
            if (D == 0)
            {
                x1 = (-b) / (2 * a);
                x2 = x1;
                s_x1 = "X1 = " + Math.Round(x1, 2).ToString();
                s_x2 = "X2 = " + Math.Round(x2, 2).ToString();
            }
            if (D < 0)
            {
                var res = Solve(a, b, c);
                s_x1 = "X1 = " + String.Format(new ComplexFormatter(), "{0:I0}", res.Item1);
                s_x2 = "X2 = " + String.Format(new ComplexFormatter(), "{0:I0}", res.Item2);
            }
            s_d = "D = " + Math.Round(D, 2).ToString();
        }
        //проверка ввода
        private static bool ValidationInput(object sender, KeyPressEventArgs e)
        {
            return !System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[-,+,0,1,2,3,4,5,6,7,8,9,\b]") && e.KeyChar != 8;
        }
        //метод для комплексных чисел
        private static Tuple<Complex, Complex> Solve(double a, double b, double c)
        {
            Complex d = b * b - 4 * a * c;
            var real = -b / (2 * a);
            var im = Complex.Sqrt(d) / (2 * a);
            return new Tuple<Complex, Complex>(real + im, real - im);
        }
        //KeyPress для текстовых полей для переменных а, b и с 
        private void tb_A_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidationInput(sender, e);
        }
        private void tb_B_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidationInput(sender, e);
        }
        private void tb_C_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidationInput(sender, e);
        }
        //кнопка "вычислить"
        private void b_decision_Click(object sender, EventArgs e)
        {
            double a, b, c;
            l_equation.Text = "";
            try
            { a = Convert.ToDouble(tb_A.Text); }
            catch
            {
                l_Error.Text = "Error! Invalid number A format."; l_D.Text = ""; l_X1.Text = ""; l_X2.Text = "";
                l_equation.Text = ""; return;
            }
            try
            { b = Convert.ToDouble(tb_B.Text); }
            catch
            {
                l_Error.Text = "Error! Invalid number B format."; l_D.Text = ""; l_X1.Text = ""; l_X2.Text = "";
                l_equation.Text = ""; return;
            }
            try
            { c = Convert.ToDouble(tb_C.Text); }
            catch
            {
                l_Error.Text = "Error! Invalid number C format."; l_D.Text = ""; l_X1.Text = ""; l_X2.Text = "";
                l_equation.Text = ""; return;
            }
            l_D.Text = ""; l_X1.Text = ""; l_X2.Text = "";
            l_Error.Text = ""; l_equation.Text = "";
            l_equation.Text += a.ToString() + "X^2 + (" + b.ToString() + ")X + (" + c.ToString() + ") = 0";
            if (cb_1.Checked == true)
            {
                double D = (b * b) - (4 * a * c);
                double x1 = 0, x2 = 0;
                if (D > 0)
                {
                    x1 = (-b - Math.Sqrt(D)) / (2 * a);
                    x2 = (-b + Math.Sqrt(D)) / (2 * a);
                    l_X1.Text = "X1 = " + Math.Round(x1, 2).ToString();
                    l_X2.Text = "X2 = " + Math.Round(x2, 2).ToString();
                }
                if (D == 0)
                {
                    x1 = (-b) / (2 * a);
                    x2 = x1;
                    l_X1.Text = "X1 = " + Math.Round(x1, 2).ToString();
                    l_X2.Text = "X2 = " + Math.Round(x2, 2).ToString();
                }
                if (D < 0)
                {
                    var res = Solve(a, b, c);
                    l_X1.Text = "X1 = " + String.Format(new ComplexFormatter(), "{0:I0}", res.Item1);
                    l_X2.Text = "X2 = " + String.Format(new ComplexFormatter(), "{0:I0}", res.Item2);
                }
                l_D.Text = "D = " + Math.Round(D, 2).ToString();
            }
            else if (cb_2.Checked == true)
            { 
                Equation1(a, b, c);
                l_X1.Text = s_x1;
                l_X2.Text = s_x2;
                l_D.Text = s_d;
            }
            else if (cb_3.Checked == true)
            {
                Equation equ = new Equation();
                string res = equ.Equations(a, b, c);
                int i = 0;
                l_D.Text = ""; l_X1.Text = "X1 = "; l_X2.Text = "X2 = ";
                while (res[i] != '\n')
                { l_X1.Text += res[i]; i++; }
                i++;
                while (res[i] != '\n')
                { l_X2.Text += res[i]; i++; }
                i++;
                while (res[i] != '\n')
                { l_D.Text += res[i]; i++; }
            }
            else l_Error.Text = "Error! Select a method.";
            a = 0; b = 0; c = 0;
        }
        //кнопка "очистить"
        private void bClear_Click(object sender, EventArgs e)
        {
            tb_A.Clear(); tb_B.Clear(); tb_C.Clear();
            l_D.Text = ""; l_X1.Text = ""; l_X2.Text = "";
            l_Error.Text = ""; l_equation.Text = "";
        }
        //кнопка "закрыть"
        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
