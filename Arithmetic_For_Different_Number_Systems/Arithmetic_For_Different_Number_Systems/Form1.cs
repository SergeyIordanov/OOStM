using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arithmetic_For_Different_Number_Systems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelErrorFirst.Text = labelErrorSecond.Text = "";
            comboBoxNumberSystem.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOperation.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxNumberSystem.SelectedIndex = 2;
            comboBoxOperation.SelectedIndex = 0;
        }

        private bool validateFirstOperand()
        {

            var allowedChars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ".Substring(0,
                Convert.ToInt32(comboBoxNumberSystem.Text.Substring(5, (comboBoxNumberSystem.Text.Length - 6))));
            return Regex.IsMatch(textBoxFirstOperand.Text, string.Format("^[{0}||]+$", allowedChars),
                RegexOptions.Compiled | RegexOptions.IgnoreCase);
        }

        private bool validateSecondOperand()
        {

            var allowedChars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ".Substring(0,
                Convert.ToInt32(comboBoxNumberSystem.Text.Substring(5, (comboBoxNumberSystem.Text.Length - 6))));
            return Regex.IsMatch(textBoxSecondOperand.Text, string.Format("^[{0}||]+$", allowedChars),
                RegexOptions.Compiled | RegexOptions.IgnoreCase);
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
            if (validateFirstOperand() && validateSecondOperand())
            {
                labelErrorFirst.Text = "";
                labelErrorSecond.Text = "";

                textBoxResult.Text = Calculator.Calculate(textBoxFirstOperand.Text.Replace('.', ',').ToUpper(), textBoxSecondOperand.Text.Replace('.', ',').ToUpper(),
                    Convert.ToInt32(comboBoxNumberSystem.Text.Substring(5, (comboBoxNumberSystem.Text.Length - 6))), comboBoxOperation.SelectedItem.ToString()[0]);
            }
            else
            {
                if (!validateFirstOperand())
                    labelErrorFirst.Text = "Invalid input";
                if (!validateSecondOperand())
                    labelErrorSecond.Text = "Invalid input";
            }
        }

        private void textBoxFirstOperand_TextChanged(object sender, EventArgs e)
        {
            labelErrorFirst.Text = "";
            labelErrorSecond.Text = "";
            textBoxResult.Text = "";
        }

        private void comboBoxOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelErrorFirst.Text = "";
            labelErrorSecond.Text = "";
            textBoxResult.Text = "";
        }

        private void comboBoxNumberSystem_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelErrorFirst.Text = "";
            labelErrorSecond.Text = "";
            textBoxResult.Text = "";
        }
    }
}
