
namespace glWinForm1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            renderControl1 = new RenderControl();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            radioButton1 = new System.Windows.Forms.RadioButton();
            radioButton2 = new System.Windows.Forms.RadioButton();
            checkBox = new System.Windows.Forms.CheckBox();
            label5 = new System.Windows.Forms.Label();
            xMinNumericUpDown = new System.Windows.Forms.NumericUpDown();
            xMaxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            pointsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            yMinNumericUpDown = new System.Windows.Forms.NumericUpDown();
            yMaxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            panel1 = new System.Windows.Forms.Panel();
            button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)xMinNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xMaxNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pointsNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yMinNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yMaxNumericUpDown).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // renderControl1
            // 
            renderControl1.BackColor = System.Drawing.Color.SlateGray;
            renderControl1.Dock = System.Windows.Forms.DockStyle.Top;
            renderControl1.ForeColor = System.Drawing.Color.White;
            renderControl1.choice = 1;
            renderControl1.Location = new System.Drawing.Point(0, 0);
            renderControl1.Name = "renderControl1";
            renderControl1.showY = false;
            renderControl1.Size = new System.Drawing.Size(690, 392);
            renderControl1.TabIndex = 0;
            renderControl1.TextCodePage = 1251;
            renderControl1.XMax = 10D;
            renderControl1.XMin = -10D;
            renderControl1.YMax = 0D;
            renderControl1.YMin = 0D;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(35, 15);
            label1.TabIndex = 1;
            label1.Text = "Xmin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(10, 47);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(37, 15);
            label2.TabIndex = 2;
            label2.Text = "Xmax";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(270, 19);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(34, 15);
            label3.TabIndex = 3;
            label3.Text = "Ymin";
            label3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(270, 55);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(36, 15);
            label4.TabIndex = 4;
            label4.Text = "Ymax";
            label4.Visible = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new System.Drawing.Point(149, 85);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(47, 19);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "First";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new System.Drawing.Point(149, 110);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new System.Drawing.Size(64, 19);
            radioButton2.TabIndex = 6;
            radioButton2.Text = "Second";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // checkBox
            // 
            checkBox.AutoSize = true;
            checkBox.Location = new System.Drawing.Point(148, 11);
            checkBox.Name = "checkBox";
            checkBox.Size = new System.Drawing.Size(65, 19);
            checkBox.TabIndex = 11;
            checkBox.Text = "Show Y";
            checkBox.UseVisualStyleBackColor = true;
            checkBox.CheckedChanged += checkBox_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(5, 76);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(40, 15);
            label5.TabIndex = 12;
            label5.Text = "Points";
            // 
            // xMinNumericUpDown
            // 
            xMinNumericUpDown.Location = new System.Drawing.Point(51, 10);
            xMinNumericUpDown.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            xMinNumericUpDown.Name = "xMinNumericUpDown";
            xMinNumericUpDown.Size = new System.Drawing.Size(71, 23);
            xMinNumericUpDown.TabIndex = 14;
            xMinNumericUpDown.Value = new decimal(new int[] { 10, 0, 0, int.MinValue });
            xMinNumericUpDown.ValueChanged += xMinNumericUpDown_ValueChanged;
            // 
            // xMaxNumericUpDown
            // 
            xMaxNumericUpDown.Location = new System.Drawing.Point(51, 39);
            xMaxNumericUpDown.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            xMaxNumericUpDown.Name = "xMaxNumericUpDown";
            xMaxNumericUpDown.Size = new System.Drawing.Size(71, 23);
            xMaxNumericUpDown.TabIndex = 15;
            xMaxNumericUpDown.Value = new decimal(new int[] { 10, 0, 0, 0 });
            xMaxNumericUpDown.ValueChanged += xMaxNumericUpDown_ValueChanged;
            // 
            // pointsNumericUpDown
            // 
            pointsNumericUpDown.Location = new System.Drawing.Point(51, 68);
            pointsNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            pointsNumericUpDown.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            pointsNumericUpDown.Name = "pointsNumericUpDown";
            pointsNumericUpDown.Size = new System.Drawing.Size(71, 23);
            pointsNumericUpDown.TabIndex = 16;
            pointsNumericUpDown.Value = new decimal(new int[] { 100, 0, 0, 0 });
            pointsNumericUpDown.ValueChanged += pointsNumericUpDown_ValueChanged;
            // 
            // yMinNumericUpDown
            // 
            yMinNumericUpDown.Location = new System.Drawing.Point(312, 11);
            yMinNumericUpDown.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            yMinNumericUpDown.Name = "yMinNumericUpDown";
            yMinNumericUpDown.Size = new System.Drawing.Size(71, 23);
            yMinNumericUpDown.TabIndex = 17;
            yMinNumericUpDown.Value = new decimal(new int[] { 10, 0, 0, int.MinValue });
            yMinNumericUpDown.Visible = false;
            yMinNumericUpDown.ValueChanged += yMinNumericUpDown_ValueChanged;
            // 
            // yMaxNumericUpDown
            // 
            yMaxNumericUpDown.Location = new System.Drawing.Point(312, 49);
            yMaxNumericUpDown.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            yMaxNumericUpDown.Name = "yMaxNumericUpDown";
            yMaxNumericUpDown.Size = new System.Drawing.Size(71, 23);
            yMaxNumericUpDown.TabIndex = 18;
            yMaxNumericUpDown.Value = new decimal(new int[] { 10, 0, 0, 0 });
            yMaxNumericUpDown.Visible = false;
            yMaxNumericUpDown.ValueChanged += yMaxNumericUpDown_ValueChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(yMaxNumericUpDown);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(yMinNumericUpDown);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pointsNumericUpDown);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(xMaxNumericUpDown);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(xMinNumericUpDown);
            panel1.Controls.Add(checkBox);
            panel1.Controls.Add(label5);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 398);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(690, 174);
            panel1.TabIndex = 19;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(12, 126);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(110, 36);
            button1.TabIndex = 20;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(690, 572);
            Controls.Add(panel1);
            Controls.Add(renderControl1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "621пст ЛампартВМ 3";
            ((System.ComponentModel.ISupportInitialize)xMinNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)xMaxNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)pointsNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)yMinNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)yMaxNumericUpDown).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RenderControl renderControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown xMinNumericUpDown;
        private System.Windows.Forms.NumericUpDown xMaxNumericUpDown;
        private System.Windows.Forms.NumericUpDown pointsNumericUpDown;
        private System.Windows.Forms.NumericUpDown yMinNumericUpDown;
        private System.Windows.Forms.NumericUpDown yMaxNumericUpDown;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}

