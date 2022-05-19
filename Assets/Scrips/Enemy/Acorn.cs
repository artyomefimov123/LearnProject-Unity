using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acorn : MonoBehaviour
{
    public Vector3 Velocity;
    public float RotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddRelativeForce(Velocity, ForceMode.VelocityChange);
        GetComponent<Rigidbody>().angularVelocity = new Vector3
            (Random.Range(-RotationSpeed, RotationSpeed), 
            Random.Range(-RotationSpeed, RotationSpeed),
            Random.Range(-RotationSpeed, RotationSpeed));
    }

}
