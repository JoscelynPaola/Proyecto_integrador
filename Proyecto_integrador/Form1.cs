using System.Diagnostics.CodeAnalysis;

namespace Proyecto_integrador
{
    public partial class Form1 : Form
    {

        Repositorio<Estudiante> objRepositorio = new Repositorio<Estudiante>(10);//se indica la cantidad de elementos permitidos 
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }        

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            lbxtda.Items.Clear();
            Estudiante objEstudiante = objRepositorio.buscarPorID(Convert.ToInt32(txtid.Text));//buscar estudiantes por ID
            if (objEstudiante != null)
            {
                lbxtda.Items.Add(objEstudiante.id + " - " + objEstudiante.nombre + " Edad: " + objEstudiante.edad + " Calificación: " + objEstudiante.calificacion);
            }
            else
            {
                MessageBox.Show("No se encontró en nuestro sistema");
            }
        }

        private void btntdaagregar_Click(object sender, EventArgs e)//agregar con tipos de datos abstractos TDA
        {
            try
            {
                Estudiante objEstudiante = new Estudiante(); //creacion de un objeto de la clase estudiantes

                objEstudiante.nombre = texttdanombre.Text;//asignar los valores 
                objEstudiante.edad = Convert.ToInt32(txttdaedad.Text);
                objEstudiante.calificacion = Convert.ToDouble(txttdacalificacion.Text);
                //yyyy año
                //MM mes (formato 2 numeros) 
                //dd dia (formato 2 numeros)

                //HH horas (24)
                //hh horas (12)
                //mm min
                //ss seg
                //fff milisegundo
                objEstudiante.id = Convert.ToInt32(DateTime.Now.ToString("MdHHmm")) + new Random().Next(1, 100);//creacion de id 

                objRepositorio.agregar(objEstudiante);//agregar el objeto, usando la funcion agregar 

                texttdanombre.Text = string.Empty;//string.Empty:limpia el txt
                txttdaedad.Text = string.Empty;
                txttdacalificacion.Text = string.Empty;
                texttdanombre.Focus();//Focus:es para colocar el cursor en el control
            }
            catch (Exception ex)
            {

            }
        }

        private void btntdaeliminar_Click(object sender, EventArgs e)//eliminar con tipos de datos abstractos
        {
            try
            {
                objRepositorio.eliminarPorIndice(Convert.ToInt32(txttdaindice.Text));
            }
            catch (Exception ex)
            {

            }
        }

        private void btnmostrartda_Click(object sender, EventArgs e)//mostrar con tipos de datos abstractos
        {
            objRepositorio.listarElementos(ref lbxtda);
        }

        private void btntdapromedio_Click(object sender, EventArgs e)//calcular promedio 
        {
            MessageBox.Show("Promedio de todos: " + objRepositorio.calcularPromedio().ToString());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
