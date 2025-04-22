namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string first = textBox1.Text;
            string second = textBox2.Text;

            int firstInt = int.Parse(first);
            int secondInt = int.Parse(second);

            int result = 0;

            if (comboBox1.SelectedIndex == 0)
            {
                result = firstInt + secondInt;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                result = firstInt - secondInt;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                result = firstInt * secondInt;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                result = firstInt / secondInt;
            }

            string resultString = result.ToString();
            label2.Text = resultString;
        }
    }
}
