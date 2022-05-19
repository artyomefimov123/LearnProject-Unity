using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum RopeState
{
    Disabled,
    Fly,
    Activated
}

public class RopeGun : MonoBehaviour
{
    public Hook Hook;
    public Transform Spawn;
    public float Speed;
    public SpringJoint SpringJoint;
    public Transform RopeStart;
    private float _length;
    public RopeState CurrentState;
    public RopeRenderer RopeRenderer;
    public PlayerMove PlayerMove;

    
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Shot();
        }
        if (CurrentState == RopeState.Fly)
        {
            float distance = Vector3.Distance(RopeStart.position, Hook.Rigidbody.position);
            Debug.Log(distance);
            if (distance > 15f)
            {
                
                Hook.gameObject.SetActive(false);
                CurrentState = RopeState.Disabled;
                RopeRenderer.Hide();
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (CurrentState == RopeState.Activated)
            {
                if (PlayerMove.Grounded == false)
                {
                    PlayerMove.Jump();
                }
                    
            }
            DestroySpring();
        }
        if (CurrentState == RopeState.Fly || CurrentState == RopeState.Activated)
        {
            RopeRenderer.Draw(RopeStart.position, Hook.transform.position, _length);
        }
    }
    public void Shot()
    {
        _length = 1f;
        Hook.gameObject.SetActive(true);
        if(SpringJoint)
        {
            Destroy(SpringJoint);
        }
        Hook.Stopfix();
        Hook.transform.position = Spawn.position;
        Hook.transform.rotation = Spawn.rotation;
        Hook.Rigidbody.velocity = Spawn.forward * Speed;
        CurrentState = RopeState.Fly;
        
    }
    public void CreateSpring()
    {
        if (SpringJoint == null)
        {
            SpringJoint = gameObject.AddComponent<SpringJoint>();
            SpringJoint.connectedBody = Hook.Rigidbody;
            SpringJoint.anchor = RopeStart.localPosition;
            SpringJoint.autoConfigureConnectedAnchor = false;
            SpringJoint.connectedAnchor = Vector3.zero;
            SpringJoint.spring = 15f;
            SpringJoint.damper = 10f;

            CurrentState = RopeState.Activated;
        }
    }
    public void DestroySpring()
    {
        if (SpringJoint)
        {
            Destroy(SpringJoint);
            CurrentState = RopeState.Disabled;
            Hook.gameObject.SetActive(false);
            RopeRenderer.Hide();
        }
    }
}
