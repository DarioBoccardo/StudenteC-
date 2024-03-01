using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studente
{
    internal class Studente : Persona
    {
        protected int Matricola { get; set; }
        protected double MediaVoti { get; set; }
        public Studente(int _matricola, double _mediaVoti, string _nome, string _cognome, DateTime _dataNascita) : base(_nome, _cognome, _dataNascita)
        {
            Matricola = _matricola;
            MediaVoti = _mediaVoti;
        }
        public bool Controllo(Studente s1, List<Studente> listS)
        {
            if (listS.Exists(p => p.Nome == s1.Nome && p.Cognome == s1.Cognome))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return base.ToString() + $", matricola {Matricola} e di media {MediaVoti}";
        }
    }
}
