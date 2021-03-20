using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public static class savesystem
{
    public static void savedata(gamemanager gm){
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath+"/player.fun";
        FileStream stream = new FileStream(path,FileMode.Create);
        playerdata data = new playerdata(gm);
        formatter.Serialize(stream,data);
        stream.Close();
    }

    public static playerdata Loadplayer(){
       string path = Application.persistentDataPath +"/player.fun";
        if(File.Exists(path)){
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path,FileMode.Open);
            playerdata data = formatter.Deserialize(stream) as playerdata ;
            stream.Close();
            return data;
        }
        else
        {
            Debug.LogError("save file is not found "+ path);
            return null;
        }
    }
}
