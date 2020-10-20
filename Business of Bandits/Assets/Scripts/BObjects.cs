using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BObjects : MonoBehaviour
{
    public GameObject obj_Cube;
    public GameObject obj_Sphere;
    public GameObject obj_Cylinder;

    public Factory s_factory;

    
    //Spawns the objects
    public void SpawnCube()
    {
        s_factory.FactorySpawn(obj_Cube);
    }
    public void SpawnSphere()
    {
        s_factory.FactorySpawn(obj_Sphere);
    }
    public void SpawnCylinder()
    {
        s_factory.FactorySpawn(obj_Cylinder);
    }

}
