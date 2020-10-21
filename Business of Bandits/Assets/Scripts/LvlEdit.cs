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
    public Transform obj_backup;
    public Renderer r_Selected;

    

    public string str_previous;
    public float f_previousval;

    //public Command s_command;

    //private bool b_increaseY = false;
    //private bool b_decreaseY = false;
    //private bool b_increaseX = false;
    //private bool b_decreaseX = false;
    //private bool b_increaseZ = false;
    //private bool b_decreaseZ = false;

    //private bool b_RotateX = false;
    //private bool b_RotateY = false;
    //private bool b_RotateZ = false;

    private Command c_rotX;
    private Command c_rotY;
    private Command c_rotZ;

    private Command c_del;

    private Command c_incX;
    private Command c_incY;
    private Command c_incZ;

    private Command c_decX;
    private Command c_decY;
    private Command c_decZ;

    private Command c_undo;
    private Command c_redo;

    void Start()
    {
        c_rotX = new RotateXCommand();
        c_rotY = new RotateYCommand();
        c_rotZ = new RotateZCommand();

        c_del = new DeleteCommand();

        c_incX = new IncreaseXCommand();
        c_incY = new IncreaseYCommand();
        c_incZ = new IncreaseZCommand();

        c_decX = new DecreaseXCommand();
        c_decY = new DecreaseYCommand();
        c_decZ = new DecreaseZCommand();


        c_undo = new UndoCommand();
        c_redo = new RedoCommand();
    }


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
        if (r_Selected != null)
        {
            switch (StateMachine.Instance().e_currstate)
            {
                case StateMachine.States.S_Rotating:
                    r_Selected.material.color = Color.cyan;
                    break;
                case StateMachine.States.S_Moving:
                    r_Selected.material.color = Color.blue;
                    break;
                case StateMachine.States.S_Nothing:
                    r_Selected.material.color = Color.green;
                    break;

            }
        }
        if (Input.GetMouseButtonDown(2))
        {
            Selected();
        }
    }

    public void Undo()
    {
        c_undo.Execute(c_undo, obj_selected.gameObject);
    }

    public void Redo()
    {
        c_redo.Execute(c_redo, obj_selected.gameObject);
    }

    //Rotates the selected
    public void RotateX()
    {
        StateMachine.Instance().e_currstate = StateMachine.States.S_Rotating;
        c_rotX.Execute(c_rotX, obj_selected.gameObject);
        //b_RotateX = true;
    }
    public void RotateY()
    {
        StateMachine.Instance().e_currstate = StateMachine.States.S_Rotating;
        c_rotY.Execute(c_rotY, obj_selected.gameObject);
        //b_RotateY = true;
    }
    public void RotateZ()
    {
        StateMachine.Instance().e_currstate = StateMachine.States.S_Rotating;
        c_rotZ.Execute(c_rotZ, obj_selected.gameObject);
        //b_RotateZ = true;
    }

    //deletes currently selected object
    public void Delete()
    {
        c_del.Execute(c_del, obj_selected.gameObject);
    }



    //Move the selected
    public void DecreaseY()
    {
        StateMachine.Instance().e_currstate = StateMachine.States.S_Moving;
        c_decY.Execute(c_decY, obj_selected.gameObject);
        //b_decreaseY = true;
    }
    public void IncreaseY()
    {
        StateMachine.Instance().e_currstate = StateMachine.States.S_Moving;
        c_incY.Execute(c_incY, obj_selected.gameObject);
        //b_increaseY = true;
    }
    public void DecreaseX()
    {
        StateMachine.Instance().e_currstate = StateMachine.States.S_Moving;
        c_decX.Execute(c_decX, obj_selected.gameObject);
        //b_decreaseX = true;
    }
    public void IncreaseX()
    {
        StateMachine.Instance().e_currstate = StateMachine.States.S_Moving;
        c_incX.Execute(c_incX, obj_selected.gameObject);
        //b_increaseX = true;
    }
    public void DecreaseZ()
    {
        StateMachine.Instance().e_currstate = StateMachine.States.S_Moving;
        c_decZ.Execute(c_decZ, obj_selected.gameObject);
        //b_decreaseZ = true;
    }
    public void IncreaseZ()
    {
        StateMachine.Instance().e_currstate = StateMachine.States.S_Moving;
        c_incZ.Execute(c_incZ, obj_selected.gameObject);
        //b_increaseZ = true;
    }
    public void Stop()
    {
        StateMachine.Instance().e_currstate = StateMachine.States.S_Nothing;
        //b_increaseY = false;
        //b_decreaseY = false;
        //b_increaseX = false;
        //b_decreaseX = false;
        //b_increaseZ = false;
        //b_decreaseZ = false;
        //b_RotateX = false;
        //b_RotateY = false;
        //b_RotateZ = false;
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
