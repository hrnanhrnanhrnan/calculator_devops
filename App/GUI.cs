using App.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class GUI : Form
    {
        private readonly ICalculator _calculator;
        private string operation = string.Empty;
        private double _value = 0;
        private bool _operatorPressed = false;
        private bool _firstNumber = true;
        public GUI(ICalculator calculator)
        {
            InitializeComponent();
            _calculator = calculator;
            CalculatorExtension.ErrorEvent += CalculatorExtension_ErrorEvent;
        }

        // the error event, calls the enable buttons method and sets it to false to disable all buttons
        // also sets the textbox text to the error message
        private void CalculatorExtension_ErrorEvent(object sender, string error)
        {
            resultBox.Text = error;
            EnableButtons(false);
        }

        // Numbers buttons click event
        private void numButton_Click(object sender, EventArgs e)
        {
            // if statement that removes the 0 from the textbox
            if (resultBox.Text == "0" || _operatorPressed)
            {
                resultBox.Clear();
                _operatorPressed = false;
            }

            // appends the clicked button text to the resultbox text
            Button b = (Button)sender;
            resultBox.Text += b.Text;
        }

        // operator click event
        // when +, -, /, * is clicked the operation string is set to the clicked operation
        // the value is updated with the choosen operation
        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            _operatorPressed = true;
            if (_firstNumber)
            {
                try
                {
                    _value = double.Parse(resultBox.Text);
                    _firstNumber = false;
                }
                catch (Exception ex)
                {
                    CalculatorExtension_ErrorEvent(this, ex.Message);
                }
            }
            else
            {
                _value = _calculator.Operation(operation, _value, resultBox.Text);
            }

        }

        // Sum operator click event
        private void sum_click(object sender, EventArgs e)
        {
            _value = _calculator.Operation(operation, _value, resultBox.Text);

            // the error event sends and sets the value variable to NaN
            // so in case the error event has not been fired we set resultbox.text to value among other things
            if (!double.IsNaN(_value))
            {
                resultBox.Text = _value.ToString();
                operation = string.Empty;
                _operatorPressed = true;
                _firstNumber = true;
            }
        }

        // reset click event
        // resets the state of the calculator and enables buttons
        private void reset_click(object sender, EventArgs e)
        {
            ResetState();
            EnableButtons(true);
        }

        // resets the state of the calculator
        private void ResetState()
        {
            resultBox.Text = "0";
            _value = 0;
            operation = string.Empty;
            _operatorPressed = false;
            _firstNumber = true;
        }

        // loops through all buttons and sets the enabled prop of the button to true or false
        // except resetbutton which is always set to enabled
        private void EnableButtons(bool choice)
        {
            foreach (var button in Controls.OfType<Button>())
            {
                if (button.Name == "buttonRes")
                {
                    button.Enabled = true;
                    continue;
                }
                button.Enabled = choice;
            }
        }

    }
}
