using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToTargetEuler : MonoBehaviour
{
    public Vector3 LeftEuler;
    public Vector3 RightEuler;
    private Vector3 _targetEuler;
    public float RotationSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(_targetEuler),Time.deltaTime * RotationSpeed);

    }
    public void RotateLeft()
    {
        _targetEuler = LeftEuler;
    }
    public void RotateRight()
    {
        _targetEuler = RightEuler;
    }
}
