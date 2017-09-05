using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour {
    //how high can the player jump
    public float jump_size;
    //define this object
    public GameObject Skin;
    //movement speed
    public float speed;
    //verify if the player is jumping or not
    public bool canJump;

 
    // Use this for initialization
    void Start () {
        //setup
        
        canJump = true;
            
	}
    //when the player touch something he can jump
    void OnCollisionEnter(Collision collision)
    {
        canJump = true;
    }
    //when the player can't touch anything he can't jump anymore
    void OnCollisionExit(Collision collision)
    {
        canJump = false;
    }
    void GoForward()
    {
        //the ball should go forward in every moment
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + speed);
    }
    
    bool isJump()
    {
        //verify if the player can jump and if the player isn't touching the terrain
        if (Input.GetKeyDown("space") && canJump == true)
        {
            return true;
        }
        return false;
    }

    void TryToJump()
    {
        //verify if all conditions are done
        if (!isJump()) return;
        
        GoForward();
        //jump
        transform.position = new Vector3(transform.position.x,transform.position.y + jump_size,transform.position.z + speed);
        
      

    }

    void Dx_Move()
    {   
        //verify if the player wants to swith on the right
        if (Input.GetKey("a"))
        {
            //switch on the right
            transform.position = new Vector3(transform.position.x - speed, transform.position.y, transform.position.z);
            
        }
    }
    //verify if the player wants to swith on the left
    void Sx_Move()
    {
        if (Input.GetKey("d"))
        {
            //switch on the right
            transform.position = new Vector3(transform.position.x + speed, transform.position.y, transform.position.z);
            
        }
    }
    // Update is called once per frame
    void Update () {
        //Function that will be executed every second
        GoForward();

        TryToJump();

        Dx_Move();

        Sx_Move();



    }

}

