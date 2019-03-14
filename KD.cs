using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KD : MonoBehaviour
{
    //public int hp;

    Text text;

    void Awake()
    {
        text = GetComponent<Text>();

    }

    void Update()
    {
        if (Destr.Delay >= 0)
            text.text = "KD: " + (int)Destr.Delay;
        else
            text.text = "KD: " + 0;
    }
}
