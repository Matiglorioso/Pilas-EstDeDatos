namespace Pilas
{
    public partial class Form1 : Form
    {
        Nodo pri_1 = null;
        Nodo ult_1 = null;

        Nodo pri_2 = null;
        Nodo ult_2 = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            Nodo nvo = new Nodo();
            nvo.nombre = txtNombre.Text;
            nvo.dni = txtDNI.Text;
            if (pri_1 == null)
            {
                nvo.anterior = null;
                pri_1 = nvo;
                ult_1 = nvo;
            }
            else
            {
                nvo.anterior = ult_1;
                ult_1 = nvo;
            }
            txtDNI.Text = "";
            txtNombre.Text = "";
            Listar();
        }

        private void Listar()
        {
            Nodo aux = new Nodo();
            aux = ult_1;
            lstPila1.Items.Clear();
            if (aux != null)
            {
                while (aux != null)
                {
                    lstPila1.Items.Add(aux.nombre + " - " + aux.dni);
                    aux = aux.anterior;
                }
            }
        }

        private void cmdQuitarPila1_Click(object sender, EventArgs e)
        {
            Nodo aux = new Nodo();
            aux = ult_1;

            if (aux != null)
            {
                ult_1 = aux.anterior;// cambia el puntero ult1
                if (pri_2 == null)
                {
                    aux.anterior = null; //cambia el puntero ult
                    pri_2 = aux;
                    ult_2 = aux;
                }
                else
                {
                    aux.anterior = ult_2;
                    ult_2 = aux;
                }
            }
            else
            {
                MessageBox.Show("No hay mas items en la Pila");
            }
            Listar();
            Listar2();
        }

        private void Listar2()
        {
            Nodo aux = new Nodo();
            aux = ult_2;
            lstPila2.Items.Clear();
            if (aux != null)
            {
                while (aux != null)
                {
                    lstPila2.Items.Add(aux.nombre + " - " + aux.dni);
                    aux = aux.anterior;
                }
            }
        }

        private void cmdQuitarPila2_Click(object sender, EventArgs e)
        {
            Nodo aux = new Nodo();
            aux = ult_2;

            if (aux != null)
            {
                ult_2 = aux.anterior;// cambia el puntero ult1
                if (pri_1 == null)
                {
                    aux.anterior = null; //cambia el puntero ult
                    pri_1 = aux;
                    ult_1 = aux;
                }
                else
                {
                    aux.anterior = ult_1;
                    ult_1 = aux;
                }
            }
            else
            {
                MessageBox.Show("No hay mas items en la Pila che guanaco");
            }
            Listar();
            Listar2();
        }
    }
    

}