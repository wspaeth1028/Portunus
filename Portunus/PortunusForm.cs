using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            e.Effect = DragDropEffects.All;
            this.textBox1.Text = "Farts";
            this.pnlDropHere.Visible = true;
            this.AllowDrop = false;
            string[] filelist = e.Data.GetData(DataFormats.FileDrop) as string[];
            for (int i = 0; i < filelist.Length; i++)
            {
                string path = Path.GetFileName(filelist[i]);
            }
        }

        private void OnDragDrop(object sender, DragEventArgs e)
        {
            string[] fileList = e.Data.GetData(DataFormats.FileDrop, false) as string[];
            this.pnlDropHere.Visible = false;
            this.AllowDrop = true;
        }

        private void OnDragLeave(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.pnlDropHere.Visible = false;
            this.AllowDrop = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
