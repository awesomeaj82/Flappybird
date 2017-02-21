using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallbottom : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float translation = Time.deltaTime * 1;
        transform.Translate(-translation, 0, 0);

    }
}
