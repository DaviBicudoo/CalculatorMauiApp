namespace CalculatorMauiApp
{
    public partial class MainPage : ContentPage
    {
        bool firstNumber = true;
        double x, y;
        string operation;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            
        }

        private void Clean_Clicked(object sender, EventArgs e)
        {
            Display.Text = "";
        }

        private void MoreLess_Clicked(object sender, EventArgs e)
        {
            if(firstNumber)
            {
                x *= -1;
            }
            else
            {
                y *= -1;
            }
        }

        private void Percentage_Clicked(object sender, EventArgs e)
        {
            if (firstNumber)
            {
                x = Convert.ToDouble(Display.Text);
                firstNumber = false;
            }

            Display.Text = "";
            operation = "P";
        }

        private void Divide_Clicked(object sender, EventArgs e)
        {
            if (firstNumber)
            {
                x = Convert.ToDouble(Display.Text);
                firstNumber = false;
            }

            operation = "D";
            Display.Text = "";
        }

        private void Number7_Clicked(object sender, EventArgs e)
        {
            Display.Text += Number7.Text;
        }

        private void Number8_Clicked(object sender, EventArgs e)
        {
            Display.Text += Number8.Text;
        }

        private void Number9_Clicked(object sender, EventArgs e)
        {
            Display.Text += Number9.Text;
        }

        private void Multiply_Clicked(object sender, EventArgs e)
        {
            if (firstNumber)
            {
                x = Convert.ToDouble(Display.Text);
                firstNumber = false;
            }

            operation = "M";
            Display.Text = "";
        }

        private void Number4_Clicked(object sender, EventArgs e)
        {
            Display.Text += Number4.Text;
        }

        private void Number5_Clicked(object sender, EventArgs e)
        {
            Display.Text += Number5.Text;
        }

        private void Number6_Clicked(object sender, EventArgs e)
        {
            Display.Text += Number6.Text;
        }

        private void Subtract_Clicked(object sender, EventArgs e)
        {
            if (firstNumber)
            {
                x = Convert.ToDouble(Display.Text);
                firstNumber = false;
            }

            operation = "L";
            Display.Text = "";
        }

        private void Number1_Clicked(object sender, EventArgs e)
        {
            Display.Text += Number1.Text;
        }

        private void Number2_Clicked(object sender, EventArgs e)
        {
            Display.Text += Number2.Text;
        }

        private void Number3_Clicked(object sender, EventArgs e)
        {
            Display.Text += Number3.Text;
        }

        private void Sum_Clicked(object sender, EventArgs e)
        {
            if (firstNumber)
            {
                x = Convert.ToDouble(Display.Text);
                firstNumber = false;
            }

            operation = "S";
            Display.Text = "";
        }

        private void Number0_Clicked(object sender, EventArgs e)
        {
            Display.Text += Number0.Text;
        }

        private void Dot_Clicked(object sender, EventArgs e)
        {
            Display.Text += Dot.Text;
        }

        private void Equals_Clicked(object sender, EventArgs e)
        {
            y = Convert.ToDouble(Display.Text);

            if(y == null)
            {
                y = 0;
            }

            switch (operation)
            {
                case "S":
                    Display.Text = $"{x + y}";
                    break;
                case "L":
                    Display.Text = $"{x - y}";
                    break;
                case "M":
                    Display.Text = $"{x * y}";
                    break;
                case "D":
                    Display.Text = $"{x / y}";
                    break;
                case "R":
                    Display.Text = $"{Math.Pow(x, Math.Pow(y, -1))}";
                    break;
                case "P":
                    Display.Text = $"{y * (x/100)}";
                    break;
            }

            firstNumber = true;
        }

        private void Sen_Clicked(object sender, EventArgs e)
        {
            x = Convert.ToDouble(Display.Text);

            Display.Text = $"{Math.Sin(x)} rad";
        }

        private void Cos_Clicked(object sender, EventArgs e)
        {
            x = Convert.ToDouble(Display.Text);

            Display.Text = $"{Math.Cos(x)} rad";
        }

        private void Tg_Clicked(object sender, EventArgs e)
        {
            x = Convert.ToDouble(Display.Text);
            Display.Text = $"{Math.Tan(x)} rad";
        }

        private void SquareRoot_Clicked(object sender, EventArgs e)
        {
            if (firstNumber)
            {
                x = Convert.ToDouble(Display.Text);
                firstNumber = false;
            }

            operation = "R";
            Display.Text = "";
        }
    }

}
