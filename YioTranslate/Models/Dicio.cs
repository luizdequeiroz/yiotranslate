namespace YioTranslate.Models
{
    public class Dicio
    {
        public int Id { get; set; }
        public string PtBr { get; set; }
        public string YiokText
        {
            get
            {
                if (!string.IsNullOrEmpty(Sugg))
                    return Sugg;
                else return Yiok;
            }
        }
        internal string Yiok { get; set; }
        internal string Sugg { get; set; }
        internal DicioType Type { get; set; }
        public string DicioTypeText
        {
            get
            {
                return Type.ToDescriptionString();
            }
        }
    }
}
