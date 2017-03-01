using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveLoadData : MonoBehaviour {

    void Awake() {
        DontDestroyOnLoad(this.gameObject);
        LoadData();
    }

    public void SaveData()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/SaveData.dat");
        SaveData saveData = new SaveData();
        saveData._HighScore = PlayerInformation._HighScore;

        bf.Serialize(file, saveData);
        file.Close();
    }

    public void LoadData()
    {
        if (File.Exists(Application.persistentDataPath + "/SaveData.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/SaveData.dat", FileMode.Open);
            SaveData saveData = (SaveData)bf.Deserialize(file);
            PlayerInformation._HighScore = saveData._HighScore;

            file.Close();
        }
    }
}

[System.Serializable]
public class SaveData
{
    public int _HighScore;
}
