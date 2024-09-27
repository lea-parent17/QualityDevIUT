using BookstoreManagementExercise;

public class Program
{
    public static void Main()
    {
        Library v_library = new Library();

        // Ajout de médias
        v_library.AjouterMedia(new Livre("bricolage les nuls", 1, 5, "John Doe"));
        v_library.AjouterMedia(new DVD("Divergente", 2, 3, 148));
        v_library.AjouterMedia(new CD("Best of 2020", 3, 10, "Various Artists"));

        // Affichage des informations des médias
        foreach (var v_media in v_library.RechercherMedia(""))
        {
            v_media.AfficherInfos();
        }

        // Emprunt d'un média
        try
        {
            v_library.EmprunterMedia(v_library[1]);
            Console.WriteLine("Média emprunté avec succès.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erreur : {ex.Message}");
        }

        // Sauvegarde de la bibliothèque
        v_library.Sauvegarder("bibliotheque.json");

        // Chargement de la bibliothèque
        v_library.Charger("bibliotheque.json");
        Console.WriteLine("Bibliothèque chargée.");
    }
}
