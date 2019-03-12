using UnityEngine;
using System;
using System.Collections;

public class Destr : MonoBehaviour
{

    [Range(0.0f, 10.0f)]
    public float rad;
    float StartDelay = 3f; //начальное значение задержки
    float Delay = 0f; //обновляемое значение задержки
    public GameObject explosion; //игровой объект
    public GameObject playerExplosion; //игровой объект
    void Start()
    {
        //StartCoroutine(Example());
        //this.Delay = this.StartDelay;
    }

    //IEnumerator Reload()
    //{
    //    playerExplosion.GetComponent<Renderer>().material.color = Color.red;
    //    yield return new WaitForSeconds(3);
    //    playerExplosion.GetComponent<Renderer>().material.color = Color.white;
    //}

    void OnTriggerStay(Collider other)
    {
        //exp.isTrigger = false;
        if (Input.GetKeyDown(KeyCode.Q) && this.Delay < 0 && other.tag == "tg")
        {
            GameObject[] list = GameObject.FindGameObjectsWithTag("tg");
            int i = list.Length;
            while (--i >= 0)
            {
                GameObject obj = list[i];
                if (Vector3.Distance(obj.transform.position, playerExplosion.transform.position) < rad + 0.5f)//находится ли враг внутри радиуса
                    Destroy(obj.gameObject);
            }

            //Destroy(explosion);

            //Destroy(other.gameObject);
            if (other.gameObject == null)
                Debug.Log("BANan");
            //StartCoroutine(Reload());
            //System.Threading.Thread.Sleep(5000); //задержка все системы
            //new WaitForSeconds(3);
            playerExplosion.GetComponent<Renderer>().material.color = Color.black;
            Debug.Log("BAN");
            this.RefreshDelay();
        }
    }

    GameObject player;
    void Update()
    {
        this.Delay -= Time.deltaTime;
        if (this.Delay > 0) return;
        //Debug.Log("Tick!");
        playerExplosion.GetComponent<Renderer>().material.color = Color.white;
        //this.RefreshDelay();

        player = GameObject.FindWithTag("tg");
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (player)
                Debug.Log("Naiden");
        }

    }

    void RefreshDelay() //обновление задержки
    {
        this.Delay = this.StartDelay;
    }
}