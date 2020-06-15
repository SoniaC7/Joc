using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{

    [HideInInspector]
    public string turn = "no";
    [HideInInspector]
    public bool dead = false;
    [HideInInspector]
    private bool trigger_contact = false;
    
   
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
            Sound.Instance.PlayerDead();
            dead = true;
        }

        if (other.gameObject.CompareTag("Shelter") && !trigger_contact)
        {
            GameState.Instance.Shelter();
            dead = true;
        }
    }
}
