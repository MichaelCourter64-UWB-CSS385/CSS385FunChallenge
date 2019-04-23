using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverCheck : MonoBehaviour {

    [SerializeField] float gameOverLevel;

    Vector3 restartPoint;

	// Use this for initialization
	void Start () {
        restartPoint = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.y < gameOverLevel)
        {
            transform.position = restartPoint;
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
	}
}
