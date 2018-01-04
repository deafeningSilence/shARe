using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class init : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject.Find("cake").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("sushi").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("salad").transform.localScale = new Vector3(0, 0, 0);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
