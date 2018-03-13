namespace Portunus
{
    partial class PortunusForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnlDropHere = new ExtendedPanel();
            this.lblDropHere = new System.Windows.Forms.Label();
            this.pnlDropHere.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pnlDropHere
            // 
            this.pnlDropHere.AllowDrop = true;
            this.pnlDropHere.Controls.Add(this.lblDropHere);
            this.pnlDropHere.Location = new System.Drawing.Point(12, 12);
            this.pnlDropHere.Name = "pnlDropHere";
            this.pnlDropHere.Opacity = 70;
            this.pnlDropHere.Size = new System.Drawing.Size(260, 238);
            this.pnlDropHere.TabIndex = 1;
            this.pnlDropHere.Visible = false;
            this.pnlDropHere.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnDragDrop);
            this.pnlDropHere.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnDragEnter);
            this.pnlDropHere.DragLeave += new System.EventHandler(this.OnDragLeave);
            // 
            // lblDropHere
            // 
            this.lblDropHere.AllowDrop = true;
            this.lblDropHere.AutoSize = true;
            this.lblDropHere.Location = new System.Drawing.Point(112, 105);
            this.lblDropHere.Name = "lblDropHere";
            this.lblDropHere.Size = new System.Drawing.Size(75, 13);
            this.lblDropHere.TabIndex = 0;
            this.lblDropHere.Text = "Drop File Here";
            this.lblDropHere.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PortunusForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.pnlDropHere);
            this.Controls.Add(this.textBox1);
            this.Name = "PortunusForm";
            this.Text = "Portunus";
            //this.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnDragDrop);
            //this.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnDragEnter);
            //this.DragLeave += new System.EventHandler(this.OnDragLeave);
            this.pnlDropHere.ResumeLayout(false);
            this.pnlDropHere.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private ExtendedPanel pnlDropHere;
        private System.Windows.Forms.Label lblDropHere;
    }
}

