using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptableObject_Event : MonoBehaviour, IEvent
{
    public IntGameAction Event;
    public IntValue amount;
    public void Trigger()
    {
        Event.Trigger(amount.Value);
        Debug.Log("On ScriptableObject_Event");
    }
}
