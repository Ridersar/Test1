using UnityEngine;
using System;

public class ExampleBehaviourScript : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer>().material.color = Color.red;

        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            print("Hello world!");
        }
        void Start()
        {
            print("Hello world!");
        }
    }
}