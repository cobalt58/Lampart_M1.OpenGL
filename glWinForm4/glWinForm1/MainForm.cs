using System;
using System.Windows.Forms;

namespace glWinForm1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            hNumericUpDown.ValueChanged += Nud_ValueChanged;
            kNumericUpDown.ValueChanged += Nud_ValueChanged;
            rNumericUpDown.ValueChanged += Nud_ValueChanged;
            aNumericUpDown.ValueChanged += Nud_ValueChanged;
            bNumericUpDown.ValueChanged += Nud_ValueChanged;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                // Коло
                ShowCircleControls(true);
                ShowHyperbolaControls(false);

                // Створюємо екземпляр кола
                var h = (double)hNumericUpDown.Value;
                var k = (double)kNumericUpDown.Value;
                var r = (double)rNumericUpDown.Value;
                renderControl1.CurrentShape = new Circle(h, k, r);

                renderControl1.Invalidate();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                // Горизонтальна гіпербола
                ShowCircleControls(false);
                ShowHyperbolaControls(true);

                var a = (double)aNumericUpDown.Value;
                var b = (double)bNumericUpDown.Value;
                // h, k у цьому прикладі не використовуються явно, 
                // або ж можна додати NumericUpDown для h і k,
                // якщо хочете зсунути центр гіперболи.
                // Тут, щоб показати, як використати h, k, можна зробити так:
                var h = (double)hNumericUpDown.Value;
                var k = (double)kNumericUpDown.Value;

                renderControl1.CurrentShape = new HorizontalHyperbola(h, k, a, b);
                renderControl1.Invalidate();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                // Вертикальна гіпербола
                ShowCircleControls(false);
                ShowHyperbolaControls(true);

                var a = (double)aNumericUpDown.Value;
                var b = (double)bNumericUpDown.Value;
                var h = (double)hNumericUpDown.Value;
                var k = (double)kNumericUpDown.Value;

                renderControl1.CurrentShape = new VerticalHyperbola(h, k, a, b);
                renderControl1.Invalidate();
            }
        }

        private void Nud_ValueChanged(object sender, EventArgs e)
        {
            // Перевіряємо, яка фігура вибрана зараз (через radioButton)
            if (radioButton1.Checked)
            {
                // Якщо коло
                renderControl1.CurrentShape = new Circle(
                    (double)hNumericUpDown.Value,
                    (double)kNumericUpDown.Value,
                    (double)rNumericUpDown.Value
                );
            }
            else if (radioButton2.Checked)
            {
                // Горизонтальна гіпербола
                renderControl1.CurrentShape = new HorizontalHyperbola(
                    (double)hNumericUpDown.Value,
                    (double)kNumericUpDown.Value,
                    (double)aNumericUpDown.Value,
                    (double)bNumericUpDown.Value
                );
            }
            else if (radioButton3.Checked)
            {
                // Вертикальна гіпербола
                renderControl1.CurrentShape = new VerticalHyperbola(
                    (double)hNumericUpDown.Value,
                    (double)kNumericUpDown.Value,
                    (double)aNumericUpDown.Value,
                    (double)bNumericUpDown.Value
                );
            }

            renderControl1.Invalidate();
        }

        private void ShowCircleControls(bool show)
        {
            hLabel.Visible = show;
            kLabel.Visible = show;
            rLabel.Visible = show;
            hNumericUpDown.Visible = show;
            kNumericUpDown.Visible = show;
            rNumericUpDown.Visible = show;
        }

        private void ShowHyperbolaControls(bool show)
        {
            aLabel.Visible = show;
            bLabel.Visible = show;
            aNumericUpDown.Visible = show;
            bNumericUpDown.Visible = show;
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            ShowCircleControls(false);
            ShowHyperbolaControls(false);
        }
    }
}
