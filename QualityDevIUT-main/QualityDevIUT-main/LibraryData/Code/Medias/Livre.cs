using System;

namespace Data.Code.Medias
{
    public class Livre : Media
    {
        /// <summary>
        /// Classe impl�mentant le m�dia de type Livre
        /// </summary>
        #region Privates Members
        public string m_Auteur { get; set; }
        #endregion

        #region Constructeur
        public Livre(string p_titre, int p_numeroReference, int p_nombreExemplairesDisponibles, string p_auteur)
            : base(p_titre, p_numeroReference, p_nombreExemplairesDisponibles)
        {
            m_Auteur = p_auteur;
        }
        #endregion

        #region Public M�thodes : accesseurs
        /// <summary>
        /// Retourne l'auteur du Livre
        /// </summary>
        /// <returns>string</returns>
        public string GetAuteur()
        {
            return m_Auteur;
        }
        #endregion

        #region Public M�thodes : Tools
        /// <summary>
        /// Retourne les infos du Livre
        /// </summary>
        /// <returns>string</returns>
        public override void AfficherInfos()
        {
            base.AfficherInfos();
            Console.WriteLine($"Auteur : {m_Auteur}");
        }
        #endregion
    }
}