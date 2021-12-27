namespace YioTranslate.Models
{
    public enum DicioType
    {
        NONE,
        VERB,
        ADJECTIVE,
        SUBJECT,
        SUBSTANTIVE
    }

    public static class DicioTypeUtilities
    {
        public static string ToDescriptionString(this DicioType dicioType)
        {
            switch (dicioType)
            {
                case DicioType.NONE:
                    return "-";
                case DicioType.VERB:
                    return "Verbo";
                case DicioType.ADJECTIVE:
                    return "Adjetivo";
                case DicioType.SUBJECT:
                    return "Sujeito";
                default:
                    return "Substantivo";
            }
        }
    }
}
