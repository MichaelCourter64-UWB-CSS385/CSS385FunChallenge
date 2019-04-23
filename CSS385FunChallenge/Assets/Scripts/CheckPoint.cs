using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour {
    [SerializeField] GameObject SpawnPointHolder;

    SpawnPoint playerSpawn;

    void Start()
    {
        playerSpawn = SpawnPointHolder.GetComponent<SpawnPoint>();
    }

    void OnTriggerEnter2D()
    {

    }
}
