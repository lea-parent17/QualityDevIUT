using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.Json;
using BookstoreManagementExercise;

namespace BookstoreManagementExercise
{
    /// <summary>
    /// Classe Library représentant la collection de médias.
    /// </summary>
    public class Library
    {
        private List<Media> v_medias = new List<Media>();

        /// <summary>
        /// Accéder à un média par son numéro de référence.
        /// </summary>
        public Media this[int numeroReference]
        {
            get { return v_medias.Find(media => media.NumeroReference == numeroReference); }
        }

        public void AjouterMedia(Media p_media)
        {
            v_medias.Add(p_media);
        }

        public void RetirerMedia(Media p_media)
        {
            v_medias.Remove(p_media);
        }

        public void EmprunterMedia(Media p_media)
        {
            if (p_media.ExemplairesDisponibles > 0)
            {
                p_media.ExemplairesDisponibles--;
            }
            else
            {
                throw new InvalidOperationException("Ce média n'est pas disponible pour l'emprunt.");
            }
        }

        public void RetournerMedia(Media p_media)
        {
            p_media.ExemplairesDisponibles++;
        }

        /// <summary>
        /// Rechercher des médias par titre ou auteur.
        /// </summary>
        public List<Media> RechercherMedia(string p_critere)
        {
            return v_medias.FindAll(media => media.Titre.Contains(p_critere) ||
                                             (media is Livre && ((Livre)media).Auteur.Contains(p_critere)));
        }

        public void Sauvegarder(string p_chemin)
        {
            string v_json = JsonSerializer.Serialize(v_medias);
            File.WriteAllText(p_chemin, v_json);
        }

        public void Charger(string p_chemin)
        {
            string v_json = File.ReadAllText(p_chemin);
            v_medias = JsonSerializer.Deserialize<List<Media>>(v_json);
        }


    }
}
