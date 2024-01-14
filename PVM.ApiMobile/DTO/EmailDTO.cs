namespace PVM.ApiMobile.DTO
{
    public class EmailDTO
    {

        public List<string> correosAEnviar { get; set; }

        public string asunto { get; set; }

        public string contenido { get; set; }

        public List<string>? nombresArchivos { get; set; } = null;

        public List<byte[]>? listabyte { get; set; } = null;

    }
}
