using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Queue1 : MonoBehaviour
{
    private void Awake()
    {
        Queue queue = new Queue();

        for (int i = 0; i < 5; i++) //Queue에 요소 추가
        {
            queue.Enqueue(i);
        }

        Debug.Log($"Queue Count = {queue.Count}");//개수 확인

        Debug.Log($"현재 0번째 요소 = {queue.Peek()}");//첫번쨰 요소 확인

        object data = queue.Dequeue();//첫번째 요소 확인 후 삭제
        Debug.Log($"빠져나간 데이터 = {data}");

        Debug.Log($"Queue Count = {queue.Count}");

       queue.Clear();//초기화
       Debug.Log($"Queue Count = {queue.Count}");
    }
}
