using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stack1 : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        Stack stack = new Stack();

        for (int i = 0; i < 5; i++) //stack에 요소 추가
        {
            stack.Push(i);
        }

        Debug.Log($"Queue Count = {stack.Count}");//개수 확인

        Debug.Log($"현재 마지막에 추가된 요소 = {stack.Peek()}");//마지막 요소 확인

        object data = stack.Pop();//마지막 요소 확인 후 삭제
        Debug.Log($"빠져나간 데이터 = {data}");

        Debug.Log($"Queue Count = {stack.Count}");

        stack.Clear();//초기화
        Debug.Log($"Queue Count = {stack.Count}");
    }
}
