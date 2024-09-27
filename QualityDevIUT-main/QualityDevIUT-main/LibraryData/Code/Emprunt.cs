using Data.Code.Medias;
using System;

namespace Data.Code
{
    /// <summary>
    /// Classe impl�mentant l'emprunt
    /// </summary>
    public class Emprunt
    {
        #region Privates Members
        public string m_MediaName { get; set; }
        public int m_MediaNumRef { get; set; }
        public string m_NomUtilisateur { get; set; }
        public DateTime m_DateEmprunt { get; set; }
        public DateTime m_DateEcheance { get; set; }
        public bool m_Retourne { get; set; }
        public DateTime m_DateRetour { get; set; }
        #endregion

        #region Public M�thodes : accesseurs
        /// <summary>
        /// Retourne le nom du m�dia emprunt�
        /// </summary>
        /// <returns></returns>
        public string GetMediaName()
        {
            return m_MediaName;
        }
        /// <summary>
        /// Retourne le num�ro de r�f�rence de l'emprunt
        /// </summary>
        /// <returns></returns>
        public int GetMediaNumRef()
        {
            return m_MediaNumRef;
        }
        /// <summary>
        /// Retourne l'utilisateur qui a effectu� un emprunt
        /// </summary>
        /// <returns></returns>
        public string GetNomUtilisateur()
        {
            return m_NomUtilisateur;
        }
        /// <summary>
        /// Retourne la date d'emprunt
        /// </summary>
        /// <returns></returns>
        public DateTime GetDateEmprunt()
        {
            return m_DateEmprunt;
        }

        /// <summary>
        /// Retourne la date d'�ch�ance de l'emprunt
        /// </summary>
        /// <returns></returns>
        public DateTime GetDateEcheance()
        {
            return m_DateEcheance;
        }

        /// <summary>
        /// Retourne la date de retour de l'emprunt
        /// </summary>
        /// <returns></returns>
        public DateTime GetDateRetour()
        {
            return m_DateRetour;
        }

        /// <summary>
        /// Acceseurs de la date de retour
        /// </summary>
        /// <param name="p_DateDeRetour">date de retour � ins�rer</param>
        public void SetDateRetour(DateTime p_DateDeRetour)
        {
            m_DateRetour = p_DateDeRetour;
        }

        /// <summary>
        /// Bool�en qui indique si le m�dia a �t� rendu
        /// </summary>
        /// <returns></returns>
        public bool IsRetourned()
        {
            return m_Retourne;
        }

        /// <summary>
        /// Permet de d�finir le bool�en IsRetourned
        /// </summary>
        /// <param name="isRetourne"></param>
        public void SetRetour(bool isRetourne)
        {
            m_Retourne = isRetourne;
        }
        #endregion

        #region Constructeurs
        public Emprunt(Media p_media, string p_nomUtilisateur, DateTime p_dateEmprunt, DateTime p_dateEcheance)
        {
            m_MediaName = p_media.GetTitre();
            m_MediaNumRef = p_media.GetNumeroReference();
            m_NomUtilisateur = p_nomUtilisateur;
            m_DateEmprunt = p_dateEmprunt;
            m_DateEcheance = p_dateEcheance;
        }

        public Emprunt()
        {
        }
        #endregion
        /// <summary>
        /// Affichage des infos concernant l'emprunt
        /// </summary>
        public void AfficherInfos()
        {
            Console.WriteLine($"Titre : {m_MediaName}");
            Console.WriteLine($"Num�ro de R�f�rence : {m_MediaNumRef}");
            Console.WriteLine($"Utilisateur : {m_NomUtilisateur}");
            Console.WriteLine($"Date d'emprunt : {m_DateEmprunt}");
            Console.WriteLine($"Date d'�cheance : {m_DateEcheance}");
            Console.WriteLine($"Retourn� : {(m_Retourne ? "Oui" : "Non")}");
            if(m_Retourne) Console.WriteLine($"Date de retour : {m_DateRetour}");
        }
        
    }
}