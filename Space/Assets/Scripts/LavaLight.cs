using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaLight : MonoBehaviour {

	Transform targetX;
	Transform targetY;
	float offset = 15f;
	
	void Awake() {
		targetX = GameObject.Find("Player").transform;
		targetY = GameObject.Find("Lava").transform;
	}

	void Update () {
		transform.position = new Vector3(targetX.position.x, targetY.position.y - offset, transform.position.z);
	}
}
