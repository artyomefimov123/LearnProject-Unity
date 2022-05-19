using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Walker : MonoBehaviour
{

    public enum Direction
    {
        Left,
        Right
    }
    public Transform LeftTarget;
    public Transform RightTarget;
    public float StopTime;
    public float Speed;
    private bool _isStopped;
    public Direction CurrentDirection;
    public UnityEvent EventOnLeft;
    public UnityEvent EventOnRight;
    public Transform RayStart;
    void Start()
    {
        LeftTarget.parent = null;
        RightTarget.parent = null;
    }

   
    void Update()
    {
        if (_isStopped == true)
        {
            return;
        }
        if (CurrentDirection == Direction.Left)
        {
            
            transform.position -= new Vector3(Time.deltaTime * Speed, 0f, 0f);
            if (transform.position.x < LeftTarget.position.x)
            {
                CurrentDirection = Direction.Right;
                _isStopped = true;
                Invoke("ContinueWalk", StopTime);
                EventOnLeft.Invoke();
            }
        }
        else
        {
            
            transform.position += new Vector3(Time.deltaTime * Speed, 0f, 0f);
            if (transform.position.x > RightTarget.position.x)
            {
                CurrentDirection = Direction.Left;
                _isStopped = true;
                Invoke("ContinueWalk", StopTime);
                EventOnRight.Invoke();
            }
        }
        RaycastHit hit;
        if(Physics.Raycast(RayStart.position,Vector3.down,out hit))
        {
            transform.position = hit.point;
        }
    }
    void ContinueWalk()
    {
        _isStopped = false;
    }
}
