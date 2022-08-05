namespace bubble
{
    public partial class Form1 : Form
    {
        List<int> coleccion;
       
        public Form1()
        {
            coleccion = new List<int>();
           
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (!int.TryParse(textBox1.Text, out num))
            {
                MessageBox.Show("Introduzca un numero");
               
            }
            else { 
                coleccion.Add(num);
            }
            textBox1.Text = "";
            mostrarColeccion();
          
        }

        public void mostrarColeccion()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = coleccion;
        }
        public void Ordenar()
        {
            var clase = new Clase();
            listBox2.DataSource = clase.Ordenar(coleccion);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox2.DataSource = null;
            coleccion.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ordenar();
        }
    }
}