using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DataV2 
{
    public int puan;
    public string ad;

    public DataV2(PlayerV2 playerV2,bool yazdinmi)
    {
        if (yazdinmi)
        {
            puan = playerV2.puan;
            ad = playerV2.ad;
        }
        else
        {
            puan = 0;
            ad = "****";

        }
    }

}
