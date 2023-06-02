using System.Security.Cryptography.X509Certificates;


namespace LibrairieConversionNote
{
    public class ConversionAlphabetiqueToNote
    {
     
        public static string Transformer(string lettre)
        {


            if (lettre == "A")
            {
                return "La note est LA";
            }
            else if (lettre == "B")
            {
                return "La note est SI";
            }
            else if (lettre == "C")
            {
                return "La note est DO";
            }
            else if (lettre == "D")
            {
                return "La note est RE";
            }
            else if (lettre == "E")
            {
                return "La note est MI";
            }
            else if (lettre == "F")
            {
                return "La note est FA";
            }
            else if (lettre == "G")
            {
                return "La note est SOL";
            }
            else if (lettre != "A" || lettre != "B" || lettre != "C" || lettre != "D" || lettre != "E" || lettre != "F" || lettre != "G") {
                return "La lettre entree est invalide. Veuillez ressayer.";
            }
            return lettre;
        }
    }

    
}