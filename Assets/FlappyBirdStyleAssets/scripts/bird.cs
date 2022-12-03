using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour {

    private bool isalive = true;

    public float jumpforce = 200f;
    private Rigidbody2D rb;
    private Animator anim;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if(isalive==true)
        {
            if(Input.touchCount > 0 || Input.GetMouseButtonDown(0))
            {
                rb.velocity = Vector2.zero;
                rb.AddForce(new Vector2(0, jumpforce));
                anim.SetTrigger("flap");
            }
        }
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb.velocity = Vector2.zero;
        isalive = false;
        anim.SetTrigger("die");
        gamecontrol.instance.birddie();

    
    }
}
