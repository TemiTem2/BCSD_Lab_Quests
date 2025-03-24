using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hash1 : MonoBehaviour
{
    private void Awake()
    {
        Hashtable hash = new Hashtable();//hashtable ����

        Human human = new Human();//hashtable�� ���� Ŭ���� ��� ����
        Weapon weapon = new Weapon();

        hash["Human"]= human;//��� �߰� - []������ ���

        hash.Add("Weapon",weapon);//��� �߰� add �޼ҵ�
        hash.Add(1, "����");
        hash.Add(1.2f, "�Ǽ�");
        hash.Add("�ȳ��ϼ���", "���ڿ�");

        foreach ( object key in hash.Keys)
        {
            Debug.Log($"hash{key} = {hash[key]}");
        }
        if (hash.ContainsKey("Human")) //Human�� Ű�� ���� ��� ���� Ȯ��
        {
            Debug.Log("Human Ű ����");
        }
        if (hash.ContainsValue(weapon))//weapon�� ������ ���� ��� ���� Ȯ��
        {
            Debug.Log($"{weapon}�� ����");
        }

        Debug.Log(hash.Count);

        hash.Remove("Weapon");//Weapon�� Ű�� ���� ��� ����

        Debug.Log(hash.Count);


        hash.Clear();//hashtable �ʱ�ȭ

        Debug.Log(hash.Count);

    }
}
public class Human { }
public class Weapon { }