using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stack1 : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        Stack stack = new Stack();

        for (int i = 0; i < 5; i++) //stack�� ��� �߰�
        {
            stack.Push(i);
        }

        Debug.Log($"Queue Count = {stack.Count}");//���� Ȯ��

        Debug.Log($"���� �������� �߰��� ��� = {stack.Peek()}");//������ ��� Ȯ��

        object data = stack.Pop();//������ ��� Ȯ�� �� ����
        Debug.Log($"�������� ������ = {data}");

        Debug.Log($"Queue Count = {stack.Count}");

        stack.Clear();//�ʱ�ȭ
        Debug.Log($"Queue Count = {stack.Count}");
    }
}
