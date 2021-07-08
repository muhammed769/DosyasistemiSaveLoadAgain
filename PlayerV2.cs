using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class PlayerV2 : MonoBehaviour
{
    public int puan;
    public string ad;

    public TextMeshProUGUI gelenPuan;
    public TextMeshProUGUI gelenAd;

    private void Start()
    {
        Load();
    }
    public void Save()
    {

        SaveSystemV2.SavePlayerV2(this);
        Load();

        
    }

    public void Load()
    {
        DataV2 data = SaveSystemV2.LoadPlayerV2(this);

        gelenPuan.text = data.puan.ToString();
        gelenAd.text = data.ad;

        puan = data.puan;
        ad = data.ad;
    }
}
