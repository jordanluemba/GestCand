namespace GestCand.Models
{
    public class Candidat
    {
        public int Id { get; set; }           // Identifiant unique
        public string? Nom { get; set; }       // Nom du candidat
        public string? Postnom { get; set; }   // Postnom du candidat
        public string? Prenom { get; set; }    // Prénom du candidat
        public string? Sexe { get; set; }      // Sexe (Homme/Femme)
        public string? LieuNaissance { get; set; } // Lieu de naissance
        public DateTime? DateNaissance { get; set; } // Date de naissance
        public string? Nationalite { get; set; } // Nationalité
        public string? Adresse { get; set; }     // Adresse
        public string? Telephone { get; set; }   // Numéro de téléphone
    }
}
