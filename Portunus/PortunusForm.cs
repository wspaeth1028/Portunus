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
            this.pnlDropHere.Visible = true;
            this.AllowDrop = false;
            string[] filelist = e.Data.GetData(DataFormats.FileDrop) as string[];
            for (int i = 0; i < filelist.Length; i++)
            {
                string path = Path.GetFileName(filelist[i]);
                string fileExt = Path.GetExtension(filelist[i]);
                if (fileExt != "backup" || fileExt != "key")
                    continue;

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
            this.pnlDropHere.Visible = false;
            this.AllowDrop = true;
        }

        private void Update_DataGrid(string name, string owner, string ver, bool IN, bool TN, bool CA, bool backup)
        {

        }
     
        private void PortunusForm_Load(object sender, EventArgs e)
        {

        }
    }
}
