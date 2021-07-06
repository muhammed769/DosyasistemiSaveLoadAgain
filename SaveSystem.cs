using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO; // Start and Exit To benefit.
using System.Runtime.Serialization.Formatters.Binary; // Save data in binary format.

public  static class SaveSystem 
{

    public static void SavePlayer()
    {


        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream("oyuncum.bin", FileMode.Create);

        formatter.Serialize(stream, Verilerim.ad);
        formatter.Serialize(stream, Verilerim.puan);

        stream.Close();
    }

    public static void LoadPlayer()
    {
       string dosyaAdi =  "oyumcum.bin";

        if (File.Exists(dosyaAdi))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(dosyaAdi, FileMode.Open);

            Verilerim.puan = (int) formatter.Deserialize(stream);
            Verilerim.ad = (string)formatter.Deserialize(stream);

            stream.Close();
        }

        else
        {
            Debug.Log("Dosya YOK ! ! !");
        }
    }
    
}
