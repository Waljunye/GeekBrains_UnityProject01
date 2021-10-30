using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IntGameActionListiner : MonoBehaviour, IGameActionListiner<int>
{
    public IntGameAction GameAction;
    public MyUnityEvent unityEvent;
    public void OnEnable()
    {
        if (GameAction)
        {
            Debug.Log($"Registered Listener {GameAction}");
            GameAction.RegisterListiner(this);
        }
    }

    public void OnDisable()
    {
        GameAction.UnRegisterListiner(this);
    }

    public void OnEventRaized(int var)
    {
        unityEvent.Invoke(var);
        
    }
}
[System.Serializable]
public class MyUnityEvent : UnityEvent<int>
{
}
