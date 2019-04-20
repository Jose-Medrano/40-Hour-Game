using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IcePickup : MonoBehaviour
{
    // Should collect ice items on collision.
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameObject.Find("Ice Death Block").transform.position = 
                new Vector3(transform.position.x, other.transform.position.y + 55f, transform.position.z);
            GameObject.Find("Lava").GetComponent<LavaRise>().active = false;
            GameObject.Find("Ice Death Block").GetComponent<IceKillBox>().active = true;

            // Hides all IcePickups, shows all LavaPickups
            gameObject.SetActive(false);
            GameObject.Find("Lava Item").SetActive(true);
        }
    }
}
