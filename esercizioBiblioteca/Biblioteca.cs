using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizioBiblioteca
{
    class Biblioteca
    {
        private string _nome;
        private string _indirizzo;

        public string Nome
        {
            get => _nome;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("inserire nome valido");

                _nome = value;
            }
        }

        public string Indirizzo
        {
            get => _indirizzo;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("inserire indirizzo valido");

                _indirizzo = value;
            }
        }

        public string[] OrariApertura
        {
            get;
            set;
        }

        public string[] OrariChiusura
        {
            get;
            set;
        }

        public List<Libro> Libri
        {
            get;
            set;
        }

        public Biblioteca(string nome, string indirizzo)
        {
            Nome = nome;
            Indirizzo = indirizzo;
        }

       public Biblioteca(string nome, string indirizzo, string[] orariApertura, string[] orariChiusura, List<Libro> libri) : this(nome, indirizzo)
        {
            OrariApertura = orariApertura;
            OrariChiusura = orariChiusura;
            Libri = libri;
        }

        public void AggiungiLibro(Libro l)
        {
            Libri.Add(l);
        }

        public Libro RicercaPerTitolo(string titolo)
        {
            Libro libro=new Libro();

            foreach(Libro l in Libri)
            {
                if (l.Titolo == titolo)
                    libro = l;
            }

            return libro;
        }

        public List<Libro> RicercaLibriPerAutore(string autore)
        {
            List<Libro> libriTrovati=new List<Libro>();

            foreach(Libro l in Libri)
            {
                if (l.Autore == autore)
                    libriTrovati.Add(l);
            }

            return libriTrovati;
        }

        public int LibriTotali()
        {
            return Libri.Count();
        }
    }
}
