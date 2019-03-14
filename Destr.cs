using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class Destr : MonoBehaviour
{

    [Range(0.0f, 10.0f)]
    public float rad;
    public static float StartDelay = 3f; //начальное значение задержки
    public static float Delay = 0f; //обновляемое значение задержки
    public GameObject explosion; //игровой объект
    public GameObject playerExplosion; //игровой объект
    public static int hp = 3;
    GameObject player;
    void Start()
    {
        //GameObject[] list = GameObject.FindGameObjectsWithTag("tg");
    }
    

    void OnCollisionEnter(Collision collision) //исключить землю
    {
        if (collision.gameObject.tag == "tg")
        { 
            hp -= 1;
            Destroy(collision.gameObject);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.Q) && Delay < 0 && other.tag == "tg")
        {
            GameObject[] list = GameObject.FindGameObjectsWithTag("tg");
            int i = list.Length;
            while (--i >= 0)
            {
                GameObject obj = list[i];
                if (Vector3.Distance(obj.transform.position, playerExplosion.transform.position) < rad + 0.5f)//находится ли враг внутри радиуса
                    Destroy(obj.gameObject);
            }
            if (other.gameObject == null)
                Debug.Log("BANan");
            playerExplosion.GetComponent<Renderer>().material.color = Color.black;
            this.RefreshDelay();
        }
    }
    
    void Update()
    {
        if (hp <= 0)
            Destroy(playerExplosion);
        Delay -= Time.deltaTime;
        if (Delay > 0) return;
        playerExplosion.GetComponent<Renderer>().material.color = Color.white;

        player = GameObject.FindWithTag("tg");
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (player)
                Debug.Log("Naiden");
        }

    }

    void RefreshDelay() //обновление задержки
    {
        Delay = StartDelay;
    }
}