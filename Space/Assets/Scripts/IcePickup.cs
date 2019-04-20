using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IcePickup : MonoBehaviour
{
    // Should "collect" the fire and ice items on collision. (Not finished)
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            GameObject.Find("Ice Death Block").transform.position = 
                new Vector3(transform.position.x, other.transform.position.y + 53f, transform.position.z);
            GameObject.Find("Lava").GetComponent<LavaRise>().active = false;
        }
    }
}
