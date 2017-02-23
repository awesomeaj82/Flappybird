using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speed : MonoBehaviour {

    public int difficultyspeed;
    Vector3 position;

    // Update is called once per frame
    void Update () {
        position = transform.position;
        float translation = Time.deltaTime * 1 * difficultyspeed;
        transform.Translate(-translation, 0, 0);

        position.x += -translation;
        if (position.x <= -6)
        {
            Destroy(gameObject);
        }
    }
}
