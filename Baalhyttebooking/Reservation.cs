using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baalhyttebooking
{
    public class Reservation
    {
        #region
        int _ID;/*Reservationens ID,som skal Være unik*/
        DateTime _tidspunkt; /*Det tidspunkt, hvor man ønsker at reservere hytten.*/
        #endregion

        #region Constructor
        public Reservation(int ID, DateTime tidspunkt )
        {
            _ID = ID;
            _tidspunkt = tidspunkt;                 
        }    
            
        #endregion
        public int ID
        {
            get { return _ID; } 
        }
        public DateTime Tidspunkt
        { 
            get { return _tidspunkt;} 
        }
        public override string ToString() 
        { 
        return $"{ID}\n tidspunkt for Resvervation {Tidspunkt}\n";
        }
    }
}
