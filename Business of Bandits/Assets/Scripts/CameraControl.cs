using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public PlayerInput c_controls;
    //public float Xmovement;
    //public float Ymovement;
    private CharacterController c_controller;
    private bool b_jump = false;
    private Vector3 v3_Move;
    public int i_movespeed;
    // Start is called before the first frame update
    void Start()
    {
        c_controller = GetComponent<CharacterController>();
    }

    void Awake()
    {
        c_controls = new PlayerInput();
    }
 
    private void OnEnable()
    {
        c_controls.Enable();
    }

    private void OnDisable()
    {
        c_controls.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        v3_Move.x = -c_controls.Ferret.MoveV2Forward.ReadValue<float>();
        v3_Move.z = -c_controls.Ferret.MoveV2Right.ReadValue<float>();

        if (Input.GetButton("Jump"))
        {
           
            v3_Move.y = 1f;
        }
        else if(Input.GetButton("Fire3"))
        {
            v3_Move.y = -1f;
        }
        else
        {
            v3_Move.y = 0;
        }
        //v3_Move.y -= 9.8f * Time.deltaTime;
        c_controller.Move((v3_Move * i_movespeed) * Time.deltaTime);
    }
}
