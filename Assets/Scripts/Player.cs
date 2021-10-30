using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, ITakeDamage
{
    [SerializeField] private IntValue healthIntValue;
    public int health;
    private void Start()
    {
        health = healthIntValue.Value;
    }
    private void OnGUI()
    {
        GUI.Label(new Rect(20, 150, 180, 40), "Player Health: " + health.ToString());   
        if(GUI.Button(new Rect(20, 90, 180, 40), "Player.Die()")){
            Die();
        }
    }
    public void Hit(int value)
    {
        Debug.Log("on Player.Hit()");
        health -= value;
        if(health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
