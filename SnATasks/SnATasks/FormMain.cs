using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnATasks
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonChart_Click(object sender, EventArgs e)
        {
            FormChart f = new FormChart();
            f.Show();
        }

        private void buttonNarayana_Click(object sender, EventArgs e)
        {
            FormNarayana f = new FormNarayana();
            f.Show();
        }

        private void buttonBoxes_Click(object sender, EventArgs e)
        {
            FormBoxes f = new FormBoxes();
            f.Show();
        }

        private void buttonSeries_Click(object sender, EventArgs e)
        {
            FormSeries f = new FormSeries();
            f.Show();
        }

        private void buttonArrays_Click(object sender, EventArgs e)
        {
            FormArrays f = new FormArrays();
            f.Show();
        }

        private void buttonTriangles_Click(object sender, EventArgs e)
        {
            FormTriangles f = new FormTriangles();
            f.Show();
        }
    }
}
