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
        public Form3()
        {
            this.Size = new Size(300, 450);
            _list = new ListBox();
            _list.Location = new Point(10, 10);
            _list.Size = new Size(265,150);
            Controls.Add(_list);

            btn = new Button();
            btn.Location = new Point(100, 350);
            btn.Size = new Size(80,40);
            btn.Click += Btn_Click;
            btn.Text = "Запуск";
            Controls.Add(btn);

            lA = new Label();
            lA.Size = new Size(70, 30);
            lA.Location = new Point(50, 180);
            lA.Text = "Сторона А";
            Controls.Add(lA);

            lB = new Label();
            lB.Size = new Size(70, 30);
            lB.Location = new Point(50, 210);
            lB.Text = "Сторона B";
            Controls.Add(lB);

            lC = new Label();
            lC.Size = new Size(70, 30);
            lC.Location = new Point(50, 240);
            lC.Text = "Сторона C";
            Controls.Add(lC);

            lH = new Label();
            lH.Size = new Size(70, 30);
            lH.Location = new Point(50, 270);
            lH.Text = "Сторона H";
            Controls.Add(lH);

            txtA = new TextBox();
            txtA.Location = new Point(120, 180);
            Controls.Add(txtA);

            txtB = new TextBox();
            txtB.Location = new Point(120, 210);
            Controls.Add(txtB);

            txtC = new TextBox();
            txtC.Location = new Point(120, 240);
            Controls.Add(txtC);

            txtH = new TextBox();
            txtH.Location = new Point(120, 270);
            Controls.Add(txtH);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            _list.Items.Clear();
            double a, b, c, h;
            if (txtA.Text == "" || txtB.Text == "" || txtC.Text == "" || txtH.Text == "")
            {
                a = 0;
                b = 0;
                c = 0;
                h = 0;
            }
            else
            {
                a = Convert.ToDouble(txtA.Text);
                b = Convert.ToDouble(txtB.Text);
                c = Convert.ToDouble(txtC.Text);
                h = Convert.ToDouble(txtH.Text);
            }
            Triangle triangle = new Triangle(a, b, c, h);
            _list.Items.Add("Сторона а:"+ " " + triangle.outputA());
            _list.Items.Add("Сторона b:" + " " + triangle.outputB());
            _list.Items.Add("Сторона c:" + " " + triangle.outputC());
            _list.Items.Add("Высота:" + " " + triangle.outputH());
            _list.Items.Add("Периметр:" + " " + Convert.ToString(triangle.Perimeter()));
            _list.Items.Add("Площадь:" + " " + Convert.ToString(triangle.Surface()));
            if (triangle.ExistTriangle) { _list.Items.Add("Существует?  Существует"); }
            else _list.Items.Add("Существует?  Не существует");
            _list.Items.Add("Спецификатор:" + " " + triangle.TypeOfTriangle());
            _list.Items.Add("Медиана:" + " " + Convert.ToString(triangle.mediana()));
            _list.Items.Add("Биссектриса:" + " " + Convert.ToString(triangle.bisectrisa()));
        }
    }
}
