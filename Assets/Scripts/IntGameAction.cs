using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New IntGameAction", menuName = "Create IntGameAction", order = 2)]
public class IntGameAction : GameAction<int>
{
    public void Trigger(int num)
    {
        Debug.Log($"Triggered Event. Props: num - {num}");
        InvokeAction(num);
    }
}
