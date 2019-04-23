using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinFill : MonoBehaviour {
    [SerializeField] GameObject[] imagesToFill;
    [SerializeField] float fillRate;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		for(int i = 0; i < imagesToFill.Length; i++)
        {
            imagesToFill[i].GetComponent<Image>().fillAmount += fillRate * Time.deltaTime;
        }
	}
}
