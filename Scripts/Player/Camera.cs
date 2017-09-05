using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {
    //the player rapresentation
    public GameObject Player;

    public int Distances;
	// Update is called once per frame
	void Update () {
        
        //don't update if jumping
        if (!Input.GetKeyDown("space"))
        {
            //set a new position based on the player position
            transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y + Distances, Player.transform.position.z - Distances);

        }
    }

}
