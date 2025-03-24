using System.Collections;
using System.Collections.ObjectModel;
using UnityEngine;

public class Arrylist : MonoBehaviour
{
    private void Awake()
    {
        ArrayList arraylist = new ArrayList();//arraylist ����

        Debug.Log(arraylist.Add(10));//��� �߰�

        PrintArrayList(arraylist);
        
        arraylist.Insert(1, 100);//���ϴ� ��ġ�� ��� ����

        PrintArrayList(arraylist);


        Collection<int> data = new Collection<int>();
        data.Add(1);
        data.Add(2);
        data.Add(3);
        arraylist.AddRange(data);//������ ��� �ѹ��� �߰�
        PrintArrayList(arraylist);

        arraylist.Sort();//����
        PrintArrayList(arraylist);

        arraylist.Remove(10);//���� �´� ��� ����
        PrintArrayList(arraylist);

        arraylist.RemoveRange(0,2);//���� ��� ����

        PrintArrayList(arraylist);

        arraylist.Clear();//�ʱ�ȭ

        Debug.Log(arraylist.Count);
    }
    public void PrintArrayList(ArrayList list)
    {
        Debug.Log("=========");

        for (int i = 0; i < list.Count; i++)
        {

            Debug.Log($"list[{i}] = {list[i]}");
        }
    }
}
