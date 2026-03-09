using WinFormsApp1;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtArgX.Text = Properties.Settings.Default.argX.ToString();
            txtArgY.Text = Properties.Settings.Default.argY.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int argX, argY;
            try
            {
                argX = int.Parse(this.txtArgX.Text);
                argY = int.Parse(this.txtArgY.Text);
            }
            catch (FormatException)
            {
                return;
            }

            Properties.Settings.Default.argX = argX;
            Properties.Settings.Default.argY = argY;
            Properties.Settings.Default.Save();

            int result = Logic.Multiply(argX, argY);
            MessageBox.Show("результат произведения: " + result.ToString());
        }
    }

    public class Logic
    {
        public static int Multiply(int argX, int argY)
        {
            int res = 0;

            for (int i = 0; i < argY; i++)
            {
                res = res + argX;
            }

            return res;
        }
    }
}
