namespace CALCULADORA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncero_Click(object sender, EventArgs e)
        {
            cajaresultado.Text += "0";
        }
    }
}