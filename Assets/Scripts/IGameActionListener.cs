using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public interface IGameActionListiner<T>
{
    void OnEnable();
    void OnDisable();

    void OnEventRaized(T var);
}
