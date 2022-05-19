using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Enemyhealth : MonoBehaviour
{
    public int Health = 1;

    public UnityEvent EventOnTakeDamage;
    public UnityEvent EventOnDie;

    public void TakeDamage(int Damagevalue)
    {
        Health -= Damagevalue;
        if (Health <=0)
        {
            Die();
        }
        EventOnTakeDamage.Invoke();
    }
    public void Die()
    {
        Destroy(gameObject);
        EventOnDie.Invoke();
    }
}
