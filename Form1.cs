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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Run_Button_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            c = Convert.ToDouble(txtC.Text);
            Triangle triangle = new Triangle(a, b, c);
            ListView.Items.Add("Сторона а");
            ListView.Items.Add("Сторона b");
            ListView.Items.Add("Сторона c");
            ListView.Items.Add("Периметр");
            ListView.Items.Add("Площадь");
            ListView.Items.Add("Существует?");
            ListView.Items.Add("Спецификатор");
            ListView.Items[0].SubItems.Add(triangle.outputA());
            ListView.Items[1].SubItems.Add(triangle.outputB());
            ListView.Items[2].SubItems.Add(triangle.outputC());
            ListView.Items[3].SubItems.Add(Convert.ToString(triangle.Perimeter()));
            ListView.Items[4].SubItems.Add(Convert.ToString(triangle.Surface()));
            if (triangle.ExistTriangle) { ListView.Items[5].SubItems.Add("Существует"); }
            else ListView.Items[5].SubItems.Add("Не существует");
        }

    }
}
