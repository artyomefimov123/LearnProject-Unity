using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hook : MonoBehaviour
{
    private FixedJoint _fixedjoint;
    public Rigidbody Rigidbody;
    public Collider Collider;
    public Collider PlayerCollider;
    public RopeGun RopeGun;
    private void Start()
    {
        Physics.IgnoreCollision(Collider, PlayerCollider);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (_fixedjoint == null)
        {
            _fixedjoint = gameObject.AddComponent<FixedJoint>();
            if (collision.rigidbody)
        {
            _fixedjoint.connectedBody = collision.rigidbody;
        }
        }
        
        RopeGun.CreateSpring();
    }
    public void Stopfix()
    {
        if (_fixedjoint)
        {
            Destroy(_fixedjoint);
        }
    }
}
