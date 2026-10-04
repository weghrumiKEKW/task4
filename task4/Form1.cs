using System;
using System.Runtime.InteropServices;

namespace task4
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private double currentResult = 0;
        private bool IsNewEntry = true;
        private string pendingOperation = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Parent = lstHistory;
            label1.Visible = (lstHistory.Items.Count == 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        private void BtnNumber_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string input = clickedButton.Text;

            if (IsNewEntry)
            {
                txtDisplay.Text = (input == ",") ? "0," : input;
                IsNewEntry = false;
            }
            else
            {
                if (input == "," && txtDisplay.Text.Contains(",")) return;
                txtDisplay.Text += input;
            }
        }

        private void BtnOperator_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (!double.TryParse(txtDisplay.Text, out double val)) return;

            string op = clickedButton.Text;

            if (op == "%")
            {
                if (currentResult != 0)
                {
                    val = (currentResult * val) / 100;
                }
                else
                {
                    val = val / 100;
                }
                txtDisplay.Text = val.ToString();
                IsNewEntry = false;
                return;
            }

            if (!string.IsNullOrEmpty(pendingOperation) && !IsNewEntry)
            {
                CalculateResult(val);
            }
            else
            {
                currentResult = val;
            }

            pendingOperation = op;
            txtHistory.Text = $"{currentResult} {pendingOperation}";
            IsNewEntry = true;
        }

        private void btnInstantOperator_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string op = clickedButton.Text;

            if (!double.TryParse(txtDisplay.Text, out double val)) return;

            double result = 0;
            string expression = "";

            switch (op)
            {
                case"%":
                    if (!string.IsNullOrEmpty(pendingOperation) && currentResult != 0)
                    {
                        result = (currentResult * val) / 100;
                    }
                    else
                    {
                        result = val / 100;
                    }
                    expression = $"{result}";
                    txtDisplay.Text = result.ToString();
                    IsNewEntry = false;
                    return;

                case "x²":
                    result = Math.Pow(val, 2);
                    expression = $"sqr({val})";
                    break;

                case "1/x":
                    if (val != 0)
                    {
                        result = 1 / val;
                        expression = $"1/({val})";
                    }
                    else
                    {
                        MessageBox.Show("Cannot divide by zero", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    break;

                case "sqrt":
                    if (val >= 0)
                    {
                        result = Math.Sqrt(val);
                        expression = $"√({val})";
                    }
                    else
                    {
                        MessageBox.Show("Invalid input", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    break;
                case "+/-":
                    result = val * -1;
                    expression = $"negate({val})";
                    break;
            }

            txtDisplay.Text = result.ToString();
            txtHistory.Text = $"{expression} =";
            AddToHistory(expression, result);
            IsNewEntry = true;
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pendingOperation)) return;

            if (!double.TryParse(txtDisplay.Text, out double val)) return;

            string expression = $"{currentResult} {pendingOperation} {val}";

            CalculateResult(val);

            txtHistory.Text = $"{expression} =";
            txtDisplay.Text = currentResult.ToString();

            AddToHistory(expression, currentResult);

            pendingOperation = "";
            IsNewEntry = true;
        }

        private void CalculateResult(double nextValue)
        {
            switch (pendingOperation)
            {
                case "+": currentResult += nextValue; break;
                case "-": currentResult -= nextValue; break;
                case "x": currentResult *= nextValue; break;
                case "/":
                    if (nextValue != 0)
                    {
                        currentResult /= nextValue;
                    }
                    else
                    {
                        MessageBox.Show("Cannot divide by 0", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            txtHistory.Text = "";
            pendingOperation = "";
            currentResult = 0;
            IsNewEntry = true;
        }

        private void BtnClearEntry_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            IsNewEntry = true;
        }

        private void BtnBackSpace_Click(object sender, EventArgs e)
        {
            if (IsNewEntry) return;

            if (txtDisplay.Text.Length > 1)
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            }
            else
            {
                txtDisplay.Text = "0";
                IsNewEntry = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lstHistory.Visible = !lstHistory.Visible;
            if (lstHistory.Visible)
            {
                lstHistory.BringToFront();
            }
        }

        private void AddToHistory(string expression, double result)
        {
            lstHistory.Items.Add($"{expression} = {result}");
            label1.Visible = false;

        }
    }
}