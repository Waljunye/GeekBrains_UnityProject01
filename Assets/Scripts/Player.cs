using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, ITakeDamage
{
    [SerializeField] private IntValue healthIntValue;
    private int health;
    [SerializeField] private IntValue moneyAmountIntValue;
    private int moneyAmount;
    private void Start()
    {
        moneyAmount = moneyAmountIntValue.Value;
        health = healthIntValue.Value;
    }
    public int getMoneyAmount()
    {
        return moneyAmount;
    }
    private void OnGUI()
    {
        GUI.Label(new Rect(20, 150, 180, 40), "Player Health: " + health.ToString());   
        GUI.Label(new Rect(20, 180, 180, 40), "Player Money: " + moneyAmount.ToString());   
        if(GUI.Button(new Rect(20, 90, 180, 40), "Player.Die()")){
            Die();
        }
    }
    public bool SpendMoney(int amount)
    {
        if(moneyAmount >= amount)
        {
            Debug.Log(moneyAmount);
            moneyAmount -= amount;
            Debug.Log(moneyAmount);
            return true;
        }
        else
        {
            Debug.Log("$$$Not enought money$$$");
            return false;
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
