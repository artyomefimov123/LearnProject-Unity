using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head : MonoBehaviour
{
    public Transform Target;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        transform.position = Target.position;
    }
}
