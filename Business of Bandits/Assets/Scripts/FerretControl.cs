using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

//ToDO: add butt jump force
// add boolean switch between back and front control
// add x and z movement

public class FerretControl : MonoBehaviour
{
    public bool b_Front;
    Rigidbody m_Rigidbody;
    public float f_Thrust = 100f;
    public float f_Move = 100f;

    public PlayerInput c_controls;
    private UnityEngine.Vector2 v2_Movement;
    public CapsuleCollider m_LeftLeg;
    public CapsuleCollider m_RightLeg;
    public GameObject m_OtherBody;

    public GameObject TheObj;

    public float Xmovement;
    public float Ymovement;
    public float f_stucktimer = 5;

    public bool b_grounded;

    // Start is called before the first frame update
    void Start()
    {
        //Fetch the Rigidbody from the GameObject with this script attached
        m_Rigidbody = GetComponent<Rigidbody>();
        TheObj = this.gameObject;
    }
    void Awake()
    {
        c_controls = new PlayerInput();
        c_controls.Ferret.Jump.performed += _ => Jump();
    }

    void Jump()
    {
        if(b_grounded == true)
        {
            m_Rigidbody.AddForce(transform.right * f_Thrust);
        }
    }

    private void OnEnable()
    {
        c_controls.Enable();
    }

    private void OnDisable()
    {
        c_controls.Disable();
    }
    void Update()
    {
        if (b_Front == true)
        {
            Xmovement = c_controls.Ferret.MoveV2Forward.ReadValue<float>();
            Ymovement = c_controls.Ferret.MoveV2Right.ReadValue<float>();

            m_Rigidbody.AddForce((transform.up * f_Move * Xmovement) * Time.deltaTime);
            m_Rigidbody.AddForce((transform.forward * f_Move * -Ymovement) * Time.deltaTime);
        }
        else
        {
            Xmovement = c_controls.Ferret.MoveV2Forward.ReadValue<float>();
            Ymovement = c_controls.Ferret.MoveV2Right.ReadValue<float>();

            m_Rigidbody.AddForce((transform.up * f_Move * Xmovement * 5f) * Time.deltaTime);
            m_Rigidbody.AddForce((transform.forward * f_Move * Ymovement * 5f) * Time.deltaTime);
        }
        //if (transform.rotation.eulerAngles.x >= 10f && transform.rotation.eulerAngles.x <= 350f)
        //{
        //    f_stucktimer -= Time.deltaTime;
        //    if (f_stucktimer <= 0)
        //    {
        //        f_stucktimer = 5;
        //        TheObj.transform.eulerAngles = new UnityEngine.Vector3(
        //        TheObj.transform.eulerAngles.x,
        //        TheObj.transform.eulerAngles.y + 180,
        //        TheObj.transform.eulerAngles.z
        //        );
        //    }
        //
        //}

        //Stableize the ferret to prevent getting stuck on back
        //if (b_Front == true)
        //{
        //    if (transform.rotation.eulerAngles.x >= 10f && transform.rotation.eulerAngles.x < 180f)
        //    {
        //        transform.Rotate(-120.0f * Time.deltaTime, 0.0f, 0.0f, Space.Self);
        //        m_Rigidbody.AddForce(transform.right * (f_Thrust * 2) * Time.deltaTime);
        //
        //    }
        //    else if (transform.rotation.eulerAngles.x <= 350f && transform.rotation.eulerAngles.x > 180)
        //    {
        //        transform.Rotate(120.0f * Time.deltaTime, 0.0f, 0.0f, Space.Self);
        //        m_Rigidbody.AddForce(transform.right * (f_Thrust * 2) * Time.deltaTime);
        //
        //    }
        //}
        //else
        //{
        //    if (m_OtherBody.transform.rotation.eulerAngles.x >= 10f && m_OtherBody.transform.rotation.eulerAngles.x < 180f)
        //    {
        //        transform.Rotate(-120.0f * Time.deltaTime, 0.0f, 0.0f, Space.Self);
        //        m_Rigidbody.AddForce(transform.right * (f_Thrust * 2) * Time.deltaTime);
        //
        //    }
        //    else if (m_OtherBody.transform.rotation.eulerAngles.x <= 350f && m_OtherBody.transform.rotation.eulerAngles.x > 180)
        //    {
        //        transform.Rotate(120.0f * Time.deltaTime, 0.0f, 0.0f, Space.Self);
        //        m_Rigidbody.AddForce(transform.right * (f_Thrust * 2) * Time.deltaTime);
        //
        //    }
        //}
    }
}
