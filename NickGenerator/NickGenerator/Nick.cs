using System;
using System.Text;

namespace NickGenerator
{
    class Nick
    {
        StringBuilder Generate_Nick()
        {
            StringBuilder rezult = new StringBuilder("");
            Random rnd = new Random();
            Alphavet T = new Alphavet();


            
                for (int i = 0; i < rnd.Next(3, 11); i++)
                {

                if (i % 3 == 0)
                    rezult.Append(T.GetP());
                else
                    rezult.Append(T.GetG());
                }
               
            
            return (rezult);
        }
    }
}
