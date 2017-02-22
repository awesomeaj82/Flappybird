using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallbottom : MonoBehaviour {

    Vector3 position;
    bool firstframe=true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (firstframe == true) {
            firstframe = false;
            position = transform.position;
        }
        float translation = Time.deltaTime * 1;
        transform.Translate(-translation, 0, 0);

        position.x += -translation;
        if (position.x <= -5)
        {
            Destroy(gameObject);
        }
    }
}
