using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Gyakorlat_Alkalmazott
{
    public class Alkalmazott
    {
        private string _nev;
        private long _fizetes;


        //Getter-Setter Medótus Fizetés
        public void SetFizetes(long fizetes)
        {
            this._fizetes = fizetes;
        }

        public long GetFizetes()
        {
            return _fizetes;
        }

        //Getter-Setter Medótus Név
        public void SetNev(string nev)
        {
            this._nev = nev;
        }

        public string GetNev()
        {
            return _nev;
        }

        public void FizetestNovel(long fizetesNovekmeny)
        {
            _fizetes += fizetesNovekmeny;
        }

        public string AlkalmazottKiir()
        {
            return $"Név: {_nev}; Fizetés: {_fizetes} HUF";
        }

        public bool FizetesHataronBelulVan(int alsohatar, int felsohatar)
        {
            if (_fizetes >= alsohatar && _fizetes <= felsohatar)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool FizetesNagyobbMint(Alkalmazott masikAlkalmazott)
        {
            return _fizetes > masikAlkalmazott._fizetes;
        }
    }
}   
