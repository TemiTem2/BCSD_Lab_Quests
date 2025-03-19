using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ch11 : MonoBehaviour
{
    /*private Player player01;

    private void Awake()
    {
        player01 = new Player();
        Debug.Log($"{player01.ID}당신의 이름, 현재 체력:{player01.currentHP}");
        player01.TakeDamage(50);
        Debug.Log($"{player01.ID}당신의 이름, 현재 체력:{player01.currentHP}");
    }*/
    private Player player01;
    private Player player02;
    private void Awake()
    {
       /* player01 = new Player("엘렐레",200);//얕은 복사 and 깊은 복사
        player02 = player01;
        player02.ID = "김00";

        Debug.Log($"ID:{player01.ID}");
        Debug.Log($"ID:{player02.ID}");//얕은 복사:같은 힙에 정보를 저장->하나만 수정해도 다른것까지 수정
       */

        player01 = new Player();

        player02 = player01.DeepCopy();
        player02.ID = "김00";
        Debug.Log($"ID:{player01.ID}");
        Debug.Log($"ID:{player02.ID}");//깊은 복사:새로운 힙을 만들어 정보를 저장->독립적인 변수

    }
}


public class Player
{
    public string ID;
    public int currentHP;

    public Player(string id = "아무개", int hp = 100)
    {
        ID = id;
        currentHP = hp;
    }
    public void TakeDamage(int damage)
    {
        if (currentHP > damage)
        {

            currentHP -= damage;
        }
    }
    public Player DeepCopy()
    {
        Player clone = new Player();
        clone.ID = ID;
        clone.currentHP = currentHP;

        return clone;
    }
}