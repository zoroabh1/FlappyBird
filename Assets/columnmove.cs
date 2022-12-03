using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class columnmove : MonoBehaviour {

    // Use this for initialization
    public int columnpoolsize=5;
    public GameObject prefab;
    public float spawnRate = 4f;
    public float columnmin = -1f;
    public float columnMax = 3.5f;
    private GameObject[] columns;
    private Vector2 objectpoolPosition = new Vector2(-15f, -25f);
    private float timeSinceLAstSpawned;
    private float spawnXposition = 10f;
    private int currentColumn = 0;
	void Start () {
        columns = new GameObject[columnpoolsize];
        for (int i = 0; i < columnpoolsize; i++)
        {
            columns[i] = (GameObject)Instantiate(prefab, objectpoolPosition,Quaternion.identity);
        }
		
	}
	
	// Update is called once per frame
	void Update () {
        timeSinceLAstSpawned += Time.deltaTime;
        if(gamecontrol.instance.gameover==false && timeSinceLAstSpawned>=spawnRate)
        {
            timeSinceLAstSpawned = 0;
            float spawnYPosition = Random.Range(columnmin, columnMax);
            columns[currentColumn].transform.position = new Vector2(spawnXposition, spawnYPosition);
            currentColumn++;
            if(currentColumn>=columnpoolsize)
            {
                currentColumn = 0;
            }

        }
	}
}
