using System.Security.Cryptography.X509Certificates;


namespace LibrairieConversionNote
{
    public class ConversionAlphabetiqueToNote
    {
        
        public static string Transformer(string lettre)
        {
            lettre = lettre.ToUpper();
            lettre = lettre.Trim();

            switch (lettre)
            {
                case "A":
                    return "La note est LA";
                case "B":
                    return "La note est SI";
                case "C":
                    return "La note est DO";
                case "D":
                    return "La note est RE";
                case "E":;
                    return "La note est MI";
                case "F":
                    return "La note est FA";
                case "G":
                    return "La note est SOL";
                default:
                    return "Invalide";
            }
            
        }
    }

    
}