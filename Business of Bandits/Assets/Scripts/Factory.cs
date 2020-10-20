using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour
{

    public void FactorySpawn(GameObject obj_blueprint)
    {
        Instantiate(obj_blueprint, new Vector3(0, 5, 0), Quaternion.identity);
    }

    
}
