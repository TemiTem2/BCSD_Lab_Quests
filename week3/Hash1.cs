using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hash1 : MonoBehaviour
{
    private void Awake()
    {
        Hashtable hash = new Hashtable();//hashtable 생성

        Human human = new Human();//hashtable에 넣을 클래스 요소 생성
        Weapon weapon = new Weapon();

        hash["Human"]= human;//요소 추가 - []연산자 사용

        hash.Add("Weapon",weapon);//요소 추가 add 메소드
        hash.Add(1, "정수");
        hash.Add(1.2f, "실수");
        hash.Add("안녕하세요", "문자열");

        foreach ( object key in hash.Keys)
        {
            Debug.Log($"hash{key} = {hash[key]}");
        }
        if (hash.ContainsKey("Human")) //Human을 키로 갖는 요소 유무 확인
        {
            Debug.Log("Human 키 존재");
        }
        if (hash.ContainsValue(weapon))//weapon을 값으로 갖는 요소 유무 확인
        {
            Debug.Log($"{weapon}값 존재");
        }

        Debug.Log(hash.Count);

        hash.Remove("Weapon");//Weapon을 키로 갖는 요소 삭제

        Debug.Log(hash.Count);


        hash.Clear();//hashtable 초기화

        Debug.Log(hash.Count);

    }
}
public class Human { }
public class Weapon { }