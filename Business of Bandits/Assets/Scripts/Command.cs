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

    // Start is called before the first frame update

}

public class RotateXCommand : Command
{
    override public void Execute(Command command, GameObject obj_selected)
    {
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
        obj_Controlled = obj_selected;
        Delete(obj_Controlled);
        L_previouscommands.Add(command);
    }

    override public void Redo()
    {
        Delete(obj_Controlled);
    }

    override public void Undo()
    {
        GameObject.Instantiate(obj_Controlled);
    }

    void Delete(GameObject obj_selected)
    {
        GameObject.Destroy(obj_Controlled);
    }

}
public class UndoCommand : Command
{
    override public void Execute(Command command, GameObject obj_selected)
    {
        if(L_previouscommands.Count >= 1 && (L_previouscommands.Count - 1) + i_Commandpos >= 0)
        {
            Command c_last = L_previouscommands[(L_previouscommands.Count - 1) + i_Commandpos];
            c_last.Undo();
            i_Commandpos -= 1;

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
