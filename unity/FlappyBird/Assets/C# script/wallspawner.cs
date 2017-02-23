using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallspawner : MonoBehaviour {

    public GameObject walltop;
    public GameObject wallbottom;
    public int spawntime;
    public int timer=0;
    private int randnum;
    public int difficultygap;
    Vector3 wallpostiontop,wallpostionbottom;
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {

        randnum = Random.Range(-300, 400);//fix random number to not go every frame
        Debug.Log(randnum);

        timer--;
        if (timer <= 0) {
            
            wallpostiontop = transform.position;
            wallpostionbottom = transform.position;
            wallpostiontop.y = +1*(randnum/100)+3;//fix random to float value somehow 
            wallpostionbottom.y = wallpostiontop.y-5-difficultygap;
            timer = spawntime;
            Instantiate(walltop,wallpostiontop , transform.rotation);
            Instantiate(wallbottom, wallpostionbottom, transform.rotation);
            Debug.Log(randnum);
        }
    }
}
