using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myrocket : MonoBehaviour {
    Rigidbody myrigidbd;
    //public float rocketspeed = 1;

	// Use this for initialization
	void Start () {
        myrigidbd = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            
            myrigidbd.AddRelativeForce(new Vector3(0,20,0), ForceMode.Force);
            Debug.Log("i am happy");
        }
	}
}
