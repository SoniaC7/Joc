using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_camera : MonoBehaviour
{

    public string turn = "no";
    public bool dead = false;
    private bool trigger_contact = false;

    public float points = 0;
   
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Tocando");
        if (other.gameObject.CompareTag("Right"))
        {
            Debug.Log("Giro derecha");
           // transform.Rotate(new Vector3(0, 45, 0));
            //transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, new Vector3(0, 90, 0), Time.deltaTime * tspeed);
            turn = "right";
        }

        else if (other.gameObject.CompareTag("Left"))
        {
            Debug.Log("Giro izquierda");
            //transform.Rotate(new Vector3(0, -45, 0));
            //transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, new Vector3(0, -90, 0), Time.deltaTime * tspeed);
            turn = "left";
        }
        
        else if (other.gameObject.CompareTag("Dead"))
        {
            Debug.Log("Dead");
            dead = true;
        }

        if (other.gameObject.CompareTag("Shelter") && !trigger_contact)
        {
            Debug.Log("Stop");
        }
    }
}
