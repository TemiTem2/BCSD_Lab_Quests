using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Queue1 : MonoBehaviour
{
    private void Awake()
    {
        Queue queue = new Queue();

        for (int i = 0; i < 5; i++) //Queue�� ��� �߰�
        {
            queue.Enqueue(i);
        }

        Debug.Log($"Queue Count = {queue.Count}");//���� Ȯ��

        Debug.Log($"���� 0��° ��� = {queue.Peek()}");//ù���� ��� Ȯ��

        object data = queue.Dequeue();//ù��° ��� Ȯ�� �� ����
        Debug.Log($"�������� ������ = {data}");

        Debug.Log($"Queue Count = {queue.Count}");

       queue.Clear();//�ʱ�ȭ
       Debug.Log($"Queue Count = {queue.Count}");
    }
}
