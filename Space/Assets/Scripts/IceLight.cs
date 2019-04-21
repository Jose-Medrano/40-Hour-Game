using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceLight : MonoBehaviour {

	Transform targetX;
	Transform targetY;
	float offset = 17f;
	
	void Awake() {
		targetX = GameObject.Find("Player").transform;
		targetY = GameObject.Find("Ice Death Block").transform;
	}

	void Update () {
		transform.position = new Vector3(targetX.position.x, targetY.position.y + offset, transform.position.z);
	}
}
