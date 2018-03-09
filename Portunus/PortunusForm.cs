using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portunus
{
    public partial class PortunusForm : Form
    {
        public PortunusForm()
        {
            InitializeComponent();
            this.DragEnter += new DragEventHandler(OnDragEnter);
        }

        private void OnDragEnter(object sender, DragEventArgs e)
        {
            this.textBox1.Text = "Farts";
        }

        private void OnDragDrop(object sender, DragEventArgs e)
        {

        }

        private void OnDragLeave(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
