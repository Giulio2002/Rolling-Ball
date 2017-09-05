using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Completed : MonoBehaviour {
    //rappresent the current gameobject
    public GameObject This;
    //rappresent the next scene
    public GameObject Next;
    //Count the time
    public int Timer;
    //set the goal that the counter should reach 
    public int Goal;

    private bool isAlreadyset = false;
    // Update is called once per frame
    void Update () {
        Timer += 1;
        //wait for a key
        if (Timer >= Goal && isAlreadyset == false)
        {

            //switch to the next scene
            Next.SetActive(true);

            This.SetActive(false);

            isAlreadyset = true;
            Timer = 0;

            isAlreadyset = false;
            

        }
    }
}
