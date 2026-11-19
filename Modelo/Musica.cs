
namespace WinFormsReproductor_2027_I.Modelo
{
    internal class Musica
    {
        #region Atributos
        private string nombre;
        private string artista;
        private string album;
        #endregion

        #region Constructores
        public Musica(string nombre, string artista, string album)
        {
            Nombre = nombre;
            Artista = artista;
            Album = album;
        }
        #endregion

        #region Propiedades
        public string Nombre { get => nombre; set => nombre = value; }
        public string Artista { get => artista; set => artista = value; }
        public string Album { get => album; set => album = value; }
        #endregion
    }
}
