namespace CALCULADORA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //creamos un metodo privado creado despues de los codigos de uno para poder reutilizar

        private void leernumero(string numero)
        //colocamos void no va devolver nada
        {
            if (cajaresultado.Text == "0" && cajaresultado.Text != null)

            {
                cajaresultado.Text = numero;
            }
            else
            {
                cajaresultado.Text += numero;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //para el boton cero
        private void btncero_Click(object sender, EventArgs e)
        {
            //llamamos
            {
                leernumero("0");
            }

        }

        private void btnuno_Click(object sender, EventArgs e)
        {
            {
                leernumero("1");
            }
        }

        private void btndos_Click(object sender, EventArgs e)
        {

        }
    }
}