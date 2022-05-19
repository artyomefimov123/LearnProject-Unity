using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody Rigidbody;
    public bool Grounded;
    public float Playerspeed;
    public float Friction;
    public float Jumpspeed;
    public float Maxspeed;
    public Transform Transcollider;

   
    void Update()
    {
        
        if (Input.GetKey(KeyCode.LeftControl) || Grounded == false)
        {
            Transcollider.transform.localScale = Vector3.Lerp(Transcollider.transform.localScale, new Vector3(1f, 0.5f, 1f), Time.deltaTime * 5f);
        }
        else
        {
            Transcollider.transform.localScale = Vector3.Lerp(Transcollider.transform.localScale, new Vector3(1f, 1f, 1f), Time.deltaTime * 5f);

        }
        if (Input.GetKeyDown(KeyCode.Space))

        {
            if (Grounded)
                Jump();
            
        }

    
    }
    public void Jump()
    {
        
        
            Rigidbody.AddForce(0, Jumpspeed, 0, ForceMode.VelocityChange);

        
    }
    void FixedUpdate()
    {
  
        
        Rigidbody.AddForce(0, 0,0, ForceMode.VelocityChange);
        float multiplier = 1f;
        if (Grounded == false)
        {
            multiplier = 0.3f;
            if (Rigidbody.velocity.x > Maxspeed && Input.GetAxis("Horizontal") > 0)
            {
                multiplier = 0;
            }
            if (Rigidbody.velocity.x < -Maxspeed && Input.GetAxis("Horizontal") < 0)
            {
                multiplier = 0;
            }
        }
        
        Rigidbody.AddForce(Input.GetAxis("Horizontal") * Playerspeed*multiplier, 0, 0,ForceMode.VelocityChange);
        if (Grounded)
        {
            Rigidbody.AddForce(-Rigidbody.velocity.x * Friction, 0, 0);
        }

    }
    private void OnCollisionExit(Collision collision)
    {
        Grounded = false;
    }
    private void OnCollisionStay(Collision collision)
    {
        for (int i = 0; i < collision.contactCount; i++)
        {
            float angle = Vector3.Angle(collision.contacts[i].normal, Vector3.up);
            if (angle < 45f)
            {
                Grounded = true;
            }

        }
    }
}
