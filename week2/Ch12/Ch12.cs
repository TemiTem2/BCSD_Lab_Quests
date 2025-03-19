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

    public void SetCurrentHP(int hp)//캡슐화:정보은닉으로 인해 접근할수 없는 정보를 메소드를 사용해 수정,접근하게 함
    {
        CurrentHP = hp;
    }
    public int GetCurrentHP() 
    {  
        return CurrentHP; 
    
    }
}
*/
/*public class Entity
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

public class Player : Entity //상속:부모 클래스에서의 public, protected로 정의된 변수와 메소드를 자식 클래스에서 정의한것처럼 사용 가능
{

    private string ID;
    public Player(string id, int hp)
    {
        base.ID = id;   //같은 이름의 변수나 메소드가 부모 자식 클래스에 둘다 존재할때, base 키워드 = 부모 클래스/this키워드 = 자기 클래스의 변수나 메소드에 접근
        ID = id;
        currentHP = hp;

        RecoveryHP(1000);
    }
}*/
public class Entitiy
{
    public void Attack()
    {
        Debug.Log("적을 공격한다");
    }
    public void Heal()
    {
        Debug.Log("체력을 회복한다");
    }
}

public class Goblin : Entitiy
{
    public void Avoid()
    {
        Debug.Log("도망가자!");
    }

    public void Heal()
    {
        Debug.Log("고블린 쳬력증가");
    }
}
//private Entitiy entity = new Entitiy();//사용가는맴버 : Attack(), Heal()

//private Goblin Goblin = new Goblin();//사용가는맴버 : Attack(), Avoid(), Heal() <-Goblin에 정의된 Heal()
//자식 클래스 참조 변수 + 자식 클래스 개채 -> 자식클래스 메소드 출력

//private Entitiy entity = new Goblin();//사용가는맴버 : Attack(), Heal() <-Entity에 정의된 Heal()
//부모 클래스 참조 변수 + 자식 클래스 개채 -> 부모 클래스 메소드 출력