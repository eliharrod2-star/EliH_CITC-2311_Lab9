
using System;
using System.Globalization;
using System.Windows.Forms;
using WinFormsApp1.Logic;

namespace WinFormsApp1
{
    public partial class Calculator : Form
    {
        private readonly MemoryCalculator calc =
            new MemoryCalculator();

        private double firstOperand;
        private double lastOperand;
        private string pendingOperation = "";
        private string lastOperation = "";
        private bool startNewNumber = true;
        private bool hasLastOperation = false;

        public Calculator()
        {
            InitializeComponent();

            // Number buttons
            btn_Zero.Click += NumberButton_Click;
            btn_One.Click += NumberButton_Click;
            btn_Two.Click += NumberButton_Click;
            btn_Three.Click += NumberButton_Click;
            btn_Four.Click += NumberButton_Click;
            btn_Five.Click += NumberButton_Click;
            btn_Six.Click += NumberButton_Click;
            btn_Seven.Click += NumberButton_Click;
            btn_Eight.Click += NumberButton_Click;
            btn_Nine.Click += NumberButton_Click;

            // Other buttons
            btn_Decimal.Click += btn_Decimal_Click;
            btn_Add.Click += OperatorButton_Click;
            btn_Subtract.Click += OperatorButton_Click;
            btn_Multiply.Click += OperatorButton_Click;
            btn_Divide.Click += OperatorButton_Click;
            btn_Equal.Click += btn_Equal_Click;
            btn_ChangeSign.Click += btn_ChangeSign_Click;
            btn_Reciprical.Click += btn_Reciprical_Click;
            btn_SqaureRoot.Click += btn_SqaureRoot_Click;
            btn_Back.Click += btn_Back_Click;
            btn_Clear.Click += btn_Clear_Click;

            // Memory buttons
            btn_MemClear.Click += btn_MemClear_Click;
            btn_MemRecall.Click += btn_MemRecall_Click;
            btn_MemSave.Click += btn_MemSave_Click;
            btn_MemAdd.Click += btn_MemAdd_Click;

            txt_Mem.Text = "";
        }

        // Display numbers when clicked
        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (startNewNumber || txt_Answer.Text == "Error")
            {
                txt_Answer.Text = button.Text;
                startNewNumber = false;
            }
            else
            {
                txt_Answer.Text += button.Text;
            }
        }

        // Add a decimal point
        private void btn_Decimal_Click(object sender, EventArgs e)
        {
            if (startNewNumber || txt_Answer.Text == "Error")
            {
                txt_Answer.Text = "0.";
                startNewNumber = false;
            }
            else if (!txt_Answer.Text.Contains("."))
            {
                txt_Answer.Text += ".";
            }
        }

