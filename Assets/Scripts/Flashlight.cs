using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    [SerializeField] private Player Player;
    [SerializeField] private AudioSource audioSource;
    private Light currentLightComponent;
    private void Start()
    {
        currentLightComponent = GetComponent<Light>();
    }
    private void FixedUpdate()
    {
        if(currentLightComponent.enabled != Player.flashlightEnabled)
        {
            PlayAudio();
        }
        currentLightComponent.enabled = Player.flashlightEnabled;
        
    }
    private void PlayAudio()
    {
        audioSource.Play();
    }
}
