using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IMGUI : MonoBehaviour
{
    private IEvent _event;
    private int infFormat;
    [SerializeReference] public List<Information> information;
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
        infFormat = 0;
        foreach(var inform in information)
        {
            GUI.Label(new Rect(10, infFormat * 10 + 10, 180, 40), inform.getInformationName() + ": " + inform.getInformation());
            infFormat += 1;
        }
    }
}
