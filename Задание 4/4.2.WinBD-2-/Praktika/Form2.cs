using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktika
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oleDbDataAdapter1.Fill(dataSet111.Заказчики);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oleDbDataAdapter1.Update(dataSet111);
        }
    }
}
