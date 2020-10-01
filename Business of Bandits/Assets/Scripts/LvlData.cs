using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

// Referenced: 
// https://www.reddit.com/r/Unity3D/comments/60398i/making_a_3d_level_editor_for_unity_game/
// https://answers.unity.com/questions/1300019/how-do-you-save-write-and-load-from-a-file.html

[Serializable]
public class LvlData : ObjData
{

    public GameObject thisobj;
    List<ObjInfo> objInfo;
    class ObjInfo : MonoBehaviour //Managing individual objects
    {
       

        public int objID; //This should be an index.
        public Vector3 position;
        public Vector3 rotation;
        public Vector3 scale;

        int getComp()
        {
            return 0;
        }

        void AddComp(int val)
        {

        }
    }

    public class Save_Load : MonoBehaviour
    {
        void Start()
        {
            SaveFile();
            LoadFile();
        }

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
}
