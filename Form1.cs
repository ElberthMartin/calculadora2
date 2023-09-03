namespace CALCULADORA
{
    public partial class Form1 : Form
    {
        //DECLARAMOS UN VALOR DE TIPO DOUBLE
        double valor1 = 0;
        //otra variable para la operacion
        double valor2 = 0;
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
        //2
        private void btndos_Click(object sender, EventArgs e)
        {
            leernumero("2");
        }

        private void btntres_Click(object sender, EventArgs e)
        {
            leernumero("3");
        }

        private void btncuatro_Click(object sender, EventArgs e)
        {
            leernumero("4");
        }

        private void btncinco_Click(object sender, EventArgs e)
        {
            leernumero("5");
        }

        private void btnseis_Click(object sender, EventArgs e)
        {
            leernumero("6");
        }

        private void btnsiete_Click(object sender, EventArgs e)
        {
            leernumero("7");
        }

        private void btnocho_Click(object sender, EventArgs e)
        {
            leernumero("8");
        }

        private void btnnueve_Click(object sender, EventArgs e)
        {
            leernumero("9");
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            //ahora convertimos
            valor1 = Convert.ToDouble(cajaresultado.Text);
            lblhistorial.Text = cajaresultado.Text + " + ";
            cajaresultado.Text = "0";

        }

        private void btnresultado_Click(object sender, EventArgs e)
        {
            //preguntamos si el valor
            if(valor2==0)
            {
                valor2=Convert.ToDouble(cajaresultado.Text);
                lblhistorial.Text += valor2 + "=";
                
            }
        }
    }
}