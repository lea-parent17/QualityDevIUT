using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagementExercise
{

    /// <summary>
    /// Classe de base Media représentant un média dans la bibliothèque.
    /// </summary>
    public class Media
    {
        public string Titre { get; set; }
        public int NumeroReference { get; set; }
        public int ExemplairesDisponibles { get; set; }

        public Media(string titre, int numeroReference, int exemplairesDisponibles)
        {
            Titre = titre;
            NumeroReference = numeroReference;
            ExemplairesDisponibles = exemplairesDisponibles;
        }

        /// <summary>
        /// Affiche les informations du média. Peut être surchargée par les classes dérivées.
        /// </summary>
        public virtual void AfficherInfos()
        {
            Console.WriteLine($"Titre: {Titre}, Référence: {NumeroReference}, Exemplaires disponibles: {ExemplairesDisponibles}");
        }


        /// <summary>
        /// Surcharge de l'opérateur + pour ajouter des exemplaires.
        /// </summary>
        public static Media operator +(Media media, int nombreExemplaires)
        {
            media.ExemplairesDisponibles += nombreExemplaires;
            return media;
        }


        /// <summary>
        /// Surcharge de l'opérateur - pour retirer des exemplaires.
        /// </summary>
        public static Media operator -(Media media, int nombreExemplaires)
        {
            if (media.ExemplairesDisponibles >= nombreExemplaires)
            {
                media.ExemplairesDisponibles -= nombreExemplaires;
            }
            else
            {
                throw new InvalidOperationException("Nombre d'exemplaires insuffisant.");
            }
            return media;
        }
    }

    /// <summary>
    /// Classe Livre héritant de Media avec une propriété Auteur.
    /// </summary>
    public class Livre : Media
    {
        public string Auteur { get; set; }

        public Livre(string titre, int numeroReference, int exemplairesDisponibles, string auteur)
            : base(titre, numeroReference, exemplairesDisponibles)
        {
            Auteur = auteur;
        }

        public override void AfficherInfos()
        {
            base.AfficherInfos();
            Console.WriteLine($"Auteur: {Auteur}");
        }
    }

    /// <summary>
    /// Classe DVD héritant de Media avec une propriété Durée.
    /// </summary>
    public class DVD : Media
    {
        public int Duree { get; set; }

        public DVD(string titre, int numeroReference, int exemplairesDisponibles, int duree)
            : base(titre, numeroReference, exemplairesDisponibles)
        {
            Duree = duree;
        }

        public override void AfficherInfos()
        {
            base.AfficherInfos();
            Console.WriteLine($"Durée: {Duree} minutes");
        }
    }

    /// <summary>
    /// Classe CD héritant de Media avec une propriété Artiste.
    /// </summary>
    public class CD : Media
    {
        public string Artiste { get; set; }

        public CD(string titre, int numeroReference, int exemplairesDisponibles, string artiste)
            : base(titre, numeroReference, exemplairesDisponibles)
        {
            Artiste = artiste;
        }

        public override void AfficherInfos()
        {
            base.AfficherInfos();
            Console.WriteLine($"Artiste: {Artiste}");
        }
    }

}
