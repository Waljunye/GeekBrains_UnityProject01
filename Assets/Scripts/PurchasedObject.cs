using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchasedObject : MonoBehaviour
{
    private bool playerIsOnTrigger;
    private Player player;
    private bool builded;
    public IntValue price;
    private void Start()
    {
        playerIsOnTrigger = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<Player>()){

            playerIsOnTrigger = true;
            player = other.gameObject.GetComponent<Player>();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<Player>())
        {

            playerIsOnTrigger = false;
        }
    }
    private void OnGUI()
    {
        if (playerIsOnTrigger)
        {
            if(GUI.Button(new Rect(400, 50, 180, 40), $"Buy {gameObject.name}") && !builded)
            {
                if (player.SpendMoney(price.Value))
                {
                    foreach (Transform child in transform)
                    {
                        if(child.tag != "Nameplate")
                        {
                            child.gameObject.SetActive(true);
                        }
                        else
                        {
                            child.gameObject.SetActive(false);
                        }
                    }
                    builded = true;
                }
                
            }
        }
    }
}
