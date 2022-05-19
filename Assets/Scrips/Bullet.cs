using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject EffectPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 4f);
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(EffectPrefab, transform.position, transform.rotation);
        Destroy(gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        Instantiate(EffectPrefab, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
