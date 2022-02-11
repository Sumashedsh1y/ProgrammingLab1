using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1_Semestr_3
{
    public partial class Form2 : Form
    {
        public Form2(string Name1, string Name2, string Name3, string number_class, decimal count, bool difficult)
        {
            InitializeComponent();
            label2.Text = "Ученик: " + Name1 + " " + Name2 + " " + Name3 + "\n" + "Класс: " + number_class;
            int n = Convert.ToInt32(count);
            for (int i = 0; i < n; i++)
                if (difficult)
                {
                    if (i > 10)
                    {
                        Size = new Size(500, 500 + 30 * (i - 10));
                    }
                    Label t = new Label
                    {
                        Text = "Простое_" + (i + 1).ToString(),
                        Location = new Point(12, 120 + i * 30)
                    };

                    CheckBox c = new CheckBox
                    {
                        Location = new Point(120, 115 + i * 30)
                    };
                    Controls.Add(c);
                    Controls.Add(t);
                }
                else
                {
                    if (i>5)
                    {
                        Size = new Size(500, 500 + 60 * (i-5));
                    }
                    var rand = new Random();
                    Label t = new Label
                    {
                        Text = "Сложное_" + (i + 1).ToString(),
                        Location = new Point(12, 120 + i * 60)
                    };

                    for (int j = 0; j < 5; j++)
                    {
                        CheckBox c = new CheckBox
                        {
                            Text = rand.Next(1, 9).ToString(),
                            Size = new Size(50, 50),
                            Location = new Point(100 + j * 50, 105 + i * 60)
                        };
                        Controls.Add(c);
                    }
                    Controls.Add(t);
                };
        }
    }
}
