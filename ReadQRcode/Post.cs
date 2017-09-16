

namespace ReadQRcode
{
    public class Post
    {
        private int id;
        private string titulo;
        private string imagen;
        private string descripcion;
        private string url_mas;
        private string categoria;
        private string fecha;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Titulo
        {
            get
            {
                return titulo;
            }

            set
            {
                titulo = value;
            }
        }

        public string Imagen
        {
            get
            {
                return imagen;
            }

            set
            {
                imagen = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public string Url_mas
        {
            get
            {
                return url_mas;
            }

            set
            {
                url_mas = value;
            }
        }

        public string Categoria
        {
            get
            {
                return categoria;
            }

            set
            {
                categoria = value;
            }
        }

        public string Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public Post() { }
        public Post(int id, string titulo, string foto, string descripcion, string url_mas, string categoria)
        {
            this.id = id;
            this.titulo = titulo;
            this.imagen = foto;
            this.descripcion = descripcion;
            this.url_mas = url_mas;
            this.categoria = categoria;
        }
    }
}
