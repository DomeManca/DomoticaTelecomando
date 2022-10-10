using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecomando
{
    internal class TV
    {
        private string produttore;
        private string modello;
        private int volume;
        private bool stato;
        private int canale;
        private string segnale;

        //produttore e modello
        public string setProduttore(string nuovoproduttore)
        {
            produttore = nuovoproduttore;
            return produttore;
        }
        public string setModello(string ilmodello)
        {
            modello = ilmodello;
            return modello;
        }
        //canale
        public int setCanale(int nuovoCanale)
        {
            canale = nuovoCanale;
            return canale;
        }
        //volume
        public int setVolume(int nuovoVolume)
        {
            volume = nuovoVolume;
            return volume;
        }
        //stato
        public void accendi()
        {
            setStato(true);
        }
        public void spegni()
        {
            setStato(false);
        }
        private void setStato(bool nuovoStato)
        {
            stato = nuovoStato;
        }
        public bool getStato()
        {
            return stato;
        }
        public bool inverti()
        {
            setStato(!stato);
            return stato;
        }
        //segnale
        public string setSegnale()
        {
            if (segnale == "Bluetooth")
            {
                segnale = "Wi-Fi";
            }
            else if (segnale == "Wi-Fi")
            {
                segnale = "Infrarossi";
            }
            else
            {
                segnale = "Bluetooth";
            }
            return segnale;
        }
        public void resetSegnale(string v)
        {
            segnale = v;
        }
    }
}