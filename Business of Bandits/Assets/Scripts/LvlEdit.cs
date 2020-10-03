using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.InputSystem;

public class LvlEdit : MonoBehaviour
{
    //public LvlData Lvlscript;
    public Camera cam_MainCamera;
    public Transform obj_selected;
    public Renderer r_Selected;
    private bool b_increaseY = false;
    private bool b_decreaseY = false;
    private bool b_increaseX = false;
    private bool b_decreaseX = false;
    private bool b_increaseZ = false;
    private bool b_decreaseZ = false;

    private bool b_RotateX = false;
    private bool b_RotateY = false;
    private bool b_RotateZ = false;

    public GameObject obj_Cube;
    public GameObject obj_Sphere;
    public GameObject obj_Cylinder;
    
    private void Selected()
    {
        if(r_Selected != null)
        {
            r_Selected.material.color = Color.white;
        }
        RaycastHit hit;
        Ray ray = cam_MainCamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            obj_selected = hit.transform;
            r_Selected = obj_selected.GetComponent<Renderer>();
            r_Selected.material.color = Color.green;
        }
    }

    void Update()
    {
        
        if (b_increaseY == true)
        {
            obj_selected.Translate(0, 20 * Time.deltaTime, 0);
        }
        else if (b_decreaseY == true)
        {
            obj_selected.Translate(0, -20 * Time.deltaTime, 0);
        }
        else if (b_increaseX == true)
        {
            obj_selected.Translate(20 * Time.deltaTime, 0, 0);
        }
        else if (b_decreaseX == true)
        {
            obj_selected.Translate(-20 * Time.deltaTime, 0, 0);
        }
        else if (b_increaseZ == true)
        {
            obj_selected.Translate(0, 0, 20 * Time.deltaTime);
        }
        else if (b_decreaseZ == true)
        {
            obj_selected.Translate(0, 0, -20 * Time.deltaTime);
        }
        else if (b_RotateX == true)
        {
            obj_selected.Rotate(10 * Time.deltaTime, 0, 0);
        }
        else if (b_RotateY == true)
        {
            obj_selected.Rotate(0, 10 * Time.deltaTime, 0);
        }
        else if (b_RotateZ == true)
        {
            obj_selected.Rotate(0,0,10 * Time.deltaTime);
        }
        if (Input.GetMouseButtonDown(2))
        {
            Selected();
        }
    }
    //Rotates the selected
    public void RotateX()
    {
        b_RotateX = true;
    }
    public void RotateY()
    {
        b_RotateY = true;
    }
    public void RotateZ()
    {
        b_RotateZ = true;
    }
    //Spawns the objects
    public void SpawnCube()
    {
        Instantiate(obj_Cube, new Vector3(0, 5, 0), Quaternion.identity);
    }
    public void SpawnSphere()
    {
        Instantiate(obj_Sphere, new Vector3(0,5,0), Quaternion.identity);
    }
    public void SpawnCylinder()
    {
        Instantiate(obj_Cylinder, new Vector3(0, 5, 0), Quaternion.identity);
    }

    //deletes currently selected object
    public void Delete()
    {
        Destroy(obj_selected.gameObject);
    }
    //Move the selected
    public void DecreaseY()
    {
        b_decreaseY = true;
    }
    public void IncreaseY()
    {
        b_increaseY = true;
    }
    public void DecreaseX()
    {
        b_decreaseX = true;
    }
    public void IncreaseX()
    {
        b_increaseX = true;
    }
    public void DecreaseZ()
    {
        b_decreaseZ = true;
    }
    public void IncreaseZ()
    {
        b_increaseZ = true;
    }
    public void Stop()
    {
        b_increaseY = false;
        b_decreaseY = false;
        b_increaseX = false;
        b_decreaseX = false;
        b_increaseZ = false;
        b_decreaseZ = false;
        b_RotateX = false;
        b_RotateY = false;
        b_RotateZ = false;
    }

    //void Start()
    //{
    //    SaveFile();
    //    LoadFile();
    //}
    //// Start is called before the first frame update
    //public void SaveFile()
    //{
    //
    //    ObjData[] objs = FindObjectsOfType<ObjData>(); //Identifies all objects in space
    //    LvlData lvl = new LvlData(); //Creates variable for level file
    //
    //    for (int d = 0; d < objs.Length; d++)
    //    {
    //        ObjInfo info = new ObjInfo(); //Creates a save space for the object.
    //        info.objID = objs[d].objID; //Sets the object's ID to the current for loop space
    //        info.position = objs[d].transform.position; //Sets the object's position to the current for loop space
    //        info.rotation = objs[d].transform.eulerAngles; //Sets the object's rotation to the current for loop space
    //        info.scale = objs[d].transform.localScale; //Sets the object's scale to the current for loop space
    //        lvl.objInfo.Add(info); // Adds this object to the file.
    //    }
    //
    //    string fileLocation = Application.persistentDataPath + "/save.dat";
    //    FileStream file;
    //
    //    if (File.Exists(fileLocation))
    //    {
    //        file = File.OpenWrite(fileLocation);
    //    }
    //    else
    //    {
    //        file = File.Create(fileLocation);
    //    }
    //
    //    List<ObjInfo> safeData = new List<ObjInfo>(lvl.objInfo);
    //
    //    BinaryFormatter binFo = new BinaryFormatter();
    //    binFo.Serialize(file, safeData);
    //    file.Close();
    //}
    //
    //public void LoadFile()
    //{
    //    string fileLocation = Application.persistentDataPath + "/save.dat";
    //    FileStream file;
    //
    //    if (File.Exists(fileLocation))
    //    {
    //        file = File.OpenRead(fileLocation);
    //    }
    //    else
    //    {
    //        Debug.LogError("File not found");
    //        return;
    //    }
    //
    //    BinaryFormatter binFo = new BinaryFormatter();
    //    List<ObjInfo> loadData = (List<ObjInfo>)binFo.Deserialize(file);
    //    file.Close();
    //
    //    LvlData lvl = new LvlData(); //Creates variable for level file
    //
    //    for (int d = 0; d < loadData.Count; d++)
    //    {
    //        //lvl.objInfo[d].Add(loadData[d]);
    //        lvl.objInfo[d].objID = loadData[d].objID; //Sets the object's ID to the current for loop space
    //        lvl.objInfo[d].position = loadData[d].transform.position; //Sets the object's position to the current for loop space
    //        lvl.objInfo[d].rotation = loadData[d].transform.eulerAngles; //Sets the object's rotation to the current for loop space
    //        lvl.objInfo[d].scale = loadData[d].transform.localScale; //Sets the object's scale to the current for loop space
    //    }
    //}
}
