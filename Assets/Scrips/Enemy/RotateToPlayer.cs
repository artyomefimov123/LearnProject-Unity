using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToPlayer : MonoBehaviour
{
    public Vector3 RightEuler;
    public Vector3 LeftEuler;
    private Vector3 _targerEuler;
    private Transform _playerTransform;
    public float RotateSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        _playerTransform = FindObjectOfType<PlayerMove>().transform;
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > _playerTransform.position.x)
        {
            _targerEuler = LeftEuler;
        }
        else
        {
            _targerEuler = RightEuler;
        }
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(_targerEuler),Time.deltaTime * RotateSpeed);
    }
}
