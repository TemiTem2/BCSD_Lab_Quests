using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ch12 : MonoBehaviour
{
    private void Awake()
    {
        /*Player player = new Player();
        player.SetCurrentHP(100);
        Debug.Log($"HP:{player.GetCurrentHP()}");
        */
    }
}

/*public class Player
{
    private int CurrentHP;

    public void SetCurrentHP(int hp)//ĸ��ȭ:������������ ���� �����Ҽ� ���� ������ �޼ҵ带 ����� ����,�����ϰ� ��
    {
        CurrentHP = hp;
    }
    public int GetCurrentHP() 
    {  
        return CurrentHP; 
    
    }
}
*/
public class Entity
{
    public string ID;
    protected int currentHP;

    private void Initialize()
    {
        ID = "Noname";
    }

    public void RecoveryHP(int hp)
    {
        currentHP += hp;
    }
}

public class Player : Entity //���:�θ� Ŭ���������� public, protected�� ���ǵ� ������ �޼ҵ带 �ڽ� Ŭ�������� �����Ѱ�ó�� ��� ����
{

    private string ID;
    public Player(string id, int hp)
    {
        base.ID = id;   //���� �̸��� ������ �޼ҵ尡 �θ� �ڽ� Ŭ������ �Ѵ� �����Ҷ�, base Ű���� = �θ� Ŭ����/thisŰ���� = �ڱ� Ŭ������ ������ �޼ҵ忡 ����
        ID = id;
        currentHP = hp;

        RecoveryHP(1000);
    }
}