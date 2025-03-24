using System.Collections;
using System.Collections.ObjectModel;
using UnityEngine;

public class Arrylist : MonoBehaviour
{
    private void Awake()
    {
        ArrayList arraylist = new ArrayList();//arraylist 생성

        Debug.Log(arraylist.Add(10));//요소 추가

        PrintArrayList(arraylist);
        
        arraylist.Insert(1, 100);//원하는 위치에 요소 삽입

        PrintArrayList(arraylist);


        Collection<int> data = new Collection<int>();
        data.Add(1);
        data.Add(2);
        data.Add(3);
        arraylist.AddRange(data);//여러개 요소 한번에 추가
        PrintArrayList(arraylist);

        arraylist.Sort();//정렬
        PrintArrayList(arraylist);

        arraylist.Remove(10);//값에 맞는 요소 삭제
        PrintArrayList(arraylist);

        arraylist.RemoveRange(0,2);//범위 요소 삭제

        PrintArrayList(arraylist);

        arraylist.Clear();//초기화

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
