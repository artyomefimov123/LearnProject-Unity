using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hen : MonoBehaviour
{
    public Rigidbody RHen;
    private Transform _playertransform;
    public float MaxSpeed = 2f;
    public float TimeToReach = 1f;
    // Start is called before the first frame update
    void Start()
    {
        _playertransform = FindObjectOfType<PlayerMove>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 ToPlayer = (_playertransform.position - transform.position).normalized;
        Vector3 Force = RHen.mass * (ToPlayer * MaxSpeed - RHen.velocity) / TimeToReach;
        RHen.AddForce(Force);
    }
}
