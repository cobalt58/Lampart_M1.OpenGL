
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
            radioButton1 = new System.Windows.Forms.RadioButton();
            radioButton2 = new System.Windows.Forms.RadioButton();
            aNumericUpDown = new System.Windows.Forms.NumericUpDown();
            bNumericUpDown = new System.Windows.Forms.NumericUpDown();
            panel1 = new System.Windows.Forms.Panel();
            bLabel = new System.Windows.Forms.Label();
            aLabel = new System.Windows.Forms.Label();
            rLabel = new System.Windows.Forms.Label();
            kLabel = new System.Windows.Forms.Label();
            hLabel = new System.Windows.Forms.Label();
            rNumericUpDown = new System.Windows.Forms.NumericUpDown();
            kNumericUpDown = new System.Windows.Forms.NumericUpDown();
            hNumericUpDown = new System.Windows.Forms.NumericUpDown();
            radioButton3 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)aNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bNumericUpDown).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // renderControl1
            // 
            renderControl1.BackColor = System.Drawing.Color.SlateGray;
            renderControl1.CurrentShape = null;
            renderControl1.Dock = System.Windows.Forms.DockStyle.Top;
            renderControl1.DrawLine = false;
            renderControl1.ForeColor = System.Drawing.Color.White;
            renderControl1.Location = new System.Drawing.Point(0, 0);
            renderControl1.Name = "renderControl1";
            renderControl1.Size = new System.Drawing.Size(515, 392);
            renderControl1.TabIndex = 0;
            renderControl1.TextCodePage = 1251;
            renderControl1.XEnd = 0D;
            renderControl1.XStart = 0D;
            renderControl1.YEnd = 0D;
            renderControl1.YStart = 0D;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new System.Drawing.Point(261, 19);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(55, 19);
            radioButton1.TabIndex = 5;
            radioButton1.Text = "Circle";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new System.Drawing.Point(261, 44);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new System.Drawing.Size(136, 19);
            radioButton2.TabIndex = 6;
            radioButton2.Text = "Hyperbola horizontal";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // aNumericUpDown
            // 
            aNumericUpDown.Location = new System.Drawing.Point(165, 17);
            aNumericUpDown.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            aNumericUpDown.Name = "aNumericUpDown";
            aNumericUpDown.Size = new System.Drawing.Size(71, 23);
            aNumericUpDown.TabIndex = 14;
            aNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            aNumericUpDown.Visible = false;
            // 
            // bNumericUpDown
            // 
            bNumericUpDown.Location = new System.Drawing.Point(165, 77);
            bNumericUpDown.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            bNumericUpDown.Name = "bNumericUpDown";
            bNumericUpDown.Size = new System.Drawing.Size(71, 23);
            bNumericUpDown.TabIndex = 15;
            bNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            bNumericUpDown.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(bLabel);
            panel1.Controls.Add(aLabel);
            panel1.Controls.Add(rLabel);
            panel1.Controls.Add(kLabel);
            panel1.Controls.Add(hLabel);
            panel1.Controls.Add(rNumericUpDown);
            panel1.Controls.Add(kNumericUpDown);
            panel1.Controls.Add(hNumericUpDown);
            panel1.Controls.Add(radioButton3);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(bNumericUpDown);
            panel1.Controls.Add(aNumericUpDown);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 398);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(515, 174);
            panel1.TabIndex = 19;
            // 
            // bLabel
            // 
            bLabel.AutoSize = true;
            bLabel.Location = new System.Drawing.Point(142, 79);
            bLabel.Name = "bLabel";
            bLabel.Size = new System.Drawing.Size(14, 15);
            bLabel.TabIndex = 29;
            bLabel.Text = "b";
            bLabel.Visible = false;
            // 
            // aLabel
            // 
            aLabel.AutoSize = true;
            aLabel.Location = new System.Drawing.Point(143, 19);
            aLabel.Name = "aLabel";
            aLabel.Size = new System.Drawing.Size(13, 15);
            aLabel.TabIndex = 28;
            aLabel.Text = "a";
            aLabel.Visible = false;
            // 
            // rLabel
            // 
            rLabel.AutoSize = true;
            rLabel.Location = new System.Drawing.Point(145, 77);
            rLabel.Name = "rLabel";
            rLabel.Size = new System.Drawing.Size(11, 15);
            rLabel.TabIndex = 27;
            rLabel.Text = "r";
            rLabel.Visible = false;
            // 
            // kLabel
            // 
            kLabel.AutoSize = true;
            kLabel.Location = new System.Drawing.Point(145, 48);
            kLabel.Name = "kLabel";
            kLabel.Size = new System.Drawing.Size(13, 15);
            kLabel.TabIndex = 26;
            kLabel.Text = "k";
            kLabel.Visible = false;
            // 
            // hLabel
            // 
            hLabel.AutoSize = true;
            hLabel.Location = new System.Drawing.Point(145, 19);
            hLabel.Name = "hLabel";
            hLabel.Size = new System.Drawing.Size(14, 15);
            hLabel.TabIndex = 25;
            hLabel.Text = "h";
            hLabel.Visible = false;
            // 
            // rNumericUpDown
            // 
            rNumericUpDown.Location = new System.Drawing.Point(165, 77);
            rNumericUpDown.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            rNumericUpDown.Name = "rNumericUpDown";
            rNumericUpDown.Size = new System.Drawing.Size(71, 23);
            rNumericUpDown.TabIndex = 24;
            rNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            rNumericUpDown.Visible = false;
            // 
            // kNumericUpDown
            // 
            kNumericUpDown.Location = new System.Drawing.Point(165, 46);
            kNumericUpDown.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            kNumericUpDown.Name = "kNumericUpDown";
            kNumericUpDown.Size = new System.Drawing.Size(71, 23);
            kNumericUpDown.TabIndex = 23;
            kNumericUpDown.Visible = false;
            // 
            // hNumericUpDown
            // 
            hNumericUpDown.Location = new System.Drawing.Point(165, 17);
            hNumericUpDown.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            hNumericUpDown.Name = "hNumericUpDown";
            hNumericUpDown.Size = new System.Drawing.Size(71, 23);
            hNumericUpDown.TabIndex = 22;
            hNumericUpDown.Visible = false;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new System.Drawing.Point(261, 69);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new System.Drawing.Size(121, 19);
            radioButton3.TabIndex = 21;
            radioButton3.Text = "Hyperbola vertical";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(515, 572);
            Controls.Add(panel1);
            Controls.Add(renderControl1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "621пст ЛампартВМ 4";
            ((System.ComponentModel.ISupportInitialize)aNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)bNumericUpDown).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)rNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)kNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)hNumericUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RenderControl renderControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.NumericUpDown aNumericUpDown;
        private System.Windows.Forms.NumericUpDown bNumericUpDown;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label hLabel;
        private System.Windows.Forms.NumericUpDown rNumericUpDown;
        private System.Windows.Forms.NumericUpDown kNumericUpDown;
        private System.Windows.Forms.NumericUpDown hNumericUpDown;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.Label rLabel;
        private System.Windows.Forms.Label kLabel;
    }
}

