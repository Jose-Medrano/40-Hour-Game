using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowing : MonoBehaviour
{
    Transform target;
    Vector3 velocity;
    float smoothTime = 10f;
    Vector3 offset;
    
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Player").transform;
        offset = transform.position - target.position;   
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + offset;    
    }
}
