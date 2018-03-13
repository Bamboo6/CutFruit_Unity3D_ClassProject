using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour {

    Vector2 mouseWorldPos;

    public Camera camera;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        mouseWorldPos = camera.ScreenToWorldPoint(Input.mousePosition);

        transform.position = mouseWorldPos;
		
	}
}
