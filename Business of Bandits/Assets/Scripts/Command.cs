using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


abstract public class Command
{
    virtual public void Execute(Command command, GameObject obj_selected) { }
    public GameObject obj_Controlled = new GameObject();

    public virtual void Undo() { }
    public virtual void Redo() { }

    public static List<Command> L_previouscommands = new List<Command>();
    public static int i_Commandpos = 0;

    public static bool b_undotracker = false;

}

public class RotateXCommand : Command
{
    override public void Execute(Command command, GameObject obj_selected)
    {
        if (b_undotracker == true)
        {
            if ((L_previouscommands.Count + i_Commandpos) < L_previouscommands.Count)
            {

                //Debug.Log(((L_previouscommands.Count + i_Commandpos + 1), (Mathf.Abs(i_Commandpos) - 1)));
                //Debug.Log(L_previouscommands.Count + "BCount");
                //Debug.Log(i_Commandpos + "BPos");
                //Debug.Log((Mathf.Abs(i_Commandpos) - 1) + "Subtraction");
                //Debug.Log((L_previouscommands.Count + i_Commandpos) + "BLess than" + L_previouscommands.Count);
                //L_previouscommands.RemoveRange((L_previouscommands.Count + i_Commandpos + 1), (Mathf.Abs(i_Commandpos) - 1));
                //Debug.Log(L_previouscommands.Count + "ACount");
                //Debug.Log(i_Commandpos + "APos");

                L_previouscommands.Clear();
                i_Commandpos = 0;
                b_undotracker = false;
            }
        }

        obj_Controlled = obj_selected;
        RotateX();
        L_previouscommands.Add(command);
    }

    override public void Redo()
    {
        RotateX();
    }

    override public void Undo()
    {
        obj_Controlled.transform.Rotate(-5, 0, 0);
    }

    void RotateX()
    {
        obj_Controlled.transform.Rotate(5, 0, 0);
    }
}
public class RotateYCommand : Command
{

    override public void Execute(Command command,GameObject obj_selected)
    {
        if (b_undotracker == true)
        {
            if ((L_previouscommands.Count + i_Commandpos) < L_previouscommands.Count)
            {
                L_previouscommands.Clear();
                i_Commandpos = 0;
                b_undotracker = false;
            }
        }
        obj_Controlled = obj_selected;
        RotateY();
        L_previouscommands.Add(command);
    }

    override public void Redo()
    {
        RotateY();
    }

    override public void Undo()
    {
        obj_Controlled.transform.Rotate(0, -5, 0);
    }

    void RotateY()
    {
        obj_Controlled.transform.Rotate(0, 5, 0);
    }
}
public class RotateZCommand : Command
{
    override public void Execute(Command command, GameObject obj_selected)
    {
        if (b_undotracker == true)
        {
            if ((L_previouscommands.Count + i_Commandpos) < L_previouscommands.Count)
            {
                L_previouscommands.Clear();
                i_Commandpos = 0;
                b_undotracker = false;
            }
        }
        obj_Controlled = obj_selected;
        RotateZ();
        L_previouscommands.Add(command);
    }

    override public void Redo()
    {
        RotateZ();
    }

    override public void Undo()
    {
        obj_Controlled.transform.Rotate(0, 0, -5);
    }

    void RotateZ()
    {
        obj_Controlled.transform.Rotate(0, 0, 5);
    }

}

public class IncreaseXCommand : Command
{
    override public void Execute(Command command, GameObject obj_selected)
    {
        if (b_undotracker == true)
        {
            if ((L_previouscommands.Count + i_Commandpos) < L_previouscommands.Count)
            {
                L_previouscommands.Clear();
                i_Commandpos = 0;
                b_undotracker = false;
            }
        }
        obj_Controlled = obj_selected;
        IncreaseX();
        L_previouscommands.Add(command);
    }

    override public void Redo()
    {
        IncreaseX();
    }

    override public void Undo()
    {
        obj_Controlled.transform.Translate(-5, 0, 0);
    }

    void IncreaseX()
    {
        obj_Controlled.transform.Translate(5, 0, 0);
    }

}

public class IncreaseYCommand : Command
{
    override public void Execute(Command command, GameObject obj_selected)
    {
        if (b_undotracker == true)
        {
            if ((L_previouscommands.Count + i_Commandpos) < L_previouscommands.Count)
            {
                L_previouscommands.Clear();
                i_Commandpos = 0;
                b_undotracker = false;
            }
        }
        obj_Controlled = obj_selected;
        IncreaseY();
        L_previouscommands.Add(command);
    }

    override public void Redo()
    {
        IncreaseY();
    }

    override public void Undo()
    {
        obj_Controlled.transform.Translate(0, -5, 0);
    }

    void IncreaseY()
    {
        obj_Controlled.transform.Translate(0, 5, 0);
    }

}

