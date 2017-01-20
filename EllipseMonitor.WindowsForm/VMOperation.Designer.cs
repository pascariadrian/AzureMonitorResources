namespace EllipseMonitor.WindowsForm
{
    partial class VMOperation
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
            this.cmbVMList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVMStatus = new System.Windows.Forms.Label();
            this.pbVMStatusVM = new System.Windows.Forms.PictureBox();
            this.btnRestartVM = new System.Windows.Forms.Button();
            this.btnStopVM = new System.Windows.Forms.Button();
            this.btnStartVM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbVMStatusVM)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbVMList
            // 
            this.cmbVMList.FormattingEnabled = true;
            this.cmbVMList.Location = new System.Drawing.Point(65, 36);
            this.cmbVMList.Name = "cmbVMList";
            this.cmbVMList.Size = new System.Drawing.Size(154, 21);
            this.cmbVMList.TabIndex = 0;
            this.cmbVMList.SelectedIndexChanged += new System.EventHandler(this.cmbVMList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "VM:";
            // 
            // lblVMStatus
            // 
            this.lblVMStatus.AutoSize = true;
            this.lblVMStatus.Location = new System.Drawing.Point(245, 41);
            this.lblVMStatus.Name = "lblVMStatus";
            this.lblVMStatus.Size = new System.Drawing.Size(59, 13);
            this.lblVMStatus.TabIndex = 16;
            this.lblVMStatus.Text = "VM Status:";
            // 
            // pbVMStatusVM
            // 
            this.pbVMStatusVM.Location = new System.Drawing.Point(310, 12);
            this.pbVMStatusVM.Name = "pbVMStatusVM";
            this.pbVMStatusVM.Size = new System.Drawing.Size(73, 69);
            this.pbVMStatusVM.TabIndex = 15;
            this.pbVMStatusVM.TabStop = false;
            this.pbVMStatusVM.Visible = false;
            // 
            // btnRestartVM
            // 
            this.btnRestartVM.Enabled = false;
            this.btnRestartVM.Location = new System.Drawing.Point(225, 117);
            this.btnRestartVM.Name = "btnRestartVM";
            this.btnRestartVM.Size = new System.Drawing.Size(75, 23);
            this.btnRestartVM.TabIndex = 14;
            this.btnRestartVM.Text = "Restart";
            this.btnRestartVM.UseVisualStyleBackColor = true;
            this.btnRestartVM.Click += new System.EventHandler(this.btnRestartVM_Click);
            // 
            // btnStopVM
            // 
            this.btnStopVM.Enabled = false;
            this.btnStopVM.Location = new System.Drawing.Point(116, 118);
            this.btnStopVM.Name = "btnStopVM";
            this.btnStopVM.Size = new System.Drawing.Size(75, 23);
            this.btnStopVM.TabIndex = 13;
            this.btnStopVM.Text = "Stop";
            this.btnStopVM.UseVisualStyleBackColor = true;
            this.btnStopVM.Click += new System.EventHandler(this.btnStopVM_Click);
            // 
            // btnStartVM
            // 
            this.btnStartVM.Enabled = false;
            this.btnStartVM.Location = new System.Drawing.Point(17, 117);
            this.btnStartVM.Name = "btnStartVM";
            this.btnStartVM.Size = new System.Drawing.Size(75, 23);
            this.btnStartVM.TabIndex = 12;
            this.btnStartVM.Text = "Start";
            this.btnStartVM.UseVisualStyleBackColor = true;
            this.btnStartVM.Click += new System.EventHandler(this.btnStartVM_Click);
            // 
            // VMOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 182);
            this.Controls.Add(this.lblVMStatus);
            this.Controls.Add(this.pbVMStatusVM);
            this.Controls.Add(this.btnRestartVM);
            this.Controls.Add(this.btnStopVM);
            this.Controls.Add(this.btnStartVM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbVMList);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VMOperation";
            this.ShowIcon = false;
            this.Text = "VM Operation";
            this.Load += new System.EventHandler(this.VMOperation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbVMStatusVM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbVMList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVMStatus;
        private System.Windows.Forms.PictureBox pbVMStatusVM;
        private System.Windows.Forms.Button btnRestartVM;
        private System.Windows.Forms.Button btnStopVM;
        private System.Windows.Forms.Button btnStartVM;
    }
}