        // Select an arithmetic operation
        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            try
            {
                double currentValue = GetCurrentValue();

                if (pendingOperation != "" && !startNewNumber)
                {
                    currentValue = calc.Calculate(
                        firstOperand, currentValue, pendingOperation);

                    txt_Answer.Text = FormatResult(currentValue);
                }

                firstOperand = currentValue;
                pendingOperation = button.Text;
                startNewNumber = true;
                hasLastOperation = false;
            }
            catch (DivideByZeroException)
            {
                ShowError("Cannot divide by zero.");
            }
            catch (ArithmeticException)
            {
                ShowError("Invalid calculation.");
            }
        }

        // Calculate the result
        private void btn_Equal_Click(object sender, EventArgs e)
        {
            try
            {
                if (pendingOperation != "")
                {
                    double secondOperand = GetCurrentValue();

                    double result = calc.Calculate(
                        firstOperand, secondOperand, pendingOperation);

                    lastOperation = pendingOperation;
                    lastOperand = secondOperand;
                    hasLastOperation = true;

                    pendingOperation = "";
                    txt_Answer.Text = FormatResult(result);
                    startNewNumber = true;
                }
                else if (hasLastOperation)
                {
                    double currentValue = GetCurrentValue();

                    double result = calc.Calculate(
                        currentValue, lastOperand, lastOperation);

                    txt_Answer.Text = FormatResult(result);
                    startNewNumber = true;
                }
            }
            catch (DivideByZeroException)
            {
                ShowError("Cannot divide by zero.");
            }
            catch (ArithmeticException)
            {
                ShowError("Invalid calculation.");
            }
        }

        // Change the sign of a number
        private void btn_ChangeSign_Click(object sender, EventArgs e)
        {
            try
            {
                double value = calc.ChangeSign(GetCurrentValue());
                txt_Answer.Text = FormatResult(value);
                startNewNumber = true;
            }
            catch (FormatException)
            {
                ShowError("Enter a number first.");
            }
        }

        // Calculate the reciprocal
        private void btn_Reciprical_Click(object sender, EventArgs e)
        {
            try
            {
                double value = calc.Reciprocal(GetCurrentValue());
                txt_Answer.Text = FormatResult(value);
                startNewNumber = true;
            }
            catch (DivideByZeroException)
            {
                ShowError("Cannot divide by zero.");
            }
        }

        // Calculate the square root
        private void btn_SqaureRoot_Click(object sender, EventArgs e)
        {
            try
            {
                double value = calc.SquareRoot(GetCurrentValue());
                txt_Answer.Text = FormatResult(value);
                startNewNumber = true;
            }
            catch (ArithmeticException)
            {
                ShowError("Invalid square root.");
            }
        }

        // Erase the last digit
        private void btn_Back_Click(object sender, EventArgs e)
        {
            if (txt_Answer.Text == "Error")
            {
                txt_Answer.Clear();
                startNewNumber = true;
                return;
            }

            if (txt_Answer.Text.Length > 0)
            {
                txt_Answer.Text = txt_Answer.Text.Substring(
                    0, txt_Answer.Text.Length - 1);
            }

            if (txt_Answer.Text == "" || txt_Answer.Text == "-")
            {
                txt_Answer.Text = "0";
                startNewNumber = true;
            }
            else
            {
                startNewNumber = false;
            }
        }

        // Clear the calculator display and current operation
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Answer.Clear();

            firstOperand = 0;
            lastOperand = 0;
            pendingOperation = "";
            lastOperation = "";
            hasLastOperation = false;
            startNewNumber = true;
        }

        // Clear memory
        private void btn_MemClear_Click(object sender, EventArgs e)
        {
            calc.MemoryClear();
            UpdateMemoryIndicator();
        }

        // Recall memory
        private void btn_MemRecall_Click(object sender, EventArgs e)
        {
            if (calc.HasMemory)
            {
                txt_Answer.Text = FormatResult(calc.MemoryRecall());
                startNewNumber = true;
            }
        }

        // Save the displayed number to memory
        private void btn_MemSave_Click(object sender, EventArgs e)
        {
            double value = GetCurrentValue();

            calc.MemorySave(value);
            UpdateMemoryIndicator();
        }

        // Add the displayed number to memory
        private void btn_MemAdd_Click(object sender, EventArgs e)
        {
            double value = GetCurrentValue();

            calc.MemoryAdd(value);
            UpdateMemoryIndicator();
        }

        // Update the M indicator
        private void UpdateMemoryIndicator()
        {
            if (calc.HasMemory)
            {
                txt_Mem.Text = "M";
            }
            else
            {
                txt_Mem.Text = "";
            }
        }

        // Get the number currently displayed
        private double GetCurrentValue()
        {
            if (double.TryParse(
                txt_Answer.Text,
                NumberStyles.Float,
                CultureInfo.CurrentCulture,
                out double value))
            {
                return value;
            }

            return 0;
        }

        // Format the result for display
        private string FormatResult(double value)
        {
            return value.ToString("G", CultureInfo.CurrentCulture);
        }

        // Display an error and reset the operation
        private void ShowError(string message)
        {
            txt_Answer.Text = message;
            pendingOperation = "";
            hasLastOperation = false;
            startNewNumber = true;
        }

        // Required by the existing Designer file
        private void txt_Answer_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

