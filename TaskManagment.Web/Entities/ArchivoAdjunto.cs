using Microsoft.EntityFrameworkCore;

namespace TaskManagment.Web.Entities
{
    public class ArchivoAdjunto
    {
        public Guid Id { get; set; }

        public int TareaId { get; set; }

        public Tarea Tarea { get; set; }

        [Unicode]
        public string Url { get; set; }

        public string TituloArchivoAdjunto { get; set; }

        public int OrdenArchivoAdjunto { get; set; }

        public DateTime FechaCreacion { get; set; }
    }
}
