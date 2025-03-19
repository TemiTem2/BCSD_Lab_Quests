using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ch11 : MonoBehaviour
{
    public Player player01;

    private void Awake()
    {
        player01 = new Player();
        Debug.Log($"{player01.ID}����� �̸�, ���� ü��:{player01.currentHP}");
        player01.TakeDamage(50);
        Debug.Log($"{player01.ID}����� �̸�, ���� ü��:{player01.currentHP}");
    }
}


public class Player
{
    public string ID = "�ƹ���";
    public int currentHP = 100;

    public void TakeDamage(int damage)
    {
        if (currentHP > damage)
        {

            currentHP -= damage;
        }
    }
}