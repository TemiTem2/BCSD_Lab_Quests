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
public class Entitiy
{
    public virtual void Attack()
    {
        Debug.Log("적을 공격한다"); //메소드 오버라이딩 부모클래스에서 virtual로 메소드 정의
    }
}

public class Goblin : Entitiy
{
    public override void Attack() //자식 클래스에서 override로 메소드를 다시 정의(private로 정의된 메소드는 오버라이딩 불가)
    {
        Debug.Log("고블린 공격!");
    }

}
public class Slime : Entitiy
{
    public override void Attack()
    {
        Debug.Log("슬라임 공격");
    }

}
