using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizioBiblioteca
{
    class Libro
    {
        private string _autore;
        private string _titolo;
        private int _annoPubblicazione;
        private string _editore;
        private int _nPagine;

        public string Autore
        {
            get => _autore;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("inserire autore valido");

                _autore = value;
            }
        }

        public string Titolo
        {
            get => _titolo;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("inserire titolo valido");

                _titolo = value;
            }
        }

        public int AnnoPubblicazione
        {
            get => _annoPubblicazione;
            set
            {
                if (value<0)
                    throw new Exception("inserire anno di pubblicazione valido");

                _annoPubblicazione = value;
            }
        }

        public string Editore
        {
            get => _editore;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("inserire editore valido");

                _editore = value;
            }
        }

        public int NumeroPagine
        {
            get => _nPagine;
            set
            {
                if (value<0)
                    throw new Exception("inserire numero pagine valido");

                _nPagine = value;
            }
        }

        public Libro(string autore, string titolo, int annoPubb, string editore, int nPag)
        {
            Autore = autore;
            Titolo = titolo;
            AnnoPubblicazione = annoPubb;
            Editore = editore;
            NumeroPagine = nPag;
        }

        public override string ToString()
        {
            return "Autore: " + Autore + ", Titolo: " + Titolo + ", Anno Pubblicazione: " + AnnoPubblicazione + ", Editore: " + Editore + ", Numero Pagine: " + NumeroPagine;
        }
    }
}
