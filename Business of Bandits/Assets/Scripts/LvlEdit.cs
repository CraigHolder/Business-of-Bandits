using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class LvlEdit : MonoBehaviour
{
    public LvlData Lvlscript;


    void Start()
    {
        SaveFile();
        LoadFile();
    }
    // Start is called before the first frame update
    public void SaveFile()
    {

        ObjData[] objs = FindObjectsOfType<ObjData>(); //Identifies all objects in space
        LvlData lvl = new LvlData(); //Creates variable for level file

        for (int d = 0; d < objs.Length; d++)
        {
            ObjInfo info = new ObjInfo(); //Creates a save space for the object.
            info.objID = objs[d].objID; //Sets the object's ID to the current for loop space
            info.position = objs[d].transform.position; //Sets the object's position to the current for loop space
            info.rotation = objs[d].transform.eulerAngles; //Sets the object's rotation to the current for loop space
            info.scale = objs[d].transform.localScale; //Sets the object's scale to the current for loop space
            lvl.objInfo.Add(info); // Adds this object to the file.
        }

        string fileLocation = Application.persistentDataPath + "/save.dat";
        FileStream file;

        if (File.Exists(fileLocation))
        {
            file = File.OpenWrite(fileLocation);
        }
        else
        {
            file = File.Create(fileLocation);
        }

        List<ObjInfo> safeData = new List<ObjInfo>(lvl.objInfo);

        BinaryFormatter binFo = new BinaryFormatter();
        binFo.Serialize(file, safeData);
        file.Close();
    }

    public void LoadFile()
    {
        string fileLocation = Application.persistentDataPath + "/save.dat";
        FileStream file;

        if (File.Exists(fileLocation))
        {
            file = File.OpenRead(fileLocation);
        }
        else
        {
            Debug.LogError("File not found");
            return;
        }

        BinaryFormatter binFo = new BinaryFormatter();
        List<ObjInfo> loadData = (List<ObjInfo>)binFo.Deserialize(file);
        file.Close();

        LvlData lvl = new LvlData(); //Creates variable for level file

        for (int d = 0; d < loadData.Count; d++)
        {
            //lvl.objInfo[d].Add(loadData[d]);
            lvl.objInfo[d].objID = loadData[d].objID; //Sets the object's ID to the current for loop space
            lvl.objInfo[d].position = loadData[d].transform.position; //Sets the object's position to the current for loop space
            lvl.objInfo[d].rotation = loadData[d].transform.eulerAngles; //Sets the object's rotation to the current for loop space
            lvl.objInfo[d].scale = loadData[d].transform.localScale; //Sets the object's scale to the current for loop space
        }
    }
}
