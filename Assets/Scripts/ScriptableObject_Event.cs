using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptableObject_Event : MonoBehaviour, IEvent
{
    public IntGameAction Event;
    public int value;
    public void Trigger()
    {
        Event.Trigger(value);
        Debug.Log("On ScriptableObject_Event");
    }
}
