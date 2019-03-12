using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) transform.Translate(transform.forward * 6.0f * Time.deltaTime, Space.World);

        if (Input.GetKey(KeyCode.S)) transform.Translate(transform.forward * -6.0f * Time.deltaTime, Space.World);

        if (Input.GetKey(KeyCode.A)) transform.Translate(transform.right * -6.0f * Time.deltaTime, Space.World);

        if (Input.GetKey(KeyCode.D)) transform.Translate(transform.right * 6.0f * Time.deltaTime, Space.World);

    }
}
