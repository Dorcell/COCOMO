using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COCOMO
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void again_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ExecutablePath);
            this.Close();
        }

        private void aboutprog_Click(object sender, EventArgs e)
        {
            About abt = new About();
            abt.Show();
        }

        private void docum_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("COCOMOI - Функционал.pdf");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControl1.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.Black);
                g.FillRectangle(Brushes.Silver, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Arial", (float)10.0, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }//делаем страницы tabcontrol сбоку

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
                Gogo.Enabled = true;
            else
                Gogo.Enabled = false;
        }

        private void Gogo_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                License.Visible = false;
                License.Hide();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            License.Location = new Point(0, 0);

            //подсказки
           // toolTip1.ToolTipTitle = "Подсказка";
            toolTip1.SetToolTip(l18, "PREC (Precedentedness) - прецедентность, наличие опыта аналогичных разработок");            
            toolTip1.SetToolTip(l19, "FLEX (Development Flexibility) - Гибкость процесса разработки");
            toolTip1.SetToolTip(l20, "RESL (Architecture / Risk Resolution) - Архитектура и разрешение рисков");
            toolTip1.SetToolTip(l21, "TEAM ( Team Cohesion) - Сработанность команды");
            toolTip1.SetToolTip(l22, "PMAT (Process Maturity) - Зрелость процессов");
            toolTip1.SetToolTip(label19, "PERS (Personnel Capability) – квалификация персонала");
            toolTip1.SetToolTip(label20, "PREX (Personnel Experience) – опыт персонала");
            toolTip1.SetToolTip(label18, "RCPX (Product Reliability and Complexity) – сложность и надежность продукта");
            toolTip1.SetToolTip(label17, "RUSE (Developed for Reusability) – разработка для повторного использования");
            toolTip1.SetToolTip(label13, "PDIF (Platform Difficulty) – сложность платформы разработки");
            toolTip1.SetToolTip(label15, "FCIL (Facilities)– оборудование");
            toolTip1.SetToolTip(label16, "SCED (Required Development Schedule) – требуемое выполнение графика работ");

            toolTip1.SetToolTip(label36, "PREC (Precedentedness) - прецедентность, наличие опыта аналогичных разработок");
            toolTip1.SetToolTip(label35, "FLEX (Development Flexibility) - Гибкость процесса разработки");
            toolTip1.SetToolTip(label34, "RESL (Architecture / Risk Resolution) - Архитектура и разрешение рисков");
            toolTip1.SetToolTip(label33, "TEAM ( Team Cohesion) - Сработанность команды");
            toolTip1.SetToolTip(label32, "PMAT (Process Maturity) - Зрелость процессов");
            toolTip1.SetToolTip(l35, "ACAP (Analyst Capability) – возможности аналитика");
            toolTip1.SetToolTip(l36, "AEXP (Applications Experience) – опыт разработки приложений");
            toolTip1.SetToolTip(l37, "PCAP (Programmer Capability) – возможности программиста");
            toolTip1.SetToolTip(l38, "PCON (Personnel Continuity) – продолжительность работы персонала");
            toolTip1.SetToolTip(l39, "PEXP (Platform Experience) –опыт работы с платформой");
            toolTip1.SetToolTip(l40, "LTEX (Language and Tool Experience) – опыт использования языка программирования и инструментальных средств");
            toolTip1.SetToolTip(l41, "RELY (Required Software Reliability) – требуемая надежность программы");
            toolTip1.SetToolTip(l42, "DATA (Database Size) – размер базы данных");
            toolTip1.SetToolTip(l43, "CPLX (Software Product Complexity) – сложность программы");
            toolTip1.SetToolTip(l44, "RUSE (Required Reusability) – требуемая возможность многократного использования");
            toolTip1.SetToolTip(l45, "DOCU (Documentation Match to Life-Cycle Needs) – соответствие документации потребностям жизненного цикла");
            toolTip1.SetToolTip(l49, "TIME (Execution Time Constraint) – ограничения времени выполнения");
            toolTip1.SetToolTip(l50, "STOR (Main Storage Constraint) – ограничения памяти");
            toolTip1.SetToolTip(l51, "PVOL (Platform Volatility) – изменяемость платформы");
            toolTip1.SetToolTip(l46, "TOOL (Use of Software Tools) – использование инструментальных программных средств");
            toolTip1.SetToolTip(l47, "SITE (Multisite Development) – многоабонентская (удаленная) разработка");
            toolTip1.SetToolTip(l48, "SCED (Required Development Schedule) – требуемое выполнение графика работ");
            toolTip1.SetToolTip(label23, "Произведение выбранных множителей трудоемкости");
            toolTip1.SetToolTip(label28, "Произведение выбранных множителей трудоемкости");

            comboBox3.SelectedItem = "Средний";
            comboBox4.SelectedItem = "Средний";
            comboBox5.SelectedItem = "Средний";
            comboBox6.SelectedItem = "Средний";
            comboBox7.SelectedItem = "Средний";
            comboBox8.SelectedItem = "Средний";
            comboBox9.SelectedItem = "Средний";
            comboBox10.SelectedItem = "Средний";
            comboBox11.SelectedItem = "Средний";
            comboBox12.SelectedItem = "Средний";
            comboBox13.SelectedItem = "Средний";
            comboBox14.SelectedItem = "Средний";
            comboBox15.SelectedItem = "Средний";
            comboBox16.SelectedItem = "Средний";
            comboBox17.SelectedItem = "Средний";
            comboBox18.SelectedItem = "Нормальный";
            comboBox19.SelectedItem = "Нормальный";
            comboBox20.SelectedItem = "Нормальный";
            comboBox21.SelectedItem = "Нормальный";
            comboBox22.SelectedItem = "Нормальный";
            comboBox23.SelectedItem = "Нормальный";
            comboBox24.SelectedItem = "Нормальный";
            comboBox25.SelectedItem = "Нормальный";
            comboBox26.SelectedItem = "Нормальный";
            comboBox27.SelectedItem = "Нормальный";
            comboBox28.SelectedItem = "Нормальный";
            comboBox29.SelectedItem = "Нормальный";
            comboBox30.SelectedItem = "Нормальный";
            comboBox31.SelectedItem = "Нормальный";
            comboBox32.SelectedItem = "Нормальный";
            comboBox33.SelectedItem = "Нормальный";
            comboBox34.SelectedItem = "Нормальный";
            comboBox35.SelectedItem = "Нормальный";
            comboBox36.SelectedItem = "Нормальный";
            comboBox37.SelectedItem = "Нормальный";
            comboBox38.SelectedItem = "Нормальный";
            comboBox39.SelectedItem = "Нормальный";
            comboBox40.SelectedItem = "Нормальный";
            comboBox40.SelectedItem = "Нормальный";
            comboBox41.SelectedItem = "Нормальный";
            comboBox42.SelectedItem = "Нормальный";
            comboBox43.SelectedItem = "Нормальный";
            comboBox44.SelectedItem = "Нормальный";
            comboBox45.SelectedItem = "Нормальный";
            comboBox46.SelectedItem = "Нормальный";
            comboBox47.SelectedItem = "Нормальный";
            comboBox48.SelectedItem = "Нормальный";
            comboBox49.SelectedItem = "Нормальный";
            comboBox50.SelectedItem = "Нормальный";
            comboBox51.SelectedItem = "Нормальный";

            label2.Text = "Объем программного продукта\n(количество строк кода, тыс)";
            comboBox1.SelectedItem = "Встроенный";
            label11.Text = "Объем программного продукта\n(количество строк кода, тыс)";
            comboBox2.SelectedItem = "Встроенный";
            label3.Text = "Трудоемкость,\nчеловек*месяц";
            label4.Text = "Время разработки,\nмесяцы";
            radioButton2.Checked = true;
            groupBox6.Visible = true;
            label14.Text = "Объем программного продукта\n(количество строк кода, тыс)";

        }

        private void button1_Click(object sender, EventArgs e)//считаем basic
        {
            if (textBox1.Text == "" || textBox1.Text == null)
            {
                MessageBox.Show("Введите объем программного продукта", "Предупреждение");
            }
            else
            {
                groupBox2.Visible = true;
                double a = 0, b = 0, c = 0, d = 0, size, pm, tm;
                size = Convert.ToDouble(textBox1.Text);
                switch (Convert.ToString(comboBox1.SelectedItem))
                {
                    case "Распространенный": { a = 2.4; b = 1.05; c = 2.5; d = 0.38; } break;
                    case "Полунезависимый": { a = 3; b = 1.12; c = 2.5; d = 0.35; } break;
                    case "Встроенный": { a = 3.6; b = 1.2; c = 2.5; d = 0.32; } break;
                }
                pm = a * Math.Pow(size, b);
                tm = c * Math.Pow(pm, d);
                textBox2.Text = Convert.ToString(Math.Round(pm, 2));
                textBox3.Text = Convert.ToString(Math.Round(tm, 2));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            groupBox2.Visible = false;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (Convert.ToString(comboBox1.SelectedItem))
            {
                case "Распространенный":
                    label9.Text = "Распространенный тип характеризуется тем, что проект выполняется небольшой группой специалистов, имеющих опыт  в создании подобных изделий и опыт применения технологических средств. Условия работы стабильны, и изделие имеет относительно невысокую сложность.";
                    break;
                case "Встроенный":
                    label9.Text = "Встроенный тип характеризуется очень жесткими требованиями на программный продукт, интерфейсы, параметры ЭВМ. Как правило, у таких изделий высокая степень новизны и планирование работ осуществляется при недостаточной информации, как о самом изделии, так и об условиях работы. Встроенный проект требует больших затрат на изменения и исправления.";
                    break;
                case "Полунезависимый":
                    label9.Text = "Полунезависимый тип занимает промежуточное положение между распространенным и встроенным – это проекты средней сложности. Исполнители знакомы лишь с некоторыми характеристиками (или компонентами) создаваемой системы, имеют средний опыт работы с подобными изделиями, изделие имеет элемент новизны. Только часть требований к изделию жестко фиксируется, в остальном разработки имеют степени выбора.";
                    break;
            }
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (Convert.ToString(comboBox2.SelectedItem))
            {
                case "Распространенный":
                    label10.Text = "Распространенный тип характеризуется тем, что проект выполняется небольшой группой специалистов, имеющих опыт  в создании подобных изделий и опыт применения технологических средств. Условия работы стабильны, и изделие имеет относительно невысокую сложность.";
                    break;
                case "Встроенный":
                    label10.Text = "Встроенный тип характеризуется очень жесткими требованиями на программный продукт, интерфейсы, параметры ЭВМ. Как правило, у таких изделий высокая степень новизны и планирование работ осуществляется при недостаточной информации, как о самом изделии, так и об условиях работы. Встроенный проект требует больших затрат на изменения и исправления.";
                    break;
                case "Полунезависимый":
                    label10.Text = "Полунезависимый тип занимает промежуточное положение между распространенным и встроенным – это проекты средней сложности. Исполнители знакомы лишь с некоторыми характеристиками (или компонентами) создаваемой системы, имеют средний опыт работы с подобными изделиями, изделие имеет элемент новизны. Только часть требований к изделию жестко фиксируется, в остальном разработки имеют степени выбора.";
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)//считаем intermediate
        {
            if (textBox4.Text == "" || textBox4.Text == null)
            {
                MessageBox.Show("Введите объем программного продукта", "Предупреждение");
            }
            else
            {
                groupBox4.Visible = true;
                double a = 0, b = 0, c = 0, d = 0, size, tm, pm, eaf = 1;
                size = Convert.ToDouble(textBox4.Text);
                switch (Convert.ToString(comboBox2.SelectedItem))
                {
                    case "Распространенный": { a = 3.2; b = 1.05; c = 2.25; d = 0.38; } break;
                    case "Полунезависимый": { a = 3; b = 1.12; c = 2.25; d = 0.35; } break;
                    case "Встроенный": { a = 2.8; b = 1.2; c = 2.25; d = 0.32; } break;
                }

                //значения в combobox 3-17
                for (int i = 0; i < 15; i++)
                {
                    eaf *= get_CD(i);
                }
                pm = eaf * a * (Math.Pow(size, b));
                tm = c * Math.Pow(pm, d);
                textBox7.Text = Convert.ToString(Math.Round(pm, 2));//Трудоемкость
                textBox6.Text = Convert.ToString(Math.Round(tm, 2));//Время
                textBox5.Text = Convert.ToString(Math.Round(eaf, 2));//EAF
            }
        }

        public double get_CD(int i)
        {
            double res = 1;
            string[] combo = new string[15] { Convert.ToString(comboBox3.SelectedItem), Convert.ToString(comboBox4.SelectedItem), Convert.ToString(comboBox5.SelectedItem), Convert.ToString(comboBox6.SelectedItem), Convert.ToString(comboBox7.SelectedItem), Convert.ToString(comboBox8.SelectedItem), Convert.ToString(comboBox9.SelectedItem), Convert.ToString(comboBox10.SelectedItem), Convert.ToString(comboBox11.SelectedItem), Convert.ToString(comboBox12.SelectedItem), Convert.ToString(comboBox13.SelectedItem), Convert.ToString(comboBox14.SelectedItem), Convert.ToString(comboBox15.SelectedItem), Convert.ToString(comboBox16.SelectedItem), Convert.ToString(comboBox17.SelectedItem) };

            switch (i)
            {
                //характеристики продукта
                case 0:
                    switch (combo[0])
                    {
                        case "Очень низкий": res = 0.75; break;
                        case "Низкий": res = 0.88; break;
                        case "Средний": res = 1; break;
                        case "Высокий": res = 1.15; break;
                        case "Очень высокий": res = 1.4; break;
                    }
                    break;

                case 1:
                    switch (combo[1])
                    {
                        case "Низкий": res = 0.94; break;
                        case "Средний": res = 1; break;
                        case "Высокий": res = 1.08; break;
                        case "Очень высокий": res = 1.16; break;
                    }
                    break;
                case 2:
                    switch (combo[2])
                    {
                        case "Очень низкий": res = 0.7; break;
                        case "Низкий": res = 0.85; break;
                        case "Средний": res = 1; break;
                        case "Высокий": res = 1.15; break;
                        case "Очень высокий": res = 1.3; break;
                        case "Критический": res = 1.65; break;
                    }
                    break;

                //характеристики аппаратного обеспечения
                case 3:
                    switch (combo[3])
                    {
                        case "Средний": res = 1; break;
                        case "Высокий": res = 1.11; break;
                        case "Очень высокий": res = 1.3; break;
                        case "Критический": res = 1.66; break;
                    }
                    break;
                case 4:
                    switch (combo[4])
                    {
                        case "Средний": res = 1; break;
                        case "Высокий": res = 1.06; break;
                        case "Очень высокий": res = 1.21; break;
                        case "Критический": res = 1.56; break;
                    }
                    break;

                case 5:
                    switch (combo[5])
                    {
                        case "Низкий": res = 0.87; break;
                        case "Средний": res = 1; break;
                        case "Высокий": res = 1.15; break;
                        case "Очень высокий": res = 1.3; break;
                    }
                    break;

                case 6:
                    switch (combo[6])
                    {
                        case "Низкий": res = 0.87; break;
                        case "Средний": res = 1; break;
                        case "Высокий": res = 1.07; break;
                        case "Очень высокий": res = 1.15; break;
                    }
                    break;
                //характеристики персонала
                case 7:
                    switch (combo[7])
                    {
                        case "Очень низкий": res = 1.46; break;
                        case "Низкий": res = 1.19; break;
                        case "Средний": res = 1; break;
                        case "Высокий": res = 0.86; break;
                        case "Очень высокий": res = 0.71; break;
                    }
                    break;

                case 8:
                    switch (combo[8])
                    {
                        case "Очень низкий": res = 1.29; break;
                        case "Низкий": res = 1.13; break;
                        case "Средний": res = 1; break;
                        case "Высокий": res = 0.91; break;
                        case "Очень высокий": res = 0.82; break;
                    }
                    break;

                case 9:
                    switch (combo[9])
                    {
                        case "Очень низкий": res = 1.42; break;
                        case "Низкий": res = 1.17; break;
                        case "Средний": res = 1; break;
                        case "Высокий": res = 0.86; break;
                        case "Очень высокий": res = 0.7; break;
                    }
                    break;

                case 10:
                    switch (combo[10])
                    {
                        case "Очень низкий": res = 1.21; break;
                        case "Низкий": res = 1.1; break;
                        case "Средний": res = 1; break;
                        case "Высокий": res = 0.9; break;
                    }
                    break;

                case 11:
                    switch (combo[11])
                    {
                        case "Очень низкий": res = 1.14; break;
                        case "Низкий": res = 1.07; break;
                        case "Средний": res = 1; break;
                        case "Высокий": res = 0.95; break;
                    }
                    break;
                //характеристики проекта
                case 12:
                    switch (combo[12])
                    {
                        case "Очень низкий": res = 1.24; break;
                        case "Низкий": res = 1.1; break;
                        case "Средний": res = 1; break;
                        case "Высокий": res = 0.91; break;
                        case "Очень высокий": res = 0.82; break;
                    }
                    break;

                case 13:
                    switch (combo[13])
                    {
                        case "Очень низкий": res = 1.24; break;
                        case "Низкий": res = 1.1; break;
                        case "Средний": res = 1; break;
                        case "Высокий": res = 0.91; break;
                        case "Очень высокий": res = 0.83; break;
                    }
                    break;

                case 14:
                    switch (combo[14])
                    {
                        case "Очень низкий": res = 1.23; break;
                        case "Низкий": res = 1.08; break;
                        case "Средний": res = 1; break;
                        case "Высокий": res = 1.04; break;
                        case "Очень высокий": res = 1.1; break;
                    }
                    break;
            }
            return res;
        }

        private void button4_Click(object sender, EventArgs e)//удалить все из textbox
        {
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                groupBox6.Visible = true;
                groupBox7.Visible = false;
                groupBox8.Visible = false;
                groupBox9.Visible = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                groupBox6.Visible = false;
                groupBox7.Visible = true;
                groupBox8.Visible = false;
                groupBox9.Visible = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                groupBox6.Visible = false;
                groupBox7.Visible = false;
                groupBox8.Visible = false;
                groupBox9.Visible = true;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                groupBox6.Visible = false;
                groupBox7.Visible = false;
                groupBox8.Visible = true;
                groupBox9.Visible = false;
            }
        }      

        private void button6_Click(object sender, EventArgs e)//сумма факторов SFj
        {
            double sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += get_factor(i);
            }
            textBox9.Text = Convert.ToString(sum);
            groupBox11.Visible = true;
            groupBox5.Visible = true;
            button5.Visible = true;
        }

        private double get_factor(int i)
        {
            double res = 1;
            string[] combo = new string[5] { Convert.ToString(comboBox18.SelectedItem), Convert.ToString(comboBox19.SelectedItem), Convert.ToString(comboBox20.SelectedItem), Convert.ToString(comboBox21.SelectedItem), Convert.ToString(comboBox22.SelectedItem) };
            switch (i)
            {
                case 0:
                    switch (combo[0])
                    {
                        case "Очень низкий": res = 6.2; break;
                        case "Низкий": res = 4.96; break;
                        case "Нормальный": res = 3.72; break;
                        case "Высокий": res = 2.48; break;
                        case "Очень высокий": res = 1.24; break;
                        case "Сверхвысокий": res = 0; break;
                    }
                    break;
                case 1:
                    switch (combo[1])
                    {
                        case "Очень низкий": res = 5.07; break;
                        case "Низкий": res = 4.05; break;
                        case "Нормальный": res = 3.04; break;
                        case "Высокий": res = 2.03; break;
                        case "Очень высокий": res = 1.01; break;
                        case "Сверхвысокий": res = 0; break;
                    }
                    break;
                case 2:
                    switch (combo[2])
                    {
                        case "Очень низкий": res = 7.07; break;
                        case "Низкий": res = 5.65; break;
                        case "Нормальный": res = 4.24; break;
                        case "Высокий": res = 2.83; break;
                        case "Очень высокий": res = 1.41; break;
                        case "Сверхвысокий": res = 0; break;
                    }
                    break;
                case 3:
                    switch (combo[3])
                    {
                        case "Очень низкий": res = 5.48; break;
                        case "Низкий": res = 4.38; break;
                        case "Нормальный": res = 3.29; break;
                        case "Высокий": res = 2.19; break;
                        case "Очень высокий": res = 1.1; break;
                        case "Сверхвысокий": res = 0; break;
                    }
                    break;
                case 4:
                    switch (combo[4])
                    {
                        case "Очень низкий": res = 7.8; break;
                        case "Низкий": res = 6.24; break;
                        case "Нормальный": res = 4.68; break;
                        case "Высокий": res = 3.12; break;
                        case "Очень высокий": res = 1.56; break;
                        case "Сверхвысокий": res = 0; break;
                    }
                    break;
            }
            return res;
        }

        private void button5_Click(object sender, EventArgs e)//считаем Early design
        {
            if (textBox8.Text == "" || textBox8.Text == null)
            {
                MessageBox.Show("Введите объем программного продукта", "Предупреждение");
            }
            else
            {
                double A = 2.94, B = 0.91, C = 3.67, D = 0.28, E, SCED = 1, pmNS, size, pm, tm, eaf = 1, eafS = 1, factor;
                //pmNS – рассчитанная трудоемкость проекта без учета множителя SCED, определяющего сжатие расписания. 
                //n = 7 для eafS
                size = Convert.ToDouble(textBox8.Text);
                factor = Convert.ToDouble(textBox9.Text);
                E = B + 0.01 * factor;
                // eaf произведение комобоксов
                for(int k = 0;k<6;k++)
                {
                    eafS *= get_emj(k);
                }
                switch (Convert.ToString(comboBox25.SelectedItem))
                {
                    case "Очень низкий": SCED = 1.43; break;
                    case "Низкий": SCED = 1.14; break;
                    case "Нормальный": SCED = 1; break;
                    case "Высокий": SCED = 1; break;
                }
                pmNS=eafS*A * Math.Pow(size, E);
                eaf = eafS * SCED;
                pm = eaf * A * Math.Pow(size, E);
                tm = SCED * C * Math.Pow(pmNS, (D + 0.2 * (E - B)));
                textBox12.Text = Convert.ToString(Math.Round(pm, 2));
                textBox11.Text = Convert.ToString(Math.Round(tm, 2));
                textBox10.Text = Convert.ToString(Math.Round(eaf, 2));
                textBox13.Text = Convert.ToString(Math.Round(eafS, 2));
                groupBox12.Visible = true;
            }
        }

        private double get_emj(int i)
        {
            double res = 1;
            string[] combo = new string[6] { Convert.ToString(comboBox28.SelectedItem), Convert.ToString(comboBox29.SelectedItem), Convert.ToString(comboBox27.SelectedItem), Convert.ToString(comboBox26.SelectedItem), Convert.ToString(comboBox23.SelectedItem), Convert.ToString(comboBox24.SelectedItem) };
            switch (i)
            {
                case 0:
                    switch (combo[0])
                    {
                        case "Сверхнизкий": res = 2.12; break;
                        case "Очень низкий": res = 1.62; break;
                        case "Низкий": res = 1.26; break;
                        case "Нормальный": res = 1; break;
                        case "Высокий": res = 0.83; break;
                        case "Очень высокий": res = 0.63; break;
                        case "Сверхвысокий": res = 0.5; break;
                    }
                    break;
                case 1:
                    switch (combo[1])
                    {
                        case "Сверхнизкий": res = 1.59; break;
                        case "Очень низкий": res = 1.33; break;
                        case "Низкий": res = 1.22; break;
                        case "Нормальный": res = 1; break;
                        case "Высокий": res = 0.87; break;
                        case "Очень высокий": res = 0.74; break;
                        case "Сверхвысокий": res = 0.62; break;
                    }
                    break;
                case 2:
                    switch (combo[2])
                    {
                        case "Сверхнизкий": res = 0.49; break;
                        case "Очень низкий": res = 0.6; break;
                        case "Низкий": res = 0.83; break;
                        case "Нормальный": res = 1; break;
                        case "Высокий": res = 1.33; break;
                        case "Очень высокий": res = 1.91; break;
                        case "Сверхвысокий": res = 2.72; break;
                    }
                    break;
                case 3:
                    switch (combo[3])
                    {
                        case "Низкий": res = 0.95; break;
                        case "Нормальный": res = 1; break;
                        case "Высокий": res = 1.07; break;
                        case "Очень высокий": res = 1.15; break;
                        case "Сверхвысокий": res = 1.24; break;
                    }
                    break;
                case 4:
                    switch (combo[4])
                    {
                        case "Низкий": res = 0.87; break;
                        case "Нормальный": res = 1; break;
                        case "Высокий": res = 1.29; break;
                        case "Очень высокий": res = 1.81; break;
                        case "Сверхвысокий": res = 2.61; break;
                    }
                    break;
                case 5:
                    switch (combo[5])
                    {
                        case "Сверхнизкий": res = 1.43; break;
                        case "Очень низкий": res = 1.3; break;
                        case "Низкий": res = 1.1; break;
                        case "Нормальный": res = 1; break;
                        case "Высокий": res = 0.87; break;
                        case "Очень высокий": res = 0.73; break;
                        case "Сверхвысокий": res = 0.62; break;
                    }
                    break;
            }
                    return res;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox12.Text = "";
            textBox11.Text = "";
            textBox10.Text = "";
            textBox13.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            groupBox12.Visible = false;
            groupBox5.Visible = false;
            groupBox11.Visible = false;
            button5.Visible = false;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                groupBox20.Visible = true;
                groupBox21.Visible = false;
                groupBox22.Visible = false;
                groupBox23.Visible = false;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                groupBox20.Visible = false;
                groupBox21.Visible = true;
                groupBox22.Visible = false;
                groupBox23.Visible = false;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                groupBox20.Visible = false;
                groupBox21.Visible = false;
                groupBox22.Visible = true;
                groupBox23.Visible = false;
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked == true)
            {
                groupBox20.Visible = false;
                groupBox21.Visible = false;
                groupBox22.Visible = false;
                groupBox23.Visible = true;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += get_factor2(i);
            }
            textBox19.Text = Convert.ToString(sum);
            groupBox14.Visible = true;
            radioButton5.Visible = true;
            radioButton6.Visible = true;
            radioButton7.Visible = true;
            radioButton8.Visible = true;
            button9.Visible = true;
            radioButton5.Checked = true;
            label31.Text = "Объем программного продукта\n(количество строк кода, тыс)";            
        }

        private double get_factor2(int i)
        {
            double res = 1;
            string[] combo = new string[5] { Convert.ToString(comboBox34.SelectedItem), Convert.ToString(comboBox33.SelectedItem), Convert.ToString(comboBox32.SelectedItem), Convert.ToString(comboBox31.SelectedItem), Convert.ToString(comboBox30.SelectedItem) };
            switch (i)
            {
                case 0:
                    switch (combo[0])
                    {
                        case "Очень низкий": res = 6.2; break;
                        case "Низкий": res = 4.96; break;
                        case "Нормальный": res = 3.72; break;
                        case "Высокий": res = 2.48; break;
                        case "Очень высокий": res = 1.24; break;
                        case "Сверхвысокий": res = 0; break;
                    }
                    break;
                case 1:
                    switch (combo[1])
                    {
                        case "Очень низкий": res = 5.07; break;
                        case "Низкий": res = 4.05; break;
                        case "Нормальный": res = 3.04; break;
                        case "Высокий": res = 2.03; break;
                        case "Очень высокий": res = 1.01; break;
                        case "Сверхвысокий": res = 0; break;
                    }
                    break;
                case 2:
                    switch (combo[2])
                    {
                        case "Очень низкий": res = 7.07; break;
                        case "Низкий": res = 5.65; break;
                        case "Нормальный": res = 4.24; break;
                        case "Высокий": res = 2.83; break;
                        case "Очень высокий": res = 1.41; break;
                        case "Сверхвысокий": res = 0; break;
                    }
                    break;
                case 3:
                    switch (combo[3])
                    {
                        case "Очень низкий": res = 5.48; break;
                        case "Низкий": res = 4.38; break;
                        case "Нормальный": res = 3.29; break;
                        case "Высокий": res = 2.19; break;
                        case "Очень высокий": res = 1.1; break;
                        case "Сверхвысокий": res = 0; break;
                    }
                    break;
                case 4:
                    switch (combo[4])
                    {
                        case "Очень низкий": res = 7.8; break;
                        case "Низкий": res = 6.24; break;
                        case "Нормальный": res = 4.68; break;
                        case "Высокий": res = 3.12; break;
                        case "Очень высокий": res = 1.56; break;
                        case "Сверхвысокий": res = 0; break;
                    }
                    break;
            }
            return res;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox18.Text == "" || textBox18.Text == null)
            {
                MessageBox.Show("Введите объем программного продукта", "Предупреждение");
            }
            else
            {
                double A = 2.45, B = 0.91, C = 3.67, D = 0.28, E, SCED = 1, pmNS, size, pm, tm, eaf = 1, eafS = 1, factor;
                //pmNS – рассчитанная трудоемкость проекта без учета множителя SCED, определяющего сжатие расписания. 
                //n = 7 для eafS
                size = Convert.ToDouble(textBox18.Text);
                factor = Convert.ToDouble(textBox19.Text);
                E = B + 0.01 * factor;//1,2262 | 0,91
                // eaf произведение комобоксов
                for (int k = 0; k < 16; k++)
                {
                    eafS *= get_emj2(k);
                }
                switch (Convert.ToString(comboBox48.SelectedItem))
                {
                    case "Очень низкий": SCED = 1.43; break;
                    case "Низкий": SCED = 1.14; break;
                    case "Нормальный": SCED = 1; break;
                    case "Высокий": SCED = 1; break;
                    case "Очень высокий": SCED = 1; break;
                }
                double prom = Math.Pow(size, E);
                pmNS = eafS * A * prom;
                eaf = eafS * SCED;
                pm = eaf * A * Math.Pow(size, E);//если ввести иысячу строк кода,то Е всегда равно 1
                tm = SCED * C * Math.Pow(pmNS, (D + 0.2 * (E - B)));
                textBox17.Text = Convert.ToString(Math.Round(pm, 2));
                textBox16.Text = Convert.ToString(Math.Round(tm, 2));
                textBox15.Text = Convert.ToString(Math.Round(eaf, 2));
                textBox14.Text = Convert.ToString(Math.Round(eafS, 2));
                groupBox13.Visible = true;
            }
        }//считаем Post Architecture

        private double get_emj2(int i)
        {
            double res = 1;
            string[] combo = new string[16] { Convert.ToString(comboBox35.SelectedItem), Convert.ToString(comboBox36.SelectedItem), Convert.ToString(comboBox37.SelectedItem), Convert.ToString(comboBox38.SelectedItem), Convert.ToString(comboBox39.SelectedItem), Convert.ToString(comboBox40.SelectedItem), Convert.ToString(comboBox41.SelectedItem), Convert.ToString(comboBox42.SelectedItem), Convert.ToString(comboBox43.SelectedItem), Convert.ToString(comboBox44.SelectedItem), Convert.ToString(comboBox45.SelectedItem), Convert.ToString(comboBox49.SelectedItem), Convert.ToString(comboBox50.SelectedItem), Convert.ToString(comboBox51.SelectedItem), Convert.ToString(comboBox46.SelectedItem), Convert.ToString(comboBox47.SelectedItem)};
            switch (i)
            {                
                case 0:
                    switch (combo[0])
                    {
                        case "Очень низкий": res = 1.42; break;
                        case "Низкий": res = 1.29; break;
                        case "Нормальный": res = 1; break;
                        case "Высокий": res = 0.85; break;
                        case "Очень высокий": res = 0.71; break;
                    }
                    break;

                case 1:
                    switch (combo[1])
                    {
                        case "Очень низкий": res = 1.22; break;
                        case "Низкий": res = 1.1; break;
                        case "Нормальный": res = 1; break;
                        case "Высокий": res = 0.88; break;
                        case "Очень высокий": res = 0.81; break;
                    }
                    break;
                case 2:
                    switch (combo[2])
                    {
                        case "Очень низкий": res = 1.34; break;
                        case "Низкий": res = 1.15; break;
                        case "Нормальный": res = 1; break;
                        case "Высокий": res = 0.88; break;
                        case "Очень высокий": res = 0.76; break;
                    }
                    break;
                                    
                case 3:
                    switch (combo[3])
                    {
                        case "Очень низкий": res = 1.29; break;
                        case "Низкий": res = 1.12; break;
                        case "Нормальный": res = 1; break;
                        case "Высокий": res = 0.9; break;
                        case "Очень высокий": res = 0.81; break;
                    }
                    break;
                case 4:
                    switch (combo[4])
                    {
                        case "Очень низкий": res = 1.19; break;
                        case "Низкий": res = 1.09; break;
                        case "Нормальный": res = 1; break;
                        case "Высокий": res = 0.91; break;
                        case "Очень высокий": res = 0.85; break;
                    }
                    break;

                case 5:
                    switch (combo[5])
                    {
                        case "Очень низкий": res = 1.2; break;
                        case "Низкий": res = 1.09; break;
                        case "Нормальный": res = 1; break;
                        case "Высокий": res = 0.91; break;
                        case "Очень высокий": res = 0.84; break;
                    }
                    break;

                case 6:
                    switch (combo[6])
                    {
                        case "Очень низкий": res = 0.84; break;
                        case "Низкий": res = 0.92; break;
                        case "Нормальный": res = 1; break;
                        case "Высокий": res = 1.1; break;
                        case "Очень высокий": res = 1.26; break;
                    }
                    break;
                
                case 7:
                    switch (combo[7])
                    {
                        case "Низкий": res = 0.23; break;
                        case "Нормальный": res = 1; break;
                        case "Высокий": res = 1.14; break;
                        case "Очень высокий": res = 1.28; break;
                    }
                    break;

                case 8:
                    switch (combo[8])
                    {
                        case "Очень низкий": res = 0.73; break;
                        case "Низкий": res = 0.87; break;
                        case "Нормальный": res = 1; break;
                        case "Высокий": res = 1.17; break;
                        case "Очень высокий": res = 1.34; break;
                        case "Сверхвысокий": res = 1.74; break;
                    }
                    break;

                case 9:
                    switch (combo[9])
                    {
                        case "Низкий": res = 0.95; break;
                        case "Нормальный": res = 1; break;
                        case "Высокий": res = 1.07; break;
                        case "Очень высокий": res = 1.15; break;
                        case "Сверхвысокий": res = 1.24; break;
                    }
                    break;

                case 10:
                    switch (combo[10])
                    {
                        case "Очень низкий": res = 0.81; break;
                        case "Низкий": res = 0.91; break;
                        case "Нормальный": res = 1; break;
                        case "Высокий": res = 1.11; break;
                        case "Очень высокий": res = 1.23; break;
                    }
                    break;

                case 11:
                    switch (combo[11])
                    {
                        case "Нормальный": res = 1; break;
                        case "Высокий": res = 1.11; break;
                        case "Очень высокий": res = 1.29; break;
                        case "Сверхвысокий": res = 1.63; break;
                    }
                    break;
                
                case 12:
                    switch (combo[12])
                    {
                        case "Нормальный": res = 1; break;
                        case "Высокий": res = 1.05; break;
                        case "Очень высокий": res = 1.17; break;
                        case "Сверхвысокий": res = 1.46; break;
                    }
                    break;

                case 13:
                    switch (combo[13])
                    {
                        case "Низкий": res = 0.87; break;
                        case "Нормальный": res = 1; break;
                        case "Высокий": res = 1.15; break;
                        case "Очень высокий": res = 1.3; break;
                    }
                    break;

                case 14:
                    switch (combo[14])
                    {
                        case "Очень низкий": res = 1.17; break;
                        case "Низкий": res = 1.09; break;
                        case "Нормальный": res = 1; break;
                        case "Высокий": res = 0.93; break;
                        case "Очень высокий": res = 0.78; break;
                    }
                    break;
                case 15:
                    switch (combo[15])
                    {
                        case "Очень низкий": res = 1.22; break;
                        case "Низкий": res = 1.09; break;
                        case "Нормальный": res = 1; break;
                        case "Высокий": res = 0.93; break;
                        case "Очень высокий": res = 0.86; break;
                        case "Сверхвысокий": res = 0.8; break;
                    }
                    break;
            }
            return res;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox14.Text = ""; 
            textBox15.Text = "";             
            textBox16.Text = "";             
            textBox17.Text = "";             
            textBox18.Text = "";             
            textBox19.Text = "";
            groupBox13.Visible = false;
            groupBox14.Visible = false;
            groupBox20.Visible = false;
            groupBox21.Visible = false;
            groupBox22.Visible = false;
            groupBox23.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            radioButton7.Visible = false;
            radioButton8.Visible = false;
            button9.Visible = false;
        }

        private void groupBox13_Enter(object sender, EventArgs e)
        {

        }
    }
}
