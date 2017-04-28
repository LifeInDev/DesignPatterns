namespace Observer
{
    partial class Form1
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSubsType = new System.Windows.Forms.TextBox();
            this.cboSubsState = new System.Windows.Forms.ComboBox();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.btnUnSubscribe = new System.Windows.Forms.Button();
            this.btnCancelAllSubscription = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(13, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(259, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtSubsType
            // 
            this.txtSubsType.Location = new System.Drawing.Point(13, 40);
            this.txtSubsType.Name = "txtSubsType";
            this.txtSubsType.Size = new System.Drawing.Size(259, 20);
            this.txtSubsType.TabIndex = 1;
            // 
            // cboSubsState
            // 
            this.cboSubsState.FormattingEnabled = true;
            this.cboSubsState.Items.AddRange(new object[] {
            "Aktif",
            "Pasif"});
            this.cboSubsState.Location = new System.Drawing.Point(13, 67);
            this.cboSubsState.Name = "cboSubsState";
            this.cboSubsState.Size = new System.Drawing.Size(259, 21);
            this.cboSubsState.TabIndex = 2;
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Location = new System.Drawing.Point(13, 95);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(75, 23);
            this.btnSubscribe.TabIndex = 3;
            this.btnSubscribe.Text = "Takip Et";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
            // 
            // btnUnSubscribe
            // 
            this.btnUnSubscribe.Location = new System.Drawing.Point(197, 95);
            this.btnUnSubscribe.Name = "btnUnSubscribe";
            this.btnUnSubscribe.Size = new System.Drawing.Size(75, 23);
            this.btnUnSubscribe.TabIndex = 4;
            this.btnUnSubscribe.Text = "Takibi Bırak";
            this.btnUnSubscribe.UseVisualStyleBackColor = true;
            // 
            // btnCancelAllSubscription
            // 
            this.btnCancelAllSubscription.Location = new System.Drawing.Point(13, 124);
            this.btnCancelAllSubscription.Name = "btnCancelAllSubscription";
            this.btnCancelAllSubscription.Size = new System.Drawing.Size(259, 23);
            this.btnCancelAllSubscription.TabIndex = 5;
            this.btnCancelAllSubscription.Text = "Tüm takip listesini sil";
            this.btnCancelAllSubscription.UseVisualStyleBackColor = true;
            this.btnCancelAllSubscription.Click += new System.EventHandler(this.btnCancelAllSubscription_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 154);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(259, 355);
            this.listBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 532);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnCancelAllSubscription);
            this.Controls.Add(this.btnUnSubscribe);
            this.Controls.Add(this.btnSubscribe);
            this.Controls.Add(this.cboSubsState);
            this.Controls.Add(this.txtSubsType);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSubsType;
        private System.Windows.Forms.ComboBox cboSubsState;
        private System.Windows.Forms.Button btnSubscribe;
        private System.Windows.Forms.Button btnUnSubscribe;
        private System.Windows.Forms.Button btnCancelAllSubscription;
        private System.Windows.Forms.ListBox listBox1;
    }
}