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
            GameObject.Find("Ice Death Block").GetComponent<IceKillBox>().falling = false;
            GameObject.Find("Lava").GetComponent<LavaRise>().rising = true;

            gameObject.SetActive(false);
            //GameObject.Find("Ice Item").SetActive(true);
        }
    }
}