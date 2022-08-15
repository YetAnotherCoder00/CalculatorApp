using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

namespace CalculatorApp;

public partial class MainPage : ContentPage
{
	string output_string = "";
	bool decimalpressed = false;
	string operation = "";
	double num01 = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void One(object sender, EventArgs e)
	{
		output_string = output_string + "1";
		output.Text = output_string;
	}
	private void Two(object sender, EventArgs e)
	{
		output_string = output_string + "2";
        output.Text = output_string;
    }
	private void Three(object sender, EventArgs e)
	{
		output_string = output_string + "3";

        output.Text = output_string;
    }
	private void Four(object sender, EventArgs e)
	{
		output_string = output_string + "4";
        output.Text = output_string;
    }
	private void Five(object sender, EventArgs e)
	{
		output_string = output_string + "5";
        output.Text = output_string;
    }
	private void Six(object sender, EventArgs e)
	{
		output_string = output_string + "6";
        output.Text = output_string;
    }
	private void Seven(object sender, EventArgs e)
	{
		output_string = output_string + "7";
        output.Text = output_string;
    }
	private void Eight(object sender, EventArgs e)
	{
		output_string = output_string + "8";
        output.Text = output_string;
    }
    private void Nine(object sender, EventArgs e)
    {
        output_string = output_string + "9";
        output.Text = output_string;
    }
    private void Zero(object sender, EventArgs e)
    {
        output_string = output_string + "0";
        output.Text = output_string;
    }
    private void Decimal(object sender, EventArgs e)
    {
		if (decimalpressed == false)
		{
			output_string = output_string + ".";
			decimalpressed = true;
		}
        output.Text = output_string;
    }


	private void Divide(object sender, EventArgs e)
	{
        if (num01 != 0)
        {
            double num02 = Convert.ToDouble(output_string);
            decimalpressed = false;
            switch (operation)
            {
                case "+":
                    output.Text = $"{num01 + num02}";
                    output_string = Convert.ToString(num01 + num02);
                    output_string = "";
                    num01 += num02;
                    break;
                case "-":
                    output.Text = $"{num01 - num02}";
                    output_string = Convert.ToString(num01 - num02);
                    output_string = "";
                    num01 += num02;
                    break;
                case "*":
                    output.Text = $"{num01 * num02}";
                    output_string = Convert.ToString(num01 * num02);
                    output_string = "";
                    num01 += num02;
                    break;
                case "/":
                    output.Text = $"{num01 / num02}";
                    output_string = Convert.ToString(num01 / num02);
                    output_string = "";
                    num01 += num02;
                    break;
                default:
                    break;
            }
        }
        else
        {
            num01 = Convert.ToDouble(output_string);
            output_string = "";
        }
        operation = "/";
	}
	private void Multiply(object sender, EventArgs e)
	{
        if (num01 != 0)
        {
            double num02 = Convert.ToDouble(output_string);
            decimalpressed = false;
            switch (operation)
            {
                case "+":
                    output.Text = $"{num01 + num02}";
                    output_string = Convert.ToString(num01 + num02);
                    output_string = "";
                    num01 += num02;
                    break;
                case "-":
                    output.Text = $"{num01 - num02}";
                    output_string = Convert.ToString(num01 - num02);
                    output_string = "";
                    num01 += num02;
                    break;
                case "*":
                    output.Text = $"{num01 * num02}";
                    output_string = Convert.ToString(num01 * num02);
                    output_string = "";
                    num01 += num02;
                    break;
                case "/":
                    output.Text = $"{num01 / num02}";
                    output_string = Convert.ToString(num01 / num02);
                    output_string = "";
                    num01 += num02;
                    break;
                default:
                    break;
            }
        }
        else
        {
            num01 = Convert.ToDouble(output_string);
            output_string = "";
        }
        operation = "*";
	}
	private void Subtract(object sender, EventArgs e)
	{
		if (num01 != 0)
		{
			double num02 = Convert.ToDouble(output_string);
            decimalpressed = false;
            switch (operation)
            {
                case "+":
                    output.Text = $"{num01 + num02}";
                    output_string = Convert.ToString(num01 + num02);
                    output_string = "";
                    num01 += num02;
                    break;
                case "-":
                    output.Text = $"{num01 - num02}";
                    output_string = Convert.ToString(num01 - num02);
                    output_string = "";
                    num01 += num02;
                    break;
                case "*":
                    output.Text = $"{num01 * num02}";
                    output_string = Convert.ToString(num01 * num02);
                    output_string = "";
                    num01 += num02;
                    break;
                case "/":
                    output.Text = $"{num01 / num02}";
                    output_string = Convert.ToString(num01 / num02);
                    output_string = "";
                    num01 += num02;
                    break;
                default:
                    break;
            }
        }
		else
		{
			num01 = Convert.ToDouble(output_string);
			output_string = "";
		}
        operation = "-";
	}
	private void Addition(object sender, EventArgs e)
	{
        if (num01 != 0)
        {
            double num02 = Convert.ToDouble(output_string);
            decimalpressed = false;
            switch (operation)
            {
                case "+":
                    output.Text = $"{num01 + num02}";
                    output_string = Convert.ToString(num01 + num02);
                    output_string = "";
                    num01 += num02;
                    break;
                case "-":
                    output.Text = $"{num01 - num02}";
                    output_string = Convert.ToString(num01 - num02);
                    output_string = "";
                    num01 += num02;
                    break;
                case "*":
                    output.Text = $"{num01 * num02}";
                    output_string = Convert.ToString(num01 * num02);
                    output_string = "";
                    num01 += num02;
                    break;
                case "/":
                    output.Text = $"{num01 / num02}";
                    output_string = Convert.ToString(num01 / num02);
                    output_string = "";
                    num01 += num02;
                    break;
                default:
                    break;
            }

        }
        else
        {
            num01 = Convert.ToDouble(output_string);
            output_string = "";
        }
        operation = "+";
	}
	private void Equals(object sender, EventArgs e)
	{
		double num02 = Convert.ToDouble(output_string);
        decimalpressed = false;
        switch (operation)
        {
            case "+":
                output.Text = $"{num01 + num02}";
                output_string = Convert.ToString(num01 + num02);
                output_string = "";
                num01 += num02;
                break;
            case "-":
                output.Text = $"{num01 - num02}";
                output_string = Convert.ToString(num01 - num02);
                output_string = "";
                num01 += num02;
                break;
            case "*":
                output.Text = $"{num01 * num02}";
                output_string = Convert.ToString(num01 * num02);
                output_string = "";
                num01 += num02;
                break;
            case "/":
                output.Text = $"{num01 / num02}";
                output_string = Convert.ToString(num01 / num02);
                output_string = "";
                num01 += num02;
                break;
            default:
                break;
        }
    }

	private void Clear(object sender, EventArgs e)
	{
        num01 = 0;
        output_string = "";
		operation = "";
		decimalpressed = false;
		output.Text = "0";
	}
	

}

