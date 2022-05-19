using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerArmory : MonoBehaviour
{
    public Gun[] Guns;
    public int CurrentIndex;
    void Start()
    {
        TakeGunByIndex(CurrentIndex);
    }

    public void TakeGunByIndex(int GunIndex)
    {
        CurrentIndex = GunIndex;
        for (int i =0; i<Guns.Length;i++)
        {
            if (i == GunIndex)
            {
                Guns[i].Activate();
            }
            else
            {
                Guns[i].Deactivate();
            }
        }
    }
    public void AddBullets(int GunIndex,int NumberofBullets)
    {
        Guns[GunIndex].AddBullets(NumberofBullets);
        TakeGunByIndex(GunIndex);
    }
}
