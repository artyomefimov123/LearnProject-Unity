using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    private float _startedTimeStep;
    // Start is called before the first frame update
    void Start()
    {
        _startedTimeStep = Time.fixedDeltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            Time.timeScale = 0.3f;
        }
        else
        {
            Time.timeScale = 1f;
        }
        Time.fixedDeltaTime = _startedTimeStep * Time.timeScale;
    }
}
