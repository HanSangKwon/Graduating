using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Yuch_
{
    public enum RerultYuch
    {
        error = 0,
        DDO = 1,
        GGE = 2 ,
        GER =3 ,
        YUCH = 4 ,
        MOO =5 ,
        BackDDO  =6

    }

    public class Yuch 
    {
        int Rerult = 0;
        public RerultYuch ThrowYuch()
        {
            Rerult = Random.Range(1, 10000);
            if (Rerult >= 1 && Rerult < 1536)        // 15.36%
            {
                return RerultYuch.DDO;
            }
            else if (Rerult >= 1536 && Rerult < 4992)// 34.56%
            {
                return RerultYuch.GGE;
            }
            else if (Rerult >= 4992 && Rerult < 8448)// 34.56%
            {
                return RerultYuch.GER;
            }
            else if (Rerult >= 8448 && Rerult < 9744)// 12.96%
            {
                return RerultYuch.YUCH;
            }
            else if (Rerult >= 9744 && Rerult <= 10000)// 2.56%
            {
                return RerultYuch.MOO;
            }

            return RerultYuch.error;
        }
    }

}