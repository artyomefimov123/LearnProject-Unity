using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamageOnTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public Enemyhealth Enemyhealth;
    public bool NoAlive;

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody)
        {
            if (other.attachedRigidbody.GetComponent<Bullet>())
            {
                Enemyhealth.TakeDamage(1);
            }
        }
        if (NoAlive == true)
        {
            if (other.isTrigger == false)
            {
                Enemyhealth.TakeDamage(10000);
            }

     
        }
    }
}
