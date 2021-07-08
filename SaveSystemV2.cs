using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


public class SaveSystemV2 : MonoBehaviour
{
   
    public static void SavePlayerV2(PlayerV2 playerV2)
    {
      

        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream("PlayerV2.bin", FileMode.Create);

        DataV2 datav2 = new DataV2(playerV2, true);
        formatter.Serialize(stream, datav2);
        stream.Close();
    }

    public static DataV2 LoadPlayerV2(PlayerV2 playerV2)
    {
        string FileName = "PlayerV2.bin";

        if (!File.Exists(FileName))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream("PlayerV2.bin", FileMode.Create);

            DataV2 datav2 = new DataV2(playerV2, false);
            formatter.Serialize(stream, datav2);

            stream.Close();
        }

        if (File.Exists(FileName))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(FileName, FileMode.Open);

            DataV2 datav2 = formatter.Deserialize(stream) as DataV2;
         
            stream.Close();
            return datav2;
        }
        else
        {
            Debug.Log("Dosya yok ! ");
            return null;
        }
    }


}