public class IncreaseZCommand : Command
{
    override public void Execute(Command command, GameObject obj_selected)
    {
        if (b_undotracker == true)
        {
            if ((L_previouscommands.Count + i_Commandpos) < L_previouscommands.Count)
            {
                L_previouscommands.Clear();
                i_Commandpos = 0;
                b_undotracker = false;
            }
        }
        obj_Controlled = obj_selected;
        IncreaseZ();
        L_previouscommands.Add(command);
    }

    override public void Redo()
    {
        IncreaseZ();
    }

    override public void Undo()
    {
        obj_Controlled.transform.Translate(0, 0, -5);
    }

    void IncreaseZ()
    {
        obj_Controlled.transform.Translate(0, 0, 5);
    }

}

public class DecreaseXCommand : Command
{
    override public void Execute(Command command, GameObject obj_selected)
    {
        if (b_undotracker == true)
        {
            if ((L_previouscommands.Count + i_Commandpos) < L_previouscommands.Count)
            {
                L_previouscommands.Clear();
                i_Commandpos = 0;
                b_undotracker = false;
            }
        }
        obj_Controlled = obj_selected;
        DecreaseX();
        L_previouscommands.Add(command);
    }

    override public void Redo()
    {
        DecreaseX();
    }

    override public void Undo()
    {
        obj_Controlled.transform.Translate(5, 0, 0);
    }

    void DecreaseX()
    {
        obj_Controlled.transform.Translate(-5, 0, 0);
    }
}
public class DecreaseYCommand : Command
{
    override public void Execute(Command command, GameObject obj_selected)
    {
        if (b_undotracker == true)
        {
            if ((L_previouscommands.Count + i_Commandpos) < L_previouscommands.Count)
            {
                L_previouscommands.Clear();
                i_Commandpos = 0;
                b_undotracker = false;
            }
        }
        obj_Controlled = obj_selected;
        DecreaseY();
        L_previouscommands.Add(command);
    }

    override public void Redo()
    {
        DecreaseY();
    }

    override public void Undo()
    {
        obj_Controlled.transform.Translate(0, 5, 0);
    }

    void DecreaseY()
    {
        obj_Controlled.transform.Translate(0, -5, 0);
    }

}

public class DecreaseZCommand : Command
{
    override public void Execute(Command command, GameObject obj_selected)
    {
        if (b_undotracker == true)
        {
            if ((L_previouscommands.Count + i_Commandpos) < L_previouscommands.Count)
            {
                L_previouscommands.Clear();
                i_Commandpos = 0;
                b_undotracker = false;
            }
        }
        obj_Controlled = obj_selected;
        DecreaseZ();
        L_previouscommands.Add(command);
    }

    override public void Redo()
    {
        DecreaseZ();
    }

    override public void Undo()
    {
        obj_Controlled.transform.Translate(0, 0, 5);
    }

    void DecreaseZ()
    {
        obj_Controlled.transform.Translate(0, 0, -5);
    }

}

public class DeleteCommand : Command
{
    override public void Execute(Command command, GameObject obj_selected)
    {
        if (b_undotracker == true)
        {
            if ((L_previouscommands.Count + i_Commandpos) < L_previouscommands.Count)
            {
                L_previouscommands.Clear();
                i_Commandpos = 0;
                b_undotracker = false;
            }
        }
        obj_Controlled = obj_selected;
        Delete(obj_selected);
        L_previouscommands.Add(command);
    }

    override public void Redo()
    {
        Delete(obj_Controlled);
    }

    override public void Undo()
    {
        obj_Controlled.SetActive(true);
    }

    void Delete(GameObject obj_selected)
    {
        obj_Controlled.SetActive(false);
    }

}
public class UndoCommand : Command
{
    override public void Execute(Command command, GameObject obj_selected)
    {
        //checks to make sure that there are commands in the list and that command pos is not an invalid number
        if(L_previouscommands.Count >= 1 && (L_previouscommands.Count - 1) + i_Commandpos >= 0)
        {
            //gets the command to undo
            Command c_last = L_previouscommands[(L_previouscommands.Count - 1) + i_Commandpos];
            c_last.Undo();
            //moves the position in the list
            i_Commandpos -= 1;
            //triggers the tracker
            b_undotracker = true;

            //L_previouscommands.RemoveAt(L_previouscommands.Count - 1);

        }
    }

    override public void Redo()
    {
        
    }

    override public void Undo()
    {
        
    }

}

public class RedoCommand : Command
{
    override public void Execute(Command command, GameObject obj_selected)
    {
        if (L_previouscommands.Count >= 1 && ((L_previouscommands.Count - 1) + i_Commandpos) < (L_previouscommands.Count - 1))
        {
            i_Commandpos += 1;
            Command c_last = L_previouscommands[(L_previouscommands.Count - 1) + i_Commandpos];
            
            c_last.Redo();
            
            
            //L_previouscommands.RemoveAt(L_previouscommands.Count - 1);

        }
    }

    override public void Redo()
    {

    }

    override public void Undo()
    {

    }

}
