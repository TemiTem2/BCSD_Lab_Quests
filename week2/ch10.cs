using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UIElements;
using Unity.IO.LowLevel.Unsafe;

public class ch10 : MonoBehaviour
{
    //값에의한전달,참조에 의한 전달
    /* private void Awake()
     {

         int a = 3, b = 4;
         Debug.Log($"a={a}b={b}");
         Swap(a, b);
         Debug.Log($"a={a}b={b}");
         Swap(ref a, ref b);
         Debug.Log($"a={a}b={b}");
         
     }

     public void Swap(ref int num1, ref int num2)
     {
         (num2, num1) = (num1, num2);
     }
     public void Swap(int num1, int num2)
     {
         (num2, num1) = (num1, num2);
     }*/
    /* private void Awake()
     {
         //out활용
         int a = 6, b = 5, result1 = 0, result2 = 0;
         Devide(a, b, out result1, out result2);
         Debug.Log($"몫={result1},나머지={result2}");
     }
     public void Devide(int num1,int num2, out int result1, out int result2)
     {
         result1 = num1 / num2;
         result2 = num1 % num2;
     }*/


    private void Awake()//가변길이 매개변수
    {
        Sum(1, 2);
        Sum(1, 2, 3);
    }
    public void Sum(params int[] nums)
    {
        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }
        Debug.Log($"몫={sum}");
    }
    
}
