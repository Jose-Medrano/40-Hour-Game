using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaKillBox : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.position = new Vector3(0, 0, 0);
            transform.position = new Vector3(0, -54, -1);
        }
    }
}
