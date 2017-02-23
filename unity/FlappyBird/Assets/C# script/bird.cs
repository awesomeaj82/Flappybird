using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    public int jumpheight;
    public int gravity;
    private Vector3 position;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        position = transform.position;
        float translation = Time.deltaTime * gravity;
        transform.Translate(0, -translation, 0);
        if (Input.GetKeyDown("space"))
        {
            transform.Translate(0, translation + jumpheight, 0);
        }
        if (position.y <= -6)
        {
            transform.Translate(0, +translation, 0);
        }
        
    }
}
