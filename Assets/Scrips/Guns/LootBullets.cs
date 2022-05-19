using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootBullets : MonoBehaviour
{
    public int GunIndex;
    public int NumberofBullets;

    private void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody.GetComponent<PlayerArmory>())
        {
            other.attachedRigidbody.GetComponent<PlayerArmory>().AddBullets(GunIndex,NumberofBullets);
            Destroy(gameObject);
        }
    }
}
