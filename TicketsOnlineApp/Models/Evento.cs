namespace TicketsOnlineApp.Models
{
    public class Evento
    {
        public int IdEvento { get; set; }

        public string NombreEvento { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public int HoraInicio { get; set; }

        public int HoraFin { get; set; }

        public string DireccionEvento { get; set; }

        public string CiudadEvento { get; set; }

        public string DepartamentoEvento {get; set; }

        public string PaisEvento { get; set; }

        public string UbicacionEvento { get; set; }

        public string ImagenEvento { get; set; }

        public bool EstatusEvento { get; set; }

        public string ImagenEvento { get; set; }

        public string DescripcionEvento { get; set; }



    }
}
