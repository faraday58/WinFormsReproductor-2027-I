namespace WinFormsReproductor_2027_I
{
    public partial class Form1 : Form
    {
        List<Modelo.Musica> listaReproduccion;

        public Form1()
        {
            InitializeComponent();
            listaReproduccion = new List<Modelo.Musica>();
            CargarListaReproduccion();
        }

        private void CargarListaReproduccion()
        {
            listaReproduccion.Add(new Modelo.Musica("Have you ever seen the rain", "Creedence", "Pendulum"));
            listaReproduccion.Add(new Modelo.Musica("Hand Me Downs", "Mac miller", "Circles"));
            listaReproduccion.Add(new Modelo.Musica("Strawberries", "The Beatles", "Magic Mistery Tour"));

            foreach (var musica in listaReproduccion)
            {
                lstbReproduccion.Items.Add(musica.Nombre);
            }
        }

        private void lstbReproduccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSelec = lstbReproduccion.SelectedIndex;
            var cancion = listaReproduccion[indiceSelec];
            lbArtista.Text = cancion.Artista;
            lbAlbum.Text = cancion.Album;
            lbNombre.Text = cancion.Nombre;
        }
    }
}
