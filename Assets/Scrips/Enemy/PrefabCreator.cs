using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabCreator : MonoBehaviour
{
    public GameObject Prefab;
    public Transform Spawn;
    // Start is called before the first frame update
    public void Create() 
    {
        Instantiate(Prefab, Spawn.position, Spawn.rotation);
    }
}
