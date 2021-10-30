using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IMGUI : MonoBehaviour
{
    private IEvent _event;
    private void Start()
    {
        _event = gameObject.GetComponent<IEvent>();
    }
    public void OnGUI()
    {
        if(GUI.Button(new Rect(20, 40, 180, 40), "Player.Hit()")){
            Debug.Log("Button Pressed");
            _event?.Trigger();
        }
    }
}
