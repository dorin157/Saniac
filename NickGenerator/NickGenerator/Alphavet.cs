using System;
using System.Collections.Generic;
using System.Text;

namespace NickGenerator
{
   class Alphavet
    {
       Random rnd = new Random();
       char[] Golosny = { 'a','e','y','u','i','o'};
       char[] Prigolosny = { 'q', 'w', 'r', 'b', 'n', 'm', 'p', 'z', 'x', 'c', 'd', 'f', 'j', 'k', 'l', 't', 's', 'f'};
       
       public char GetG()
        {
            
            int Aa =rnd.Next(1,Golosny.Length);
            return(Golosny[Aa]);
        }

        public char GetP()
        {

            int a = rnd.Next(1, Prigolosny.Length);
            return (Prigolosny[a]);
        }
    }

}
