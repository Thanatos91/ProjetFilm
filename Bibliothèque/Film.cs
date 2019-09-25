using System;
using System.Collections.Generic;

namespace Bibliothèque
{
    public class Film
    {
        public string TitreFilm { get; set; }
        public int NbEntrees { get; set; }
        public string PhotoFilm { get; set; }
        public Realisateur LeRealisateur { get; set; }
        public List<Acteur> LesActeurs { get; set; }

        public void AjouterActeur(Acteur unActeur)
        {
            LesActeurs.Add(unActeur);
        }
    }
}