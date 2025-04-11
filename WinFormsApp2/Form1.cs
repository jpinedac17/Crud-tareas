
namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        CrudDB umg;
        string? carnet;
        string? nombre;
        string? seccion;
        string? nota1;
        string? nota2;
        string? nota3;
        string? nota4;

        public Form1()
        {
            InitializeComponent();
            umg = new CrudDB();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            carnet = Carnet.Text;
            nombre = umg.ObtenerNombrePorCarnet(carnet);
            textBoxNombre.Text = nombre;

            seccion = umg.ObtenerSeccion(carnet);
            textBoxSeccion.Text = seccion;

            nota1 = umg.ObtenerNota(carnet, "nota1");
            textBoxNota1.Text = nota1;
            nota2 = umg.ObtenerNota(carnet, "nota2");
            textBoxNota2.Text = nota2;
            nota3 = umg.ObtenerNota(carnet, "nota3");
            textBoxNota3.Text = nota3;
            nota4 = umg.ObtenerNota(carnet, "nota4");
            textBoxNota4.Text = nota4;
        }

        private void Carnet_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            carnet = Carnet.Text;
            nombre = textBoxNombre.Text;
            seccion = textBoxSeccion.Text;
            nota1 = textBoxNota1.Text;
            nota2 = textBoxNota2.Text;
            nota3 = textBoxNota3.Text;
            nota4 = textBoxNota4.Text;

            umg.AgregarAlumno(carnet, nombre, "", seccion);
            umg.AgregarTareas(carnet, nota1, nota2, nota3, nota4);

            //Resetear valores
            Carnet.Text = "";
            textBoxNombre.Text = "";
            textBoxSeccion.Text = "";
            textBoxNota1.Text = "";
            textBoxNota2.Text = "";
            textBoxNota3.Text = "";
            textBoxNota4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            carnet = Carnet.Text;
            umg.EliminarTareas(carnet);
            umg.EliminarALumno(carnet);

            //Resetear valores
            Carnet.Text = "";
            textBoxNombre.Text = "";
            textBoxSeccion.Text = "";
            textBoxNota1.Text = "";
            textBoxNota2.Text = "";
            textBoxNota3.Text = "";
            textBoxNota4.Text = "";
        }
    }
}
