namespace WindowsFormsApplication1
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
            this.buttonFunction = new System.Windows.Forms.Button();
            this.selectFunction = new System.Windows.Forms.ComboBox();
            this.filePath = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataShow = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timeShow = new System.Windows.Forms.TextBox();
            this.chk = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonFunction
            // 
            this.buttonFunction.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.buttonFunction.Location = new System.Drawing.Point(320, 73);
            this.buttonFunction.Name = "buttonFunction";
            this.buttonFunction.Size = new System.Drawing.Size(81, 28);
            this.buttonFunction.TabIndex = 0;
            this.buttonFunction.Text = "Read";
            this.buttonFunction.UseVisualStyleBackColor = true;
            this.buttonFunction.Click += new System.EventHandler(this.button1_Click);
            // 
            // selectFunction
            // 
            this.selectFunction.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.selectFunction.FormattingEnabled = true;
            this.selectFunction.Items.AddRange(new object[] {
            "Read",
            "Write",
            "Merge Sort",
            "Quick Sort",
            "Heap Sort",
            "Counting Sort",
            "Binary Search"});
            this.selectFunction.Location = new System.Drawing.Point(103, 77);
            this.selectFunction.Name = "selectFunction";
            this.selectFunction.Size = new System.Drawing.Size(211, 24);
            this.selectFunction.TabIndex = 1;
            this.selectFunction.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // filePath
            // 
            this.filePath.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.filePath.Location = new System.Drawing.Point(65, 30);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(261, 24);
            this.filePath.TabIndex = 2;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.buttonBrowse.Location = new System.Drawing.Point(332, 26);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(69, 27);
            this.buttonBrowse.TabIndex = 3;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "File:";
            // 
            // dataShow
            // 
            this.dataShow.Location = new System.Drawing.Point(128, 133);
            this.dataShow.Multiline = true;
            this.dataShow.Name = "dataShow";
            this.dataShow.ReadOnly = true;
            this.dataShow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataShow.Size = new System.Drawing.Size(272, 174);
            this.dataShow.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(24, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Function:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(5, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Time Elapsed(s)";
            // 
            // timeShow
            // 
            this.timeShow.Location = new System.Drawing.Point(12, 219);
            this.timeShow.Name = "timeShow";
            this.timeShow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.timeShow.Size = new System.Drawing.Size(95, 20);
            this.timeShow.TabIndex = 7;
            // 
            // chk
            // 
            this.chk.AutoSize = true;
            this.chk.Location = new System.Drawing.Point(12, 135);
            this.chk.Name = "chk";
            this.chk.Size = new System.Drawing.Size(90, 30);
            this.chk.TabIndex = 8;
            this.chk.Text = "Show Results\r\n(longer time)";
            this.chk.UseVisualStyleBackColor = true;
            this.chk.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 319);
            this.Controls.Add(this.chk);
            this.Controls.Add(this.timeShow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataShow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.selectFunction);
            this.Controls.Add(this.buttonFunction);
            this.Name = "Form1";
            this.Text = "Assignment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFunction;
        private System.Windows.Forms.ComboBox selectFunction;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox timeShow;
        private System.Windows.Forms.TextBox dataShow;
        private System.Windows.Forms.CheckBox chk;
    }
}

