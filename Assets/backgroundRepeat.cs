using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundRepeat : MonoBehaviour {

    // Use this for initialization
    private BoxCollider2D groundcollider;
    private float groundHorizontalLength;
	void Start () {
        groundcollider = GetComponent<BoxCollider2D>();
        groundHorizontalLength = groundcollider.size.x;
	}
	
	// Update is called once per frame
	void Update () {
        if(transform.position.x < -groundHorizontalLength)
        {
            reposition();
        }
		
	}
    private void reposition()
    {
        Vector2 groundOffset = new Vector2(groundHorizontalLength * 2.0f, 0);
        transform.position = (Vector2)transform.position + groundOffset;
    }
}
