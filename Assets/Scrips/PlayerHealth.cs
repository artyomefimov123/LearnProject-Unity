using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    public int PHealth = 5;
    public int MaxHealth = 8;
    private bool _invinsible = false;

    public AudioSource AddHealthSound;
    public UiHealth UiHealth;


    public UnityEvent EventOnTakeDamage;

    public void Start()
    {
        UiHealth.Setup(MaxHealth);
        UiHealth.DisplayHealth(PHealth);
    }
    // Update is called once per frame
    public void TakeDamage(int damagevalue)
    {
        if (_invinsible == false)
        {
            PHealth -= damagevalue;
            if (PHealth <= 0)
            {
                PHealth = 0;
                Die();
            }
            _invinsible = true;
            Invoke("StopInvinsible", 1f);
            EventOnTakeDamage.Invoke();
            UiHealth.DisplayHealth(PHealth);
        }
        
    }

    private void StopInvinsible()
    {
        _invinsible = false;
    }
    public void TakeHealth(int healthvalue)
    {
        PHealth += healthvalue;
        AddHealthSound.Play();
        UiHealth.DisplayHealth(PHealth);
        if (PHealth > MaxHealth)
        {
            PHealth = MaxHealth;
            
        }
    }
    public void Die()
    {
        Debug.Log("You Lose");
    }
}
