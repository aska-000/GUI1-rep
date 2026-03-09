using WinFormsApp1;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int argX = int.Parse(this.txtArgX.Text);
            int argY = int.Parse(this.txtArgY.Text);

            int result = Logic.Multiply(argX, argY);
            MessageBox.Show(result.ToString());
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
