using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ch12 : MonoBehaviour
{
    private Slime slime;
    private Goblin goblin;
    private void Awake()
    {
        slime = new Slime();
        goblin = new Goblin();
        slime.Attack();
        goblin.Attack();
    }
}
public abstract class Entitiy //�߻�ȭ:�ڽ� Ŭ�������� �������Ѿ� �ϴ� �޼ҵ带 ����°�
{
    protected int damage;
    protected int currentHP;
    public abstract void Attack(Entitiy target); //�߻� �޼ҵ�:ȣ��� �ϴ� �ൿ�� �ڽ�Ŭ�������� �����ؾ���->������
    public void TakeDamage(int damage)
    {
        if (currentHP > damage) 
        {
            currentHP -= damage; 
        }
        else { Debug.Log("DIE"); }
    }
}

public class Goblin : Entitiy
{
    public Goblin(int damage, int hp)
    {
        base.damage = damage;
        currentHP = hp;
    }
    public override void Attack(Entitiy target) //�ڽ� Ŭ�������� override�� �߻� �޼ҵ带 �ٽ� ����
    {
        Debug.Log("��� ����!");
        target.TakeDamage(damage);
    }

}