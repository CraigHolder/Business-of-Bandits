using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine
{
    public enum States
    {
        S_Rotating,
        S_Moving,
        S_Nothing
    }

   
    public States e_currstate = States.S_Nothing;

    private static StateMachine s_Instance;
    public static StateMachine Instance()
    {
        if (s_Instance == null)
        {
            s_Instance = new StateMachine();
        }
        return s_Instance;
    }
}
