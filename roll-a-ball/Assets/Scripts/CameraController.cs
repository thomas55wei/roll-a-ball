using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    private Vector3 offsetToPlayer;
    public GameObject player;
	// Use this for initialization
	void Start () {
        this.offsetToPlayer = this.transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        this.transform.position = player.transform.position + offsetToPlayer;
	}
}
