using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    public int jumpheight;
    public int gravity;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float translation = Time.deltaTime * gravity;
        transform.Translate(0, -translation, 0);
        if (Input.GetKeyDown("space"))
            transform.Translate(0, translation + jumpheight, 0);
    }
}
