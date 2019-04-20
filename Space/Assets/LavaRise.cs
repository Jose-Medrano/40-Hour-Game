using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaRise : MonoBehaviour
{
    float rise;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rise = 1.5f;
        }
        if (rise > 0)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.1f, transform.position.z);
            rise -= 0.1f;
        }
    }
}
