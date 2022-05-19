using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public float Speed;
    public float RotationSpeed;
    private Transform _playerTransform;
    // Start is called before the first frame update
    void Start()
    {
        _playerTransform = FindObjectOfType<PlayerMove>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Time.deltaTime * transform.forward * Speed;
        transform.position = new Vector3(transform.position.x, transform.position.y, 0f);
        Vector3 toPlayer = _playerTransform.position - transform.position;
        Quaternion TargetRotation = Quaternion.LookRotation(toPlayer,Vector3.forward);
        transform.rotation = Quaternion.Lerp(transform.rotation, TargetRotation, Time.deltaTime * RotationSpeed);

    }
}
