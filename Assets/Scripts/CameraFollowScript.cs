using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowScript : MonoBehaviour {

    public GameObject player;

	void LateUpdate () {

        if (player == null)
            player = GameObject.FindGameObjectWithTag("Player");

        Vector3 loc = player.transform.position;

        loc.z = -10;
        if (PlayerMovement.alive)
        transform.position = Vector3.Slerp(transform.position, loc, Time.deltaTime);
    }
}
