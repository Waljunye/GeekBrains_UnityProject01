using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class FPSCounter : Information
{
    private int avgFrameRate;
    private float current;
    [SerializeField] private string _infName;
    private void Start()
    {
        current = 0;
        infName = _infName;
    }
    // Update is called once per frame
    void Update()
    {
        current = Time.frameCount / Time.time;
        avgFrameRate = (int)current;
        information = avgFrameRate.ToString();
    }
}
