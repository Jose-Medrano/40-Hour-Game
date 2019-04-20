using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaPickup : MonoBehaviour
{
    // Should collect lava items on collision.
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameObject.Find("Ice Death Block").transform.position =
                new Vector3(transform.position.x, other.transform.position.y + 503f, transform.position.z);
            GameObject.Find("Lava").GetComponent<LavaRise>().active = true;

            gameObject.SetActive(false);
            GameObject.Find("Ice Item").SetActive(true);
        }
    }
}