using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class General : MonoBehaviour {
    //count the pass made by the player and it will be set to 0 if it fail
    public float Counter;
    //define the current gameobject and the next level
    public GameObject here;

    public GameObject next;
    //the player and the camera initial position to make them respawn
    private Vector3 PlayerInitialPosition;

    public Vector3 CameraInitialPosition;
    //these represent the player and the camera
    public GameObject Player;

    public GameObject Camera;
    //at what y ascii the player will considered dead
    public float DeathGoal;
    //at what z ascii the player will be considered winner
    public float Goal;
    void Start()
    {   //set up
        PlayerInitialPosition = new Vector3( Player.transform.position.x, Player.transform.position.y , Player.transform.position.z+0.5f);

        CameraInitialPosition = Camera.transform.position;
        
    }
    // Update is called once per frame
    void Update () {
        //if the player dies
        if (Player.transform.position.y <= DeathGoal)
        {
            //the camera and the player will return to their initial position
            Camera.transform.position = CameraInitialPosition;
            Player.transform.position = PlayerInitialPosition;
            //counter will be set to 0 
            Counter = 0;

        }
        //Counter gain -0.3 points every second
        Counter -= 0.3f;
        //if the player win the match
        if (Player.transform.position.z >= Goal)
        {
           
            //the next level stage appear
            next.SetActive(true);
            //the current level disappear
            here.SetActive(false);
            Player.transform.position = PlayerInitialPosition;
        }
	}
}
