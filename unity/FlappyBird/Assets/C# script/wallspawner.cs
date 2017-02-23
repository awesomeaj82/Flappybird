using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallspawner : MonoBehaviour {

    public GameObject walltop;
    public GameObject wallbottom;
    public GameObject coin;
    public int spawntimewall;
    public int timerwall=0,timercoin=0;
    private int randnum;
    public float difficultygap,difficultycoin;
    Vector3 wallpostiontop,wallpostionbottom,coinposition;
    public int spawntimecoin;

	
	// Update is called once per frame
	void Update () {

        

        
        timerwall--;
        if (timerwall <= 0) {
            
            wallpostiontop = transform.position;
            wallpostionbottom = transform.position;
            wallpostiontop.y = (randnum/100)+4;//fix random to float value somehow 
            wallpostionbottom.y = (randnum / 100)-2-difficultygap;
            timerwall = spawntimewall;
            Instantiate(walltop,wallpostiontop , transform.rotation);
            Instantiate(wallbottom, wallpostionbottom, transform.rotation);
            Debug.Log(randnum);
        }
        randnum = Random.Range(-300, 400);//fix random number to not go every frame
        timercoin--;
        if (timercoin <= 0)
        {
            timercoin = spawntimecoin + Mathf.FloorToInt(difficultycoin * 6);
            coinposition.y = randnum / 100;
            coinposition.x = 6;
            Instantiate(coin, coinposition, transform.rotation);

        }
    }
}
