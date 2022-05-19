using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamageOnCollision : MonoBehaviour
{
    // Start is called before the first frame update
    public Enemyhealth Enemyhealth;
    public bool NoAlive;

    // Update is called once per frame
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody)
        {
            if (collision.rigidbody.GetComponent<Bullet>())
            {
                Enemyhealth.TakeDamage(1);
            }
        }
        if (NoAlive == true)
        {
            Enemyhealth.TakeDamage(10000);
        }
    }
}
