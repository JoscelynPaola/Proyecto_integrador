using System.Diagnostics.CodeAnalysis;

namespace Proyecto_integrador
{
    public partial class Form1 : Form
    {
        Estudiante[] arregloEstudiantes = new Estudiante[10];//creacion de un arreglo de estudiantes 
        int indiceEstudiante = 0;
        int numeroLista = 1;

        Repositorio<Estudiante> objRepositorio = new Repositorio<Estudiante>();
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

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (indiceEstudiante < 9)
                {
                    Estudiante objEstudiante = new Estudiante();//creacion de un nuevo objeto estudiante

                    objEstudiante.nombre = txtnombre.Text;
                    objEstudiante.edad = Convert.ToInt32(txtedad.Text);//convertir a Int
                    objEstudiante.calificacion = Convert.ToDouble(txtcalificacion.Text);//convertir a Double
                    objEstudiante.id = numeroLista;
                    arregloEstudiantes[indiceEstudiante] = objEstudiante;

                    txtnombre.Text = string.Empty;//string.Empty:limpia el txt
                    txtedad.Text = string.Empty;
                    txtcalificacion.Text = string.Empty;
                    txtnombre.Focus();//Focus:es para colocar el cursor en el control 
                    numeroLista++;// ir incrementando numero de lista
                    indiceEstudiante++;// ir incrementando el indice 
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbxlista.Items.Clear();//limpiar la listbox
            for (int i = 0; i < 10; i++)//con una condicion de que no sea mayor a 10
            {
                if (arregloEstudiantes[i] != null)//mientras que el arreglo de estudiantes no sea nulo
                {
                    lbxlista.Items.Add(arregloEstudiantes[i].id + " - " + arregloEstudiantes[i].nombre + " Edad: " + arregloEstudiantes[i].edad + " Calificación: " + arregloEstudiantes[i].calificacion);
                }
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            int indiceBusqueda = 0;
            lbxlista.Items.Clear();
            Estudiante objEstudiante = buscarEstudiantePorID(Convert.ToInt32(txtid.Text), indiceBusqueda);//buscar estudiantes por ID
            if (objEstudiante != null)
            {
                lbxlista.Items.Add(objEstudiante.id + " - " + objEstudiante.nombre + " Edad: " + objEstudiante.edad + " Calificación: " + objEstudiante.calificacion);
            }
        }

        public Estudiante buscarEstudiantePorID(int _id, int _indiceBusqueda)//Recursiva: por que se manda a llamar a si misma 
        {
            Estudiante objEstudiante = null;

            if (indiceEstudiante > 0)
            {
                if (arregloEstudiantes[_indiceBusqueda].id == _id)
                {
                    objEstudiante = arregloEstudiantes[_indiceBusqueda];
                }
                else
                {
                    _indiceBusqueda++;
                    objEstudiante = buscarEstudiantePorID(_id, _indiceBusqueda);
                }
            }

            return objEstudiante;
        }

        private void btntdaagregar_Click(object sender, EventArgs e)//agregar con tipos de datos abstractos TDA
        {
            try
            {
                Estudiante objEstudiante = new Estudiante();

                objEstudiante.nombre = texttdanombre.Text;
                objEstudiante.edad = Convert.ToInt32(txttdaedad.Text);
                objEstudiante.calificacion = Convert.ToDouble(txttdacalificacion.Text);
                objEstudiante.id = Convert.ToInt32(DateTime.Now.ToString("MdHHmm")) + new Random().Next(1, 100);//creacion de id

                objRepositorio.agregar(objEstudiante);

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
    }
}
