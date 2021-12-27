namespace YioTranslate.Models
{
    public class Relationship
    {
        public int Id { get; set; }
        public int MainDicioId { get; set; }
        public string MainDicio { get; set; }
        public int AdjunctDicioId { get; set; }
        public string AdjunctDicio { get; set; }
    }
}
