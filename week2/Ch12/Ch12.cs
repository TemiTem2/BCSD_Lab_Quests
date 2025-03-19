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
        Debug.Log("���� �����Ѵ�"); //�޼ҵ� �������̵� �θ�Ŭ�������� virtual�� �޼ҵ� ����
    }
}

public class Goblin : Entitiy
{
    public override void Attack() //�ڽ� Ŭ�������� override�� �޼ҵ带 �ٽ� ����(private�� ���ǵ� �޼ҵ�� �������̵� �Ұ�)
    {
        Debug.Log("��� ����!");
    }

}
public class Slime : Entitiy
{
    public override void Attack()
    {
        Debug.Log("������ ����");
    }

}
