using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    //public Vector3 rotationSpeed;
    public GameObject Player;
    public GameObject plane;
    private float cam_y;
    void Start()
    {
        
    }
    void comparePos(){
    	

    	if(plane.transform.position.z < -10.00){

    		transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, new Vector3(0, 90, 0), Time.deltaTime * 10);
    	}
    }
    void Update()
    {
    	comparePos();
        
        
    }
}
