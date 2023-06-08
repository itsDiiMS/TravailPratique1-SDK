
using LibrairieConversionNote;
string transformation;

Console.WriteLine("Bienvenue au transformeur de lettres en notes. Veuillez remarquer que vous avez le choix seulement entre A et G. veuillez choisir votre lettre: ");
do
{
    string lettreChoisie = Console.ReadLine();
    transformation = ConversionAlphabetiqueToNote.Transformer(lettreChoisie);
    if (transformation == "Invalide")
    {
        Console.WriteLine("La lettre entree est invalide. Veuillez choisir a nouveau de A a G.");
    }
} while (transformation == "Invalide");
Console.WriteLine(transformation);
    


