using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float translation = Time.deltaTime * 1;
        transform.Translate(0, -translation, 0);
        if (Input.GetKeyDown("space"))
         transform.Translate(0, 3, 0); ;
    }
}
