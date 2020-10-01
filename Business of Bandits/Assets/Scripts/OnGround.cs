using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGround : MonoBehaviour
{
    public GameObject m_body;
    private FerretControl s_ctrlscript;
    void OnCollisionEnter(Collision collision)
    {
        s_ctrlscript.b_grounded = true;
    }
    void OnCollisionExit(Collision collision)
    {
        s_ctrlscript.b_grounded = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        s_ctrlscript = m_body.GetComponent<FerretControl>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
