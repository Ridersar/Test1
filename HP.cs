using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    //public int hp;

    Text text;

    void Awake()
    {
        text = GetComponent<Text>();

    }

    void Update()
    {
        text.text = "HP: " + Destr.hp;
    }
}
