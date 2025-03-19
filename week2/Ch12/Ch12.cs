using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ch12 : MonoBehaviour
{
    Goblin goblin;
    
    private void Awake()
    {
        Vector3 position = new Vector3(3f, 4f, 3f);
        goblin.MoveTo(position);
    }
}

interface IMovingEntity
{
    void MoveTo(Vector3 destination);
}

public class Goblin : IMovingEntity
{
    
    public void MoveTo(Vector3 destination) {
        Debug.Log($"{destination}까지 이동");
    }

}