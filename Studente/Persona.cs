using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Studente
{
    internal class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        protected DateTime DataNascita { get; set; }
        protected int Anni { get; set; }
        public Persona(string _nome, string cognome, DateTime _dataNascita)
        {
            Nome = _nome;
            Cognome = cognome;
            DataNascita = _dataNascita;
            Anni = DateTime.Now.Year - _dataNascita.Year;
        }
        public bool Controllo(Persona p1, List <Persona> listP)
        {
            if(listP.Exists(p => p.Nome == p1.Nome && p.Cognome == p1.Cognome))
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
            return $"Nome: {Nome}, cognome: {Cognome}, data di nascita: {DataNascita.ToString("dd-MM-yyyy")} di anni {Anni}";
        }
    }
}
