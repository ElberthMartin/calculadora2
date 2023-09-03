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
        //para el boton cero
        private void btncero_Click(object sender, EventArgs e)
        {
            //si tiene otro numero qe continue si tiene cer no 
           // cajaresultado.Text += "0";
        if (cajaresultado.Text=="0")
{//retornamos
                return;
            }
        else
            {
                cajaresultado.Text += "0";
            }
        }
    }
}