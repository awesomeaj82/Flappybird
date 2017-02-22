using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallspawner : MonoBehaviour {

    public GameObject walltop;
    public GameObject wallbottom;
    public int spawntime;
    public int timer=0;
    public int randnum;
    public int difficulty;
    Vector3 wallpostiontop,wallpostionbottom;
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {

        

        timer--;
        if (timer <= 0) {
            
            randnum = (Random.Range(0,difficulty*10 ))/10;
            wallpostiontop = transform.position;
            wallpostionbottom = transform.position;
            wallpostiontop.y = +1*randnum+3;
            wallpostionbottom.y = wallpostiontop.y -7;
            timer = spawntime;
            Instantiate(walltop,wallpostiontop , transform.rotation);
            Instantiate(wallbottom, wallpostionbottom, transform.rotation);
            Debug.Log(randnum);
        }
    }
}
