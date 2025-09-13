using System.Data.OleDb;
using System.Diagnostics.Eventing.Reader;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;

namespace A01_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int originalWidth;
        bool isNewEntry = false;
        double firstNumber = 0;
        string operation = "";
        string dbPath = @"C:\LOCALDB\Calculator.accdb";
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 253;
            originalWidth = this.Width;
            DisplayDBToTB();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Width >= 370)
            {
                this.Width = originalWidth;
            }
            else
            {
                this.Width = 370;
            }
        }
        private void Load_Key(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (isNewEntry)
            {
                textDisplay.Text = "";
                isNewEntry = false;
            }
            if (textDisplay.Text == "0" && btn.Text != ".")
            {
                textDisplay.Text = "";
            }
            int dotCount = textDisplay.Text.Count(c => c == '.');
            if (dotCount >= 1)
            {
                if (btn.Text != ".")
                {
                    textDisplay.Text += btn.Text;
                }
            }
            else if (textDisplay.Text == "" && btn.Text == ".")
            {
                textDisplay.Text = "0.";
                textEquation.Text = "0.";
            }
            else
            {
                textDisplay.Text += btn.Text;
                if (textDisplay.Text.Contains(".."))
                {
                    textDisplay.Text = textDisplay.Text.Replace("..", ".");
                }
                textEquation.Text += btn.Text;
            }
        }
        private void Operator(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (double.TryParse(textDisplay.Text, out firstNumber))
            {
                operation = btn.Text;
                isNewEntry = true;

                textEquation.Text = firstNumber.ToString() + " " + operation + " ";
            }
        }
        private void Total()
        {
            double secondNumber;
            double result = 0;

            if (!double.TryParse(textDisplay.Text, out secondNumber))
                return;

            if (operation == "+")
            {
                result = firstNumber + secondNumber;
            }
            else if (operation == "-")
            {
                result = firstNumber - secondNumber;
            }
            else if (operation == "*")
            {
                result = firstNumber * secondNumber;
            }
            else if (operation == "/")
            {
                if (secondNumber == 0)
                {
                    MessageBox.Show("Cannot divide by zero", "try again");
                    return;
                }
                result = firstNumber / secondNumber;
            }
            textDisplay.Text = result.ToString();
            textEquation.Text += " = " + result.ToString();
            InsertEquationToDatabase(textEquation.Text);
            DisplayDBToTB();
            isNewEntry = true;
        }
        private void btnEquals_Click(object sender, EventArgs e)
        {
            Total();

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            textDisplay.Text = "0";
            isNewEntry = true;
        }
        private void btnErase_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text.Length > 0)
            {
                textDisplay.Text = textDisplay.Text.Substring(0, textDisplay.Text.Length - 1);
            }
                if (textDisplay.Text.Length > 0)
                {
                    textEquation.Text = textEquation.Text.Substring(0, textEquation.Text.Length - 1);
                }
            
        }
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            textDisplay.Text = "0";
            textEquation.Text = "";
            isNewEntry = true;
        }
        private void InsertEquationToDatabase(string equationText)
        {
            string conStr = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};";
            string InsertQuery = "INSERT INTO tbl_Calculator_History (Equation) Values (@equation)";
            using (OleDbConnection conn = new OleDbConnection(conStr))
            {
                try
                {
                    conn.Open();
                    OleDbCommand insertCmd = new OleDbCommand(InsertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@equation", equationText);
                    insertCmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Insert error: " + ex.Message);
                }
            }
        }
        private void DisplayDBToTB()
        {
            string dbPath = @"C:\LOCALDB\Calculator.accdb";
            string connStr = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};";
            string query = "SELECT Equation FROM tbl_Calculator_History order by ID desc";

            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                try
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    OleDbDataReader reader = cmd.ExecuteReader();
                    StringBuilder sb = new StringBuilder();
                    while (reader.Read())
                    {

                        string equation = reader["Equation"].ToString();
                        sb.AppendLine(equation);
                    }
                    textHistory.Multiline = true;
                    textHistory.ScrollBars = ScrollBars.Vertical;
                    textHistory.Text = sb.ToString();
                    reader.Close();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void textEquation_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

