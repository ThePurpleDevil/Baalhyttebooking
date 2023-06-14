using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Baalhyttebooking
{
    public class boernegruppe
    {

        #region
        string _gruppeID; /*Gruppens ID, som skal være unik*/
        string _navn; /*Gruppens navn*/
        string _aldersgruppe; /*Kan antage en af streng-værdierne:"pusling","Tumling","Pilt","Væbner" eller "Seniorvæbner"*/
        int _antalDeltagere; /*Antallet af personer i gruppen*/
        #endregion

        #region Constructor
        public boernegruppe(string gruppeID,string navn,string aldersgruppe,int antalDeltagere)
        { 
            _gruppeID = gruppeID;
            _navn = navn;
            _aldersgruppe = aldersgruppe;
            _antalDeltagere = antalDeltagere;

        }
        #endregion

        #region Properties
        public string gruppeID
        {
            get { return _gruppeID; }
        }
        public string navn
        {
            get { return _navn; }
        }
        public string aldersgruppe
        {
            get { return _aldersgruppe; }
        }
        public int antalDeltagere
        {
            get { return _antalDeltagere; }
        }
        public override string ToString()
        {
            return $"{gruppeID}\nGruppenavn {navn}\ngruppes aldersgruppe {aldersgruppe}\nAntal deltager {antalDeltagere}\n";
        
        }
        #endregion
       
    }
}
