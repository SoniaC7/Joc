using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlane : MonoBehaviour
{
    public float speed = 10;
    public GameObject camera;
    void Start()
    {
        
    }

    void Update()
    {
    	if(camera.transform.rotation.y != 0){
    		speed = 0;
    	}

        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
}
