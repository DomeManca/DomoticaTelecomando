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
        public void setProduttore(string nuovoProduttore)
        {
            produttore = nuovoProduttore;
        }
        public string getProduttore()
        { 
            return produttore; 
        }
        public void setModello(string nuovoModello)
        {
            modello = nuovoModello;
        }
        public string getModello()
        {
            return modello;
        }
        //canale
        public void setCanale(int nuovoCanale)
        {
            canale = nuovoCanale;
        }
        public int getCanale()
        {
            return canale;
        }
        //volume
        public void setVolume(int nuovoVolume)
        {
            volume = nuovoVolume;
        }
        public int getVolume()
        {
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
        public void inverti()
        {
            setStato(!stato);
        }
        //segnale
        public void switchSegnale()
        {
            if (segnale == "Bluetooth")
            {
                setSegnale("Wi-Fi");
            }
            else if (segnale == "Wi-Fi")
            {
                setSegnale("Infrarossi");
            }
            else
            {
                setSegnale("Bluetooth");
            }
        }
        public void setSegnale(string v)
        {
            segnale = v;
        }
        public string getSegnale()
        {
            return segnale;
        }
    }
}
