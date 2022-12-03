using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gamecontrol : MonoBehaviour {

    // Use this for initialization
    public static gamecontrol instance;
    public GameObject gameovertext;
    public bool gameover = false;
    public float scrollspeed = -1.5f;
    public Text scoretext;  
    private int score = 0;
	void Awake () {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

    }
	
	// Update is called once per frame
	void Update () {
		if(gameover==true && (Input.touchCount>0||Input.GetMouseButtonDown(0)))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
	}

    public void birdscore()
    {
        if(gameover)
        {
            return;
        }
        score++;
        scoretext.text = "Score :" + score.ToString();

    }
    public void birddie()
    {
        gameovertext.SetActive(true);
        gameover = true;
    }
}
