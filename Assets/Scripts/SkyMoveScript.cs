using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyMoveScript : MonoBehaviour {

    public GameObject sky;

    public float speed, spawnTimer;

    private float timer;

    private GameObject Cloud;

	void Update () {

        if (timer >= 0)
            timer -= Time.deltaTime;

        if (timer < 0) {
            Destroy(Cloud);
            Cloud = Instantiate(sky, transform.position, Quaternion.identity);
            Cloud.name = "CloudBundle";
            timer = spawnTimer;           
        }
        Cloud.transform.position += Vector3.right * speed * Time.deltaTime;       
    }
}
