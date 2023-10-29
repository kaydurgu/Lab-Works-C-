using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void arrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form2 child = new Form2();
            child.MdiParent = this;
            child.Icon = this.Icon;
            child.Show();
            child = null;
            LayoutMdi(MdiLayout.ArrangeIcons);

        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 child = new Form2();
            child.MdiParent = this;
            child.Icon = this.Icon;
            child.Show();
            child = null;

            LayoutMdi(MdiLayout.Cascade);

        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form2 child = new Form2();
            child.MdiParent = this;
            child.Icon = this.Icon;
            child.Show();
            child = null;

            LayoutMdi(MdiLayout.TileHorizontal);

        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 child = new Form2();
            child.MdiParent = this;
            child.Icon = this.Icon;
            child.Show();
            child = null;

            LayoutMdi(MdiLayout.TileVertical);

        }

        private void расчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 child = new Form3();
            child.MdiParent = this;
            child.Icon = this.Icon;
            child.Show();
            child = null;
            LayoutMdi(MdiLayout.ArrangeIcons);

        }
    }
}
