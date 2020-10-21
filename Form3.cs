using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tund
{
    public partial class Form3 : Form
    {
        ListBox _list;
        Button btn;
        Label lA, lB, lC, lH;
        TextBox txtA, txtB, txtC, txtH;
        MainMenu menu;
        PictureBox box;
        RadioButton r1, r2;
        double a, b, c, h;
        public Form3()
        {
            this.Size = new Size(310, 470);
            this.Text = "Triangle";
            this.BackColor = Color.LightGray;
            this.Icon = new Icon( "pyramid.ico" );
            this.MaximizeBox = false;

            _list = new ListBox();
            _list.Location = new Point(10, 10);
            _list.Size = new Size(275,200);
            _list.BackColor = Color.FromArgb(255, 128, 255);
            Controls.Add(_list);

            btn = new Button();
            btn.Location = new Point(120, 350);
            btn.Size = new Size(80,40);
            btn.Click += Btn_Click;
            btn.Text = "Запуск";
            Controls.Add(btn);

            r1 = new RadioButton();
            r1.Location = new Point(10, 340);
            r1.Text = "Найти высоту";
            r1.CheckedChanged += R1_CheckedChanged;
            Controls.Add(r1);

            r2 = new RadioButton();
            r2.Location = new Point(10, 360);
            r2.Text = "Высота есть";
            r2.CheckedChanged += R2_CheckedChanged;
            Controls.Add(r2);

            box = new PictureBox();
            box.Location = new Point(190, 220);
            box.Size = new Size(100, 100);
            box.SizeMode = PictureBoxSizeMode.StretchImage;
            box.ImageLocation = "giphy.gif";
            Controls.Add(box);

            lA = new Label();
            lA.Size = new Size(70, 30);
            lA.Location = new Point(10, 220);
            lA.Text = "Сторона А";
            Controls.Add(lA);

            lB = new Label();
            lB.Size = new Size(70, 30);
            lB.Location = new Point(10, 250);
            lB.Text = "Сторона B";
            Controls.Add(lB);

            lC = new Label();
            lC.Size = new Size(70, 30);
            lC.Location = new Point(10, 280);
            lC.Text = "Сторона C";
            Controls.Add(lC);

            lH = new Label();
            lH.Size = new Size(70, 30);
            lH.Location = new Point(10, 310);
            lH.Text = "Сторона H";
            Controls.Add(lH);

            txtA = new TextBox();
            txtA.Location = new Point(80, 220);
            txtA.BackColor = Color.FromArgb(255, 153, 255);
            txtA.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(txtA);

            txtB = new TextBox();
            txtB.Location = new Point(80, 250);
            txtB.BackColor = Color.FromArgb(255, 179, 255);
            txtB.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(txtB);

            txtC = new TextBox();
            txtC.Location = new Point(80, 280);
            txtC.BackColor = Color.FromArgb(255, 204, 255);
            txtC.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(txtC);

            txtH = new TextBox();
            txtH.Location = new Point(80, 310);
            txtH.BackColor = Color.FromArgb(255, 230, 255);
            txtH.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(txtH);

            menu = new MainMenu();
            MenuItem item = new MenuItem("File");
            item.MenuItems.Add("New", new EventHandler(item_new));
            item.MenuItems.Add("EXIT", new EventHandler(item_exit));
            menu.MenuItems.Add(item);
            this.Menu = menu;
        }

        private void R2_CheckedChanged(object sender, EventArgs e)
        {
            lH.Visible = true;
            txtH.Visible = true;
        }

        private void R1_CheckedChanged(object sender, EventArgs e)
        {
            lH.Visible = false;
            txtH.Visible = false;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int R = rnd.Next(0, 255);
            int G = rnd.Next(0, 255);
            int B = rnd.Next(0, 255);
            btn.BackColor = Color.FromArgb(R, G, B);
            _list.Items.Clear();
            if (txtA.Text == "" || txtB.Text == "" || txtC.Text == "" || txtH.Text == "")
            {
                a = 0;
                b = 0;
                c = 0;
                h = 0;
            }
            else
            {
                if (r1.Checked)
                {
                    a = Convert.ToDouble(txtA.Text);
                    b = Convert.ToDouble(txtB.Text);
                    c = Convert.ToDouble(txtC.Text);
                    h = 0;
                }
                else
                {
                    a = Convert.ToDouble(txtA.Text);
                    b = Convert.ToDouble(txtB.Text);
                    c = Convert.ToDouble(txtC.Text);
                    h = Convert.ToDouble(txtH.Text);
                }
            }
            Triangle triangle = new Triangle(a, b, c, h);
            _list.Items.Add("Сторона а:"+ " " + triangle.outputA());
            _list.Items.Add("Сторона b:" + " " + triangle.outputB());
            _list.Items.Add("Сторона c:" + " " + triangle.outputC());
            _list.Items.Add("Высота:" + " " + triangle.outputH());
            _list.Items.Add("Периметр:" + " " + Convert.ToString(triangle.Perimeter()));
            _list.Items.Add("Полупериметр:" + " " + Convert.ToString(triangle.PoluPerimeter()));
            _list.Items.Add("Площадь:" + " " + Convert.ToString(triangle.Surface()));
            if (triangle.ExistTriangle) { _list.Items.Add("Существует?  Существует"); }
            else _list.Items.Add("Существует?  Не существует");
            _list.Items.Add("Спецификатор:" + " " + triangle.TypeOfTriangle());
            _list.Items.Add("Медиана:" + " " + Convert.ToString(triangle.mediana()));
            _list.Items.Add("Биссектриса:" + " " + Convert.ToString(triangle.bisectrisa()));
            _list.Items.Add("Синус угла А:" + " " + Convert.ToString(triangle.Sin()));
        }

        private void item_exit(object sender, EventArgs e)
        {
            this.Close();
        }
        private void item_new(object sender, EventArgs e)
        {
            _list.Items.Clear();
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            txtH.Clear();
        }
    }
}
