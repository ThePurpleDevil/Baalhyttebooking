using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Baalhyttebooking
{
    class Reservationer
    {

        int _ID_Resvervationer;/*Reservationens ID,som skal Være unik*/
        public Reservationer(int ID)
        {
            _ID_Resvervationer = ID;
        }
        public int ID
        {
            get { return _ID_Resvervationer; }
        }

    }
}
