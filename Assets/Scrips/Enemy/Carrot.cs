using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrot : MonoBehaviour
{
    public float Speed;
    public Rigidbody Rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.identity;
        Transform _playerTransform = FindObjectOfType<PlayerHealth>().transform;
        Vector3 ToPlayer = (_playerTransform.position - transform.position).normalized;
        Rigidbody.velocity = Speed * ToPlayer;
    }

    // Update is called once per frame
}
