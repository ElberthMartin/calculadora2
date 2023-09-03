namespace CALCULADORA
{
    //agregamos dentro de namespace para definir

    public enum operacion
    {
        nodefinida = 0,
        suma = 1,
        resta = 2,
        division = 3,
        multiplicacion = 4,
        modulo = 5,
    }

    public partial class Form1 : Form
    {
        //DECLARAMOS UN VALOR DE TIPO DOUBLE
        double valor1 = 0;
        //otra variable para la operacion
        double valor2 = 0;
        operacion operador = operacion.nodefinida;
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

        //creamos un metodo para operacion
        private double ejecutaroperacion()
        {
            double resultado = 0;
            switch (operador)


            {
                case operacion.suma:
                    resultado = valor1 + valor2;
                    break;

                case operacion.resta:
                    resultado = valor1 - valor2;
                    break;
                case operacion.division:
                    //no podemos dividir entre 0
                    if (valor2 == 0)
                    //aplicamos una advertencia
                    {
                        MessageBox.Show("No se puede dividir entre 0");
                        resultado = 0;
                    }
                    else
                    {
                        resultado = valor1 / valor2;
                    }
                    break;
                case operacion.multiplicacion:
                    resultado = valor1 * valor2;
                    break;
                case operacion.modulo:
                    resultado = valor1 % valor2;
                    break;
            }
            return resultado;
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
        //creamos para el historial un metodo 
        private void obtenervalor(string operador)
        {
            valor1 = Convert.ToDouble(cajaresultado.Text);
            lblhistorial.Text = cajaresultado.Text + operador;
            cajaresultado.Text = "0";
        }
        private void btnsuma_Click(object sender, EventArgs e)
        {
            operador = operacion.suma;
            //ahora convertimos
            obtenervalor("+");

        }

        private void btnresultado_Click(object sender, EventArgs e)
        {
            //preguntamos si el valor
            if (valor2 == 0)
            {
                valor2 = Convert.ToDouble(cajaresultado.Text);
                lblhistorial.Text += valor2 + "=";
                //calculamos resultado
                double resultado = ejecutaroperacion();
                valor1 = 0;
                valor2 = 0;
                cajaresultado.Text = Convert.ToString(resultado);
            }
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            operador = operacion.resta;
            obtenervalor("-");
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            operador = operacion.multiplicacion;
            obtenervalor("x");
        }

        private void btndivicion_Click(object sender, EventArgs e)
        {
            operador = operacion.division;
            obtenervalor("/");
        }

        private void btnmodulo_Click(object sender, EventArgs e)
        {
            operador = operacion.modulo;
            obtenervalor("%");
        }
        //BOTON BORRAR TODO
        private void btnreset_Click(object sender, EventArgs e)
        {
            cajaresultado.Text = "0";
            lblhistorial.Text = "";
        }
        //BOTON BORRAR UNO POR UNO
        private void btnborrar_Click(object sender, EventArgs e)
        {//si tiene una longitud a uno 
            if (cajaresultado.Text.Length > 1)
            {//generamos un valor 
                string txtResultado = cajaresultado.Text;
                txtResultado = txtResultado.Substring(0, txtResultado.Length - 1);

                if (txtResultado.Length == 1 && txtResultado.Contains("-"))
                {
                    cajaresultado.Text = "0";

                }
                else
                {
                    cajaresultado.Text = txtResultado;
                }



            }
            else
            {
                cajaresultado.Text = "0";
            }
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
cajaresultado.Text += ".";
        }
    }
}