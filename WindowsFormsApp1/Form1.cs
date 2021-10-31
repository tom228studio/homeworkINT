using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int check;
        public Form1()
        {
            InitializeComponent();
        }
        int A, B;
        private void radioButton1_CheckedChanged(object sender, EventArgs e) //В Нижних радио тоже самое с шагом +1
        {
            check = 1;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            check = 2;
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            check = 3;
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            check = 4;
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            check = 5;
        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            check = 6;
        }
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            check = 7;
        }
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            check = 8;
        }
        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            check = 9;
        }
        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            check = 10;
        }

        public void labletext(string a,string b,string c,string d)
        {
            label1.Text = a;
            label2.Text = b;
            label3.Text = c;
            label5.Text = d;
        }
        public void ElseTry(int number,bool try1,bool try2,int x,string formula,int F)
        {
            if (try2)
            {
                    switch (formula)
                    {
                        case "+":
                        label6.Text ="Ответ:" + Convert.ToString(F + x);
                        break;
                        case "-":
                        label6.Text = "Ответ:" + Convert.ToString(F - x);
                        break;
                        case "/":
                        label6.Text = "Ответ:" + Convert.ToString(F / x);
                        break;
                        case "%":
                        label6.Text = "Ответ:" + Convert.ToString(F % x);
                        break;
                        
                }
            }
            else
            {
                if (try1 && number==1)
                {
                    switch (formula)
                    {
                        case "+":
                            label6.Text = "Ответ:" + Convert.ToString(F + x);
                            textBox1.Text = "";
                            textBox2.Text = "";
                            break;
                        case "-":
                            label6.Text = "Ответ:" + Convert.ToString(F - x);
                            textBox1.Text = "";
                            textBox2.Text = "";
                            break;
                        case "/":
                            label6.Text = "Ответ:" + Convert.ToString(F / x);
                            textBox1.Text = "";
                            textBox2.Text = "";
                            break;
                        case "%":
                            label6.Text = "Ответ:" + Convert.ToString(F % x);
                            textBox1.Text = "";
                            textBox2.Text = "";
                            break;
                        case "/,%":
                            label6.Text = "Ответ:" + Convert.ToString(F / x) + "," + Convert.ToString(F % x);
                            textBox1.Text = "";
                            textBox2.Text = "";
                            break;
                        case "+,*":
                            label6.Text = "Ответ:" + Convert.ToString((F / x) + (F % x)) + "," + Convert.ToString((F / x) * (F % x));
                            textBox1.Text = "";
                            textBox2.Text = "";
                            break;
                        case "%,/":
                            label6.Text = "Ответ:" + Convert.ToString((F / x) + (F % x * x));
                            textBox1.Text = "";
                            textBox2.Text = "";
                            break;
                        case "%,/,%":
                            label6.Text = "Ответ:" + Convert.ToString(F % x) + "," + Convert.ToString((F / x) % x);
                            textBox1.Text = "";
                            textBox2.Text = "";
                            break;
                    }
                }
                else
                {
                    if (number == 1)
                    {
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        MessageBox.Show("Буквы в ячейке");
                    }
                    else
                    {
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        MessageBox.Show("Буквы в ячейках");
                    }
                }
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            bool Try_1 = int.TryParse(textBox1.Text, out A);
            bool Try_2 = int.TryParse(textBox2.Text, out B);
            switch (check)
            {
                case 1:
                    ElseTry(1,Try_1,false,100,"/",A);
                    break;
                case 2:
                    ElseTry(1, Try_1, false, 1000,"/",A);
                    break;
                case 3:
                    ElseTry(1, Try_1, false, 1024,"/",A);
                    break;
                case 4:
                    ElseTry(2, Try_1, Try_2, B,"/",A);
                    break;
                case 5:
                    ElseTry(2, Try_1, Try_2, B,"%",A);
                    break;
                case 6:
                    ElseTry(1, Try_1, false, 10, "/,%",A);
                    break;
                case 7:
                    ElseTry(1, Try_1, false, 10, "+,*",A);
                    break;
                case 8:
                    ElseTry(1, Try_1, false, 10, "%,/",A);
                    break;
                case 9:
                    ElseTry(1, Try_1, false, 100, "/",A);
                    break;
                case 10:
                    ElseTry(1, Try_1, false, 10, "%,/,%",A);
                    break;
                default:
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (check)
            {
                case 1:
                    labletext("L","","", "Дано расстояние L в сантиметрах. Используя операцию деления \n нацело, найти количество полных метров в нем(1 метр = 100 см).");
                    break;
                case 2:
                    labletext("M", "", "", "Дана масса M в килограммах. Используя операцию деления нацело,\n найти количество полных тонн в ней(1 тонна = 1000 кг).");
                    break;
                case 3:
                    labletext("Файл", "", "","Дан размер файла в байтах. Используя операцию деления нацело,\n найти количество полных килобайтов, которые занимает данный файл \n (1 килобайт = 1024 байта).");
                    break;
                case 4:
                    labletext("A", "B", "", "Даны целые положительные числа A и B (A > B). На отрезке длины A размещено максимально возможное количество отрезков длины B \n(без наложений).Используя операцию деления нацело, найти количество \n отрезков B, размещенных на отрезке A.");
                    break;
                case 5:
                    labletext("L", "", "", "Даны целые положительные числа A и B (A > B). На отрезке длины A \nразмещено максимально возможное количество отрезков длины B(без \n наложений).Используя операцию взятия остатка от деления нацело, найти \n длину незанятой части отрезка A.");
                    break;
                case 6:
                    labletext("Число", "", "", "Дано двузначное число. Вывести вначале его левую цифру (десятки), а затем — его правую цифру (единицы). Для нахождения десятков\n использовать операцию деления нацело, для нахождения единиц — операцию взятия остатка от деления.");
                    break;
                case 7:
                    labletext("Число", "", "","Дано двузначное число. Найти сумму и произведение его цифр.");
                    break;
                case 8:
                    labletext("Число", "", "", "Дано двузначное число. Вывести число, полученное при перестановке цифр исходного числа.");
                    break;
                case 9:
                    labletext("Число", "", "", "Дано трехзначное число. Используя одну операцию деления нацело,\n вывести первую цифру данного числа(сотни).");
                    break;
                case 10:
                    labletext("Число", "", "", "Дано трехзначное число. Вывести вначале его последнюю цифру \n (единицы), а затем — его среднюю цифру(десятки).");
                    break;
                default:
                    labletext("", "", "", "");
                    break;
            }
        }

        
    }
}
