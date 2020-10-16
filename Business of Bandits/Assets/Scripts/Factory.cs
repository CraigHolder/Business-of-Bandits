using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void FactorySpawn(GameObject obj_blueprint)
    {
        Instantiate(obj_blueprint, new Vector3(0, 5, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
