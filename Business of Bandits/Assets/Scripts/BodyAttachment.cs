using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyAttachment : MonoBehaviour
{
    public GameObject o_body;
    public GameObject TheObj;
    public GameObject TheAttach;

    // Start is called before the first frame update
    void Start()
    {
        //TODO fix the collisions to prevent the front colliding with the rest of the body
        Physics.IgnoreCollision(o_body.GetComponent<Collider>(), TheAttach.GetComponent<Collider>());
    }

    // Update is called once per frame
    void Update()
    {
        TheObj.transform.position = o_body.transform.position;
        
    }
}
