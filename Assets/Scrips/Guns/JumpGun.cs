using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpGun : MonoBehaviour
{
    public Rigidbody Rigidbody;
    public float Speed;
    public Transform Spawn;
    public Pistol Pistol;
    private float CurrentCharge;
    public float FullCharge;
    private bool _isCharged;
    public ChangeIcon ChangeIcon;


    void Update()
    {
       
        if (_isCharged)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                Rigidbody.AddForce(-Spawn.forward * Speed, ForceMode.VelocityChange);
                Pistol.Shot();
                CurrentCharge = 0;
                _isCharged = false;
                ChangeIcon.StartCharge();

            }
        }
        else
        {
            CurrentCharge += Time.unscaledDeltaTime;
            ChangeIcon.ShowCharge(CurrentCharge, FullCharge);
            if (CurrentCharge > FullCharge)
            {
                _isCharged = true;
                ChangeIcon.StopCharge();
            }
        }
        
    }
}
