using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceKillBox : MonoBehaviour
{
    public bool active = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerRestart>().Restart();
        }
    }

    private void Update()
    {
        if (active)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.02f, transform.position.z);
        }
    }


}
