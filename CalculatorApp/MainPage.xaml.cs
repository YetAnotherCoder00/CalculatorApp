using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

namespace CalculatorApp;

public partial class MainPage : ContentPage
{
    string output_string = "";
    bool decimalpressed = false;
    string operation = "";
    double num01 = 0;
    double num02 = 0;


    public MainPage()
    {
        InitializeComponent();
    }

    private void One(object sender, EventArgs e)
    {
        output_string += "1";
        output.Text = output_string;
    }
    private void Two(object sender, EventArgs e)
    {
        output_string += "2";
        output.Text = output_string;
    }
    private void Three(object sender, EventArgs e)
    {
        output_string += "3";
        output.Text = output_string;
    }
    private void Four(object sender, EventArgs e)
    {
        output_string += "4";
        output.Text = output_string;
    }
    private void Five(object sender, EventArgs e)
    {
        output_string += "5";
        output.Text = output_string;
    }
    private void Six(object sender, EventArgs e)
    {
        output_string += "6";
        output.Text = output_string;
    }
    private void Seven(object sender, EventArgs e)
    {
        output_string += "7";
        output.Text = output_string;
    }
    private void Eight(object sender, EventArgs e)
    {
        output_string += "8";
        output.Text = output_string;
    }
    private void Nine(object sender, EventArgs e)
    {
        output_string += "9";
        output.Text = output_string;
    }
    private void Zero(object sender, EventArgs e)
    {
        output_string += "0";
        output.Text = output_string;
    }
    private void Decimal(object sender, EventArgs e)
    {
        if (decimalpressed == false)
        {
            if (output_string == "")
            {
                output_string += "0.";
            }
            else
            {
                output_string += ".";
                decimalpressed = true;
            }
        }
        output.Text = output_string;
    }


    private void Divide(object sender, EventArgs e)
    {
        if (num01 != 0)
        {
            if (output_string != "")
            {
                double num02 = Convert.ToDouble(output_string);

                switch (operation)
                {
                    case "+":
                        output.Text = $"{num01 + num02}";
                        output_string = Convert.ToString(num01 + num02);
                        num01 += num02;
                        break;
                    case "-":
                        output.Text = $"{num01 - num02}";
                        output_string = Convert.ToString(num01 - num02);
                        num01 -= num02;
                        break;
                    case "*":
                        output.Text = $"{num01 * num02}";
                        output_string = Convert.ToString(num01 * num02);
                        num01 *= num02;
                        break;
                    case "/":
                        output.Text = $"{num01 / num02}";
                        output_string = Convert.ToString(num01 / num02);
                        num01 /= num02;
                        break;
                    default:
                        break;
                }

                decimalpressed = false;
            }

        }
        else
        {
            num01 = Convert.ToDouble(output_string);
            output_string = "";
        }
        operation = "/";
        num02 = 0;
    }
    private void Multiply(object sender, EventArgs e)
    {
        if (num01 != 0)
        {
            if (output_string != "")
            {
                double num02 = Convert.ToDouble(output_string);

                switch (operation)
                {
                    case "+":
                        output.Text = $"{num01 + num02}";
                        output_string = Convert.ToString(num01 + num02);
                        num01 += num02;
                        break;
                    case "-":
                        output.Text = $"{num01 - num02}";
                        output_string = Convert.ToString(num01 - num02);
                        num01 -= num02;
                        break;
                    case "*":
                        output.Text = $"{num01 * num02}";
                        output_string = Convert.ToString(num01 * num02);
                        num01 *= num02;
                        break;
                    case "/":
                        output.Text = $"{num01 / num02}";
                        output_string = Convert.ToString(num01 / num02);
                        num01 /= num02;
                        break;
                    default:
                        break;
                }
                decimalpressed = false;
            }
            output_string = "";
        }
        else
        {
            num01 = Convert.ToDouble(output_string);
            output_string = "";
        }
        operation = "*";
        output_string = "";
        num02 = 0;
    }
    private void Subtract(object sender, EventArgs e)
    {
        if (num01 != 0)
        {
            if (output_string != "")
            {
                double num02 = Convert.ToDouble(output_string);

                switch (operation)
                {
                    case "+":
                        output.Text = $"{num01 + num02}";
                        output_string = Convert.ToString(num01 + num02);
                        num01 += num02;
                        break;
                    case "-":
                        output.Text = $"{num01 - num02}";
                        output_string = Convert.ToString(num01 - num02);
                        num01 -= num02;
                        break;
                    case "*":
                        output.Text = $"{num01 * num02}";
                        output_string = Convert.ToString(num01 * num02);
                        num01 *= num02;
                        break;
                    case "/":
                        output.Text = $"{num01 / num02}";
                        output_string = Convert.ToString(num01 / num02);
                        num01 /= num02;
                        break;
                    default:
                        break;
                }
                decimalpressed = false;
            }
            output_string = "";
            num02 = 0;

            operation = "";
        }
        else
        {
            num01 = Convert.ToDouble(output_string);
            output_string = "";
        }
        operation = "-";
        output_string = "";
        num02 = 0;
    }
    private void Addition(object sender, EventArgs e)
    {
        if (num01 != 0)
        {
            if (output_string != "")
            {
                double num02 = Convert.ToDouble(output_string);

                switch (operation)
                {
                    case "+":
                        output.Text = $"{num01 + num02}";
                        output_string = Convert.ToString(num01 + num02);
                        num01 += num02;
                        break;
                    case "-":
                        output.Text = $"{num01 - num02}";
                        output_string = Convert.ToString(num01 - num02);
                        num01 -= num02;
                        break;
                    case "*":
                        output.Text = $"{num01 * num02}";
                        output_string = Convert.ToString(num01 * num02);
                        num01 *= num02;
                        break;
                    case "/":
                        output.Text = $"{num01 / num02}";
                        output_string = Convert.ToString(num01 / num02);
                        num01 /= num02;
                        break;
                    default:
                        break;
                }
                decimalpressed = false;
            }
            output_string = "";
            num02 = 0;
        }
        else
        {
            num01 = Convert.ToDouble(output_string);
            output_string = "";
        }
        operation = "+";
        num02 = 0;
    }
    private void Equals(object sender, EventArgs e)
    {
        if (num01 != 0)
        {
            if (output_string != "")
            {
                double num02 = Convert.ToDouble(output_string);

                switch (operation)
                {
                    case "+":
                        output.Text = $"{num01 + num02}";
                        output_string = Convert.ToString(num01 + num02);
                        num01 += num02;
                        break;
                    case "-":
                        output.Text = $"{num01 - num02}";
                        output_string = Convert.ToString(num01 - num02);
                        num01 -= num02;
                        break;
                    case "*":
                        output.Text = $"{num01 * num02}";
                        output_string = Convert.ToString(num01 * num02);
                        num01 *= num02;
                        break;
                    case "/":
                        output.Text = $"{num01 / num02}";
                        output_string = Convert.ToString(num01 / num02);
                        num01 /= num02;
                        break;
                    default:
                        break;
                }
                decimalpressed = false;
            }
            output_string = "";
            num02 = 0;
        }

        else
        {
            num01 = Convert.ToDouble(output_string);
            output_string = "";
        }
        num02 = 0;
    }

    private void Clear(object sender, EventArgs e)
    {
        num01 = 0;
        num02 = 0;
        output_string = "";
        operation = "";
        decimalpressed = false;
        output.Text = "0";
    }


}

// TODO: fix calculation, they're getting calculated when they shoudln't