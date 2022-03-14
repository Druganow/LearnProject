using System;
using System.IO;
using System.Windows.Forms;

namespace Lab4.GameLife
{
    public partial class FormMain : Form
    {
        int step = 0;
        const int n = 40;

        public FormMain()
        {
            InitializeComponent();
            InitField(n);
            stopButton.Enabled = false;
        }

        public void InitField(int n)
        {
            Cell.Cells = new Cell[n + 2, n + 2];
            int width = fieldPanel.Width / n - 1;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Cell cell = new Cell(i, j, width, fieldPanel);
                    cell.Click += new EventHandler(CellClick);
                }
            }
        }

        private void CellClick(object sender, EventArgs e)
        {
            Cell cell = (Cell)sender;
            if (cell.ItsAlive) cell.Die();
            else cell.Born();
        }

        private void stepButton_Click(object sender, EventArgs e)
        {
            bool[,] Survive = new bool[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Survive[i, j] = Cell.Cells[i + 1, j + 1].Survive();
                }
            }
                
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (Survive[i, j]) Cell.Cells[i + 1, j + 1].Born();
                    else Cell.Cells[i + 1, j + 1].Die();
                }
            step++;
            stepCountTB.Text = step + "";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            stopButton_Click(null, null);
            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= n; j++)
                    Cell.Cells[i, j].Die();
            step = 0;
            stepCountTB.Text = "0";
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000 / (int)numericUpDown1.Value;
            timer1.Start();
            startButton.Enabled = false;
            stopButton.Enabled = true;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            startButton.Enabled = true;
            stopButton.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            stepButton_Click(sender, e);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string text = "";
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    text += Cell.Cells[i, j].ItsAlive + " ";
                }
            }

            if (DialogResult.OK == saveFileDialog1.ShowDialog())
            {
                File.WriteAllText(saveFileDialog1.FileName, text);
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                clearButton_Click(null, null);
                string text = File.ReadAllText(openFileDialog1.FileName);
                string[] state = text.Split();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (state[j + n * i] == "True") Cell.Cells[i + 1, j + 1].Born();
                        else Cell.Cells[i + 1, j + 1].Die();
                    }
                }
            }
        }

    }
}
