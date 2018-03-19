using System.Windows.Forms;

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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtKeyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtKeyOwner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtKeyVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkSendIN = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chkSendTN = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chkSendCA = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlDropHere = new ExtendedPanel();
            this.lblDropHere = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlDropHere.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKeyName
            // 
            this.txtKeyName.HeaderText = "Name";
            this.txtKeyName.Name = "txtKeyName";
            this.txtKeyName.Width = 60;

            // 
            // txtKeyOwner
            // 
            this.txtKeyOwner.HeaderText = "Owner";
            this.txtKeyOwner.Name = "txtKeyOwner";
            this.txtKeyOwner.Width = 200;
            // 
            // txtKeyVersion
            // 
            this.txtKeyVersion.HeaderText = "Ver";
            this.txtKeyVersion.Name = "txtKeyVersion";
            this.txtKeyVersion.Width = 30;
            // 
            // chkSendIN
            // 
            this.chkSendIN.HeaderText = "IN";
            this.chkSendIN.Name = "chkSendIN";
            this.chkSendIN.Width = 30;
            // 
            // chkSendTN
            // 
            this.chkSendTN.HeaderText = "TN";
            this.chkSendTN.Name = "chkSendTN";
            this.chkSendTN.Width = 30;
            // 
            // chkSendCA
            // 
            this.chkSendCA.HeaderText = "CA";
            this.chkSendCA.Name = "chkSendCA";
            this.chkSendCA.Width = 30;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtKeyName,
            this.txtKeyOwner,
            this.txtKeyVersion,
            this.chkSendIN,
            this.chkSendTN,
            this.chkSendCA});
            this.dataGridView1.Columns["txtKeyName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGridView1.Location = new System.Drawing.Point(12, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(407, 163);
            this.dataGridView1.TabIndex = 2;
            // 
            // pnlDropHere
            // 
            this.pnlDropHere.AllowDrop = true;
            this.pnlDropHere.Controls.Add(this.lblDropHere);
            this.pnlDropHere.Location = new System.Drawing.Point(12, 12);
            this.pnlDropHere.Name = "pnlDropHere";
            this.pnlDropHere.Opacity = 70;
            this.pnlDropHere.Size = new System.Drawing.Size(24, 238);
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
            this.lblDropHere.Location = new System.Drawing.Point(173, 136);
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
            this.ClientSize = new System.Drawing.Size(431, 262);
            this.Controls.Add(this.pnlDropHere);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PortunusForm";
            this.Text = "Portunus";
            this.Load += new System.EventHandler(this.PortunusForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlDropHere.ResumeLayout(false);
            this.pnlDropHere.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        
        private ExtendedPanel pnlDropHere;
        private System.Windows.Forms.Label lblDropHere;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtKeyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtKeyOwner;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtKeyVersion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkSendCA;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkSendIN;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkSendTN;
    }
}

