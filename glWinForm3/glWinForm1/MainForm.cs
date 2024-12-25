using System.Drawing;
using System.Windows.Forms;
using static glWinForm1.OpenGL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace glWinForm1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            renderControl1.XMin = (double)xMinNumericUpDown.Value;
            renderControl1.XMax = (double)xMaxNumericUpDown.Value;
            renderControl1.YMin = (double)yMinNumericUpDown.Value;
            renderControl1.YMax = (double)yMaxNumericUpDown.Value;
        }

        private void xMinNumericUpDown_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.XMin = (double)xMinNumericUpDown.Value;
            renderControl1.Invalidate();
        }

        private void xMaxNumericUpDown_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.XMax = (double)xMaxNumericUpDown.Value;
            renderControl1.Invalidate();
        }

        private void pointsNumericUpDown_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.points = (double)pointsNumericUpDown.Value;
            renderControl1.Invalidate();
        }
        private void checkBox_CheckedChanged(object sender, System.EventArgs e)
        {
            label3.Visible = checkBox.Checked;
            label4.Visible = checkBox.Checked;
            yMinNumericUpDown.Visible = checkBox.Checked;
            yMaxNumericUpDown.Visible = checkBox.Checked;
            renderControl1.YMin = -10.0;
            renderControl1.YMax = 10.0;
            renderControl1.showY = !renderControl1.showY;
            renderControl1.Invalidate();
        }

        private void yMinNumericUpDown_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.YMin = (double)yMinNumericUpDown.Value;
            renderControl1.Invalidate();
        }

        private void yMaxNumericUpDown_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.YMax = (double)yMaxNumericUpDown.Value;
            renderControl1.Invalidate();
        }

        private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
        {
            renderControl1.choice = 1;
            renderControl1.Invalidate();
        }

        private void radioButton2_CheckedChanged(object sender, System.EventArgs e)
        {
            renderControl1.choice = 2;
            renderControl1.Invalidate();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            xMinNumericUpDown.Value = -10;
            xMaxNumericUpDown.Value = 10;
            pointsNumericUpDown.Value = 100;
            checkBox.Checked = false;
            yMinNumericUpDown.Value = -10;
            yMaxNumericUpDown.Value = 10;
            renderControl1.showY = false;

            renderControl1.Invalidate();
        }
    }
}
