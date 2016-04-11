using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Counting_systems_transmission
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBoxFrom.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFrom.SelectedIndex = 2;
            comboBoxTo.SelectedIndex = 0;

            labelError.Text = "";
        }

        private void comboBoxFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkMethods();
            startTranslation();
        }

        private void comboBoxTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkMethods();
            startTranslation();
        }

        private void textBoxEnter_TextChanged(object sender, EventArgs e)
        {
            startTranslation();
        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            startTranslation();
        }

        private void startTranslation()
        {
            if (!checkInput())
            {
                labelError.Text = "Invalid input";
                textBoxResult.Text = "";
            }
            else
            {
                labelError.Text = "";
                checkMethods();
                int from = Convert.ToInt32(comboBoxFrom.Text.Substring(5, (comboBoxFrom.Text.Length - 6)));
                int to = Convert.ToInt32(comboBoxTo.Text.Substring(5, (comboBoxTo.Text.Length - 6)));
                string method = "";
                if (radioButtonBitwise.Checked)
                    method = "bit";
                else if (radioButtonTable.Checked)
                    method = "tab";
                else if (radioButtonSubtraction.Checked)
                    method = "sub";
                else if (radioButtonMultiplication.Checked)
                    method = "mul";
                else if (radioButtonDivision.Checked)
                    method = "div";
                else if (radioButtonCombination.Checked)
                    method = "com";
                textBoxResult.Text = Translator.Translate(textBoxEnter.Text.Replace('.', ',').ToUpper(), from, to, method).ToString();
            }
        }

        private bool checkInput()
        {

            var allowedChars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ".Substring(0, 
                Convert.ToInt32(comboBoxFrom.Text.Substring(5, (comboBoxFrom.Text.Length - 6))));
            return Regex.IsMatch(textBoxEnter.Text, string.Format("^[{0}||]+((['.'|',']?[{0}||]+)|[{0}||]*)$", allowedChars), 
                RegexOptions.Compiled | RegexOptions.IgnoreCase);
        }

        private void checkMethods()
        {
            radioButtonBitwise.Enabled = true;
            radioButtonTable.Enabled = true;
            radioButtonDivision.Enabled = true;
            radioButtonSubtraction.Enabled = true;
            radioButtonMultiplication.Enabled = true;
            radioButtonCombination.Enabled = true;

            //choosed bin system
            if (comboBoxFrom.SelectedIndex == 0)
            {
                if (comboBoxTo.SelectedIndex != 0)
                {
                    radioButtonDivision.Enabled = false;
                    radioButtonSubtraction.Enabled = false;
                    radioButtonMultiplication.Enabled = false;
                    if (radioButtonDivision.Checked || radioButtonSubtraction.Checked || radioButtonMultiplication.Checked)
                        radioButtonBitwise.Checked = true;

                    if (comboBoxTo.SelectedIndex == 1 || comboBoxTo.SelectedIndex == 3)
                    {
                        radioButtonBitwise.Enabled = false;
                        if (radioButtonBitwise.Checked)
                            radioButtonTable.Checked = true;
                        if (isFraction(textBoxEnter.Text))
                        {
                            radioButtonTable.Enabled = false;
                            radioButtonCombination.Enabled = false;
                            radioButtonCombination.Checked = false;
                            radioButtonTable.Checked = false;
                        }

                    }

                    if (comboBoxTo.SelectedIndex == 2)
                    {
                        radioButtonCombination.Enabled = false;
                        radioButtonTable.Enabled = false;
                        if (radioButtonTable.Checked || radioButtonCombination.Checked)
                            radioButtonBitwise.Checked = true;
                    }
                }
            }

            //choosed oct system
            if (comboBoxFrom.SelectedIndex == 1)
            {
                if (comboBoxTo.SelectedIndex != 1)
                {
                    radioButtonDivision.Enabled = false;
                    radioButtonSubtraction.Enabled = false;
                    radioButtonMultiplication.Enabled = false;
                    if (radioButtonDivision.Checked || radioButtonSubtraction.Checked || radioButtonMultiplication.Checked)
                        radioButtonBitwise.Checked = true;
                    if (comboBoxTo.SelectedIndex == 0)
                    {
                        radioButtonBitwise.Enabled = false;
                        if (radioButtonBitwise.Checked)
                            radioButtonTable.Checked = true;
                        if (isFraction(textBoxEnter.Text))
                        {
                            radioButtonTable.Enabled = false;
                            if (radioButtonTable.Checked)
                                radioButtonCombination.Checked = true;
                        }
                    }
                    if (comboBoxTo.SelectedIndex == 2)
                    {
                        radioButtonCombination.Enabled = false;
                        radioButtonTable.Enabled = false;
                        radioButtonBitwise.Checked = true;
                    }
                    if (comboBoxTo.SelectedIndex == 3)
                    {
                        radioButtonTable.Enabled = false;
                        radioButtonBitwise.Enabled = false;
                        if (radioButtonTable.Checked || radioButtonBitwise.Checked)
                            radioButtonCombination.Checked = true;
                        if (isFraction(textBoxEnter.Text))
                        {                           
                            radioButtonCombination.Enabled = false;
                            radioButtonCombination.Checked = false;                       
                        }
                    }
                }
            }

            //choosed dec system
            if (comboBoxFrom.SelectedIndex == 2)
            {
                if (comboBoxTo.SelectedIndex != 2)
                {
                    radioButtonBitwise.Enabled = false;
                    radioButtonTable.Enabled = false;
                    if (radioButtonBitwise.Checked || radioButtonTable.Checked)
                        radioButtonDivision.Checked = true;
                    if (comboBoxTo.SelectedIndex == 1 || comboBoxTo.SelectedIndex == 3)
                    {
                        radioButtonSubtraction.Enabled = false;
                        radioButtonCombination.Enabled = false;
                        if (radioButtonSubtraction.Checked || radioButtonCombination.Checked)
                            radioButtonDivision.Checked = true;
                        if (isFraction(textBoxEnter.Text))
                        {
                            radioButtonDivision.Enabled = false;                           
                            radioButtonDivision.Checked = false;
                        }
                        if (!isFraction(textBoxEnter.Text) || Convert.ToDouble(textBoxEnter.Text.Replace('.', ',')) > 1)
                        {
                            radioButtonMultiplication.Enabled = false;
                            if (radioButtonMultiplication.Checked)
                                radioButtonSubtraction.Checked = true;
                        }
                    }
                    if (comboBoxTo.SelectedIndex == 0)
                    {
                        radioButtonCombination.Enabled = false;
                        if (radioButtonCombination.Checked)
                            radioButtonSubtraction.Checked = true;
                        if (isFraction(textBoxEnter.Text))
                        {
                            radioButtonDivision.Enabled = false;
                            if (radioButtonDivision.Checked)
                                radioButtonSubtraction.Checked = true;
                        }
                        if (!isFraction(textBoxEnter.Text) || Convert.ToDouble(textBoxEnter.Text.Replace('.', ',')) > 1)
                        {
                            radioButtonMultiplication.Enabled = false;
                            if (radioButtonMultiplication.Checked)
                                radioButtonSubtraction.Checked = true;
                        }
                    }
                }
            }

            //choosed hex system
            if (comboBoxFrom.SelectedIndex == 3)
            {
                if (comboBoxTo.SelectedIndex != 3)
                {
                    radioButtonDivision.Enabled = false;
                    radioButtonSubtraction.Enabled = false;
                    radioButtonMultiplication.Enabled = false;
                    if (radioButtonDivision.Checked || radioButtonSubtraction.Checked || radioButtonMultiplication.Checked)
                        radioButtonBitwise.Checked = true;
                    if (comboBoxTo.SelectedIndex == 0)
                    {
                        radioButtonBitwise.Enabled = false;
                        if (radioButtonBitwise.Checked)
                            radioButtonTable.Checked = true;
                        if (isFraction(textBoxEnter.Text))
                        {
                            radioButtonTable.Enabled = false;
                            if (radioButtonTable.Checked)
                                radioButtonCombination.Checked = true;
                        }
                    }
                    if (comboBoxTo.SelectedIndex == 2)
                    {
                        radioButtonCombination.Enabled = false;
                        radioButtonTable.Enabled = false;
                        radioButtonBitwise.Checked = true;
                    }
                    if (comboBoxTo.SelectedIndex == 1)
                    {
                        radioButtonTable.Enabled = false;
                        radioButtonBitwise.Enabled = false;
                        if (radioButtonTable.Checked || radioButtonBitwise.Checked)
                            radioButtonCombination.Checked = true;
                        if (isFraction(textBoxEnter.Text))
                        {
                            radioButtonCombination.Enabled = false;
                            radioButtonCombination.Checked = false;
                        }
                    }
                }
            }
        }

        private bool isFraction(string num)
        {
            if (num.Contains(".") || num.Contains(","))
                return true;
            return false;
        }
    }
}
