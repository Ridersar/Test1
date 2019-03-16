using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject target;

    void Start()
    {
        InvokeRepeating("Spawn", 2, 1);
    }
    
    void Spawn()
    {
        float x = Random.Range(-5.0f, 5.0f);
        float y = Random.Range(-5.0f, 5.0f);
        Instantiate(target, new Vector3(x + 100, 5, y + 150), Quaternion.identity);
    }
}
