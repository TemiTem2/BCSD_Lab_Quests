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
public abstract class Entitiy //추상화:자식 클래스에서 구현시켜야 하는 메소드를 만드는것
{
    protected int damage;
    protected int currentHP;
    public abstract void Attack(Entitiy target); //추상 메소드:호출시 하는 행동을 자식클래스에서 정의해야함->강제성
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
    public override void Attack(Entitiy target) //자식 클래스에서 override로 추상 메소드를 다시 정의
    {
        Debug.Log("고블린 공격!");
        target.TakeDamage(damage);
    }

}