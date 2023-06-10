namespace TaskManagment.Web.Entities
{
    public class Paso
    {
        public Guid Id { get; set; }

        public int TareaId { get; set; }

        public string DescripcionPaso { get; set;}

        public bool Realizado { get; set; }

        public int OrdenPaso { get; set; }

        public Tarea Tarea { get; set; }
    }
}
