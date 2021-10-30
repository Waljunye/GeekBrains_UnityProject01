using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAction<T> : ScriptableObject
{
    private List<IGameActionListiner<T>> Listeners = new List<IGameActionListiner<T>>();
    public void InvokeAction(T m_num)
    {
        Debug.Log($"Invoked Action {Listeners.Count}");
        for (int i = Listeners.Count - 1; i >= 0; i--)
        {
            Debug.Log($"Raized Event on {Listeners[i]}");
            Listeners[i].OnEventRaized(m_num);
        }
        
    }
    public void RegisterListiner(IGameActionListiner<T> listiners)
    {
        if(!Listeners.Contains(listiners))
        {
            Listeners.Add(listiners);
        }
        else
        {
            Debug.Log($"{listiners} alredy contains in {Listeners}");
        }
    }
    public void UnRegisterListiner(IGameActionListiner<T> listiners)
    {
        if (Listeners.Contains(listiners)){
            Listeners.Remove(listiners);
        }
        else
        {
            Debug.Log($"{listiners} not contained in {Listeners}");
        }
    }

}
