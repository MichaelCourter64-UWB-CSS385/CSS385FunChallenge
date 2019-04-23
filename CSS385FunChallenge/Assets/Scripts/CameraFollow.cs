using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    public GameObject leader;
    

	// Use this for initialization
    
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = new Vector3(leader.transform.position.x, transform.position.y, transform.position.z);
		
	}
}
