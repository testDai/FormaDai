//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FormaDai
{
    using System;
    using System.Collections.Generic;
    
    public partial class Equipe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Equipe()
        {
            this.Personne = new HashSet<Personne>();
        }
    
        public int IdEquipe { get; set; }
        public int IdProjet { get; set; }
        public string Nom { get; set; }
        public string Logo { get; set; }
        public System.DateTime DateCreation { get; set; }
        public int EstCreateur { get; set; }
    
        public virtual Projet Projet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Personne> Personne { get; set; }
    }
}
