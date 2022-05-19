using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bodyrotate : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    public Transform target;
    void Update()
    {
        Vector3 ToTarget = target.position - transform.position;
        Vector3 ToTargetY = new Vector3(0f, 0f, ToTarget.z);
        Quaternion rotation = Quaternion.LookRotation(ToTargetY);
        transform.rotation = rotation;
    }

}

