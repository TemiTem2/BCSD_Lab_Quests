using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ch12 : MonoBehaviour
{
    private void Awake()
    {
        Player player = new Player();
        player.SetCurrentHP(100);
        Debug.Log($"HP:{player.GetCurrentHP()}");
    }
}

public class Player
{
    private int CurrentHP;

    public void SetCurrentHP(int hp)
    {
        CurrentHP = hp;
    }
    public int GetCurrentHP() 
    {  
        return CurrentHP; 
    
    }
}