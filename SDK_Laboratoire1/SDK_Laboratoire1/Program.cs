
using LibrairieConversionNote;
string transformation;

Console.WriteLine("Bienvenue au transformeur de lettres en notes. Veuillez remarquer que les lettres doivent etres en majuscules et que vous avez le choix de A a G. veuillez choisir votre lettre: ");
do
{
    string lettreChoisie = Console.ReadLine();
    transformation = ConversionAlphabetiqueToNote.Transformer(lettreChoisie);
    while(transformation == "La lettre entree est invalide. Veuillez ressayer.")
    {
        Console.WriteLine("La lettre entree est invalide. Veuillez choisir a nouveau de A a G.");
        break;
    }
} while (transformation == "La lettre entree est invalide. Veuillez ressayer.");
Console.WriteLine(transformation);
    


