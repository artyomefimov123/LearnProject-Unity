using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventArray : MonoBehaviour
{
    public UnityEvent[] Event;
    public void CreateEvent(int EventIndex)
    {
        Event[EventIndex].Invoke();
    }
}
