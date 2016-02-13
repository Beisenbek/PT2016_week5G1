using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public enum State
    {
        WaitingForFirstNumber,
        WaitingForSecondNumber,
        WaitingForResult,
        WaitingForOperation
    }

    public partial class Form1 : Form
    {
        double firstNumber = 0;
        double secondNumber = 0;
        double result = 0;
       // string state = "init";
        string operation = "";
        State state;

        public Form1()
        {
            InitializeComponent();
            state = State.WaitingForFirstNumber;
        }

        private void pad_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            switch (state)
            {
                case State.WaitingForFirstNumber:
                    state = State.WaitingForOperation;
                    break;
                case State.WaitingForSecondNumber:
                    state = State.WaitingForResult;
                    display.Text = "";
                    break;
            }

            display.Text += btn.Text;
        }

        private void opeation_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            firstNumber = double.Parse(display.Text);
            state = State.WaitingForSecondNumber;
            operation = btn.Text;
        }

        private void operationResult_Click(object sender, EventArgs e)
        {
            secondNumber = double.Parse(display.Text);

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
            }

            display.Text = result.ToString();
        }
    }
}


