
namespace QadamBoosi_App
{
    partial class StartForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.nmTotal = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.nmZiyafat = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnZiyafat = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmZiyafat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "START TIME";
            // 
            // dtTime
            // 
            this.dtTime.CustomFormat = "";
            this.dtTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtTime.Location = new System.Drawing.Point(85, 68);
            this.dtTime.Name = "dtTime";
            this.dtTime.Size = new System.Drawing.Size(694, 38);
            this.dtTime.TabIndex = 1;
            this.dtTime.Value = new System.DateTime(2021, 12, 12, 20, 33, 49, 0);
            this.dtTime.ValueChanged += new System.EventHandler(this.dtTime_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(428, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "TOTAL QADAMBOSI / MEMBER";
            // 
            // nmTotal
            // 
            this.nmTotal.Location = new System.Drawing.Point(85, 190);
            this.nmTotal.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nmTotal.Name = "nmTotal";
            this.nmTotal.Size = new System.Drawing.Size(694, 38);
            this.nmTotal.TabIndex = 3;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(782, 487);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(403, 102);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "START QADAMBOSI";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // nmZiyafat
            // 
            this.nmZiyafat.Location = new System.Drawing.Point(85, 314);
            this.nmZiyafat.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nmZiyafat.Name = "nmZiyafat";
            this.nmZiyafat.Size = new System.Drawing.Size(694, 38);
            this.nmZiyafat.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "TOTAL ZIYAFAT";
            // 
            // btnZiyafat
            // 
            this.btnZiyafat.Location = new System.Drawing.Point(1222, 487);
            this.btnZiyafat.Name = "btnZiyafat";
            this.btnZiyafat.Size = new System.Drawing.Size(322, 102);
            this.btnZiyafat.TabIndex = 7;
            this.btnZiyafat.Text = "START ZIYAFAT";
            this.btnZiyafat.UseVisualStyleBackColor = true;
            this.btnZiyafat.Click += new System.EventHandler(this.btnZiyafat_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(85, 413);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(694, 38);
            this.txtName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "LABEL VALUE";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1565, 648);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnZiyafat);
            this.Controls.Add(this.nmZiyafat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.nmTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtTime);
            this.Controls.Add(this.label1);
            this.Name = "StartForm";
            this.Text = "ITS COUNTER";
            this.Load += new System.EventHandler(this.StartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmZiyafat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmTotal;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown nmZiyafat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnZiyafat;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
    }
}