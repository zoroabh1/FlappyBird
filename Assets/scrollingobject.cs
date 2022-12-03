using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollingobject : MonoBehaviour {

    // Use this for initialization
    private Rigidbody2D rb2;
	void Start () {
        rb2 = GetComponent<Rigidbody2D>();
        rb2.velocity = new Vector2(gamecontrol.instance.scrollspeed,0);
	}
	
	// Update is called once per frame
	void Update () {
		if(gamecontrol.instance.gameover == true)
        {
            rb2.velocity = Vector2.zero;
        }
	}
}
