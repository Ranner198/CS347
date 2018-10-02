using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject ball;
    public GameObject ballPrefab;
    public GameObject ballSpawnLocation;

	void Start () {

	}
	
	
	void Update () {

        if (ball == null) {
            print("called");
            ball = Instantiate(ballPrefab, ballSpawnLocation.transform.position, Quaternion.identity);
        }
	}

    void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Ball")
        {
            ball = null;
        }
    }
}
