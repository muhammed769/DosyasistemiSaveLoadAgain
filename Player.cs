using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //  Added  the TextMeshPro.
using UnityEngine.UI;



public class Player : MonoBehaviour
{
    public InputField GelenPuanDeger;
    public InputField GelenAdDeger;
    public TextMeshProUGUI puanText;
    public TextMeshProUGUI adText;


    public void Save()
    {
        Verilerim.puan = int.Parse(GelenPuanDeger.text);
        Verilerim.ad = GelenAdDeger.text;

        SaveSystem.SavePlayer();

    }
    public void Load()
    {
        SaveSystem.LoadPlayer();
        puanText.text = Verilerim.puan.ToString();
        adText.text = Verilerim.ad;
    }
    
}
