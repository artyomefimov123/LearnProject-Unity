using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointer : MonoBehaviour
{
    public Transform Aim;
    public Camera PlayerCamera;
    public Transform Body;
    float _yEuler;
    // Start is called before the first frame update

    // Update is called once per frame
    void LateUpdate()
    {
        Ray ray = PlayerCamera.ScreenPointToRay(Input.mousePosition);
        Plane plane = new Plane(-Vector3.forward, Vector3.zero);
        float distance;
        plane.Raycast(ray, out distance);
        Vector3 point = ray.GetPoint(distance);
        Aim.position = point;
        Vector3 Toaim = Aim.position - transform.position;
        transform.rotation = Quaternion.LookRotation(Toaim);

        if (Toaim.x < 0)
        {
            _yEuler = Mathf.Lerp(_yEuler, 45f, Time.deltaTime * 10f);
                }
        else
        {
            _yEuler = Mathf.Lerp(_yEuler, -45f, Time.deltaTime * 10f);
        }
        Body.localEulerAngles = new Vector3(0f, _yEuler, 0f);
    }
}
