using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {


	void Update () {
        //this let the ball have a rotation 
        transform.Rotate(1, 0, 0, Space.World);
	}
	


}
