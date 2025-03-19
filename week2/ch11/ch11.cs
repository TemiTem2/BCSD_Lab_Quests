using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ch11 : MonoBehaviour
{
    /*private Player player01;

    private void Awake()
    {
        player01 = new Player();
        Debug.Log($"{player01.ID}����� �̸�, ���� ü��:{player01.currentHP}");
        player01.TakeDamage(50);
        Debug.Log($"{player01.ID}����� �̸�, ���� ü��:{player01.currentHP}");
    }*/
    private Player player01;
    private Player player02;
    private void Awake()
    {
       /* player01 = new Player("������",200);//���� ���� and ���� ����
        player02 = player01;
        player02.ID = "��00";

        Debug.Log($"ID:{player01.ID}");
        Debug.Log($"ID:{player02.ID}");//���� ����:���� ���� ������ ����->�ϳ��� �����ص� �ٸ��ͱ��� ����
       */

        player01 = new Player();

        player02 = player01.DeepCopy();
        player02.ID = "��00";
        Debug.Log($"ID:{player01.ID}");
        Debug.Log($"ID:{player02.ID}");//���� ����:���ο� ���� ����� ������ ����->�������� ����

    }
}


public class Player
{
    public string ID;
    public int currentHP;

    public Player(string id = "�ƹ���", int hp = 100)
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