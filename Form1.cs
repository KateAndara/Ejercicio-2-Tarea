namespace Ejercicio_2_Tarea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string [] Nombre = new string[5];
        int [] Edad = new int[5];
        int contadorN = -1;
        int contadorE = -1;
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            contadorN = contadorN + 1;
            contadorE = contadorE + 1;
            Nombre[contadorN] = NombretextBox.Text;
            Edad[contadorE] = Convert.ToInt32(EdadtextBox.Text);
            LimpiaTxt();
        }

        private void Mostrarbutton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Nombre.Length; i++)
            {
                DatoscomboBox.Items.Add(Nombre[i] + "   " + Edad[i]);
            }
        }
        public void LimpiaTxt()
        {
            NombretextBox.Text = "";
            EdadtextBox.Text = Convert.ToString(" ");
        }
         
     
    }
}