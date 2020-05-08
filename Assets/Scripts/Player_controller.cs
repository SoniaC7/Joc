using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_controller : MonoBehaviour
{
    public float speed;
    public float tspeed;

    private bool trigger_contact = false;
    private Vector3 direction = new Vector3(0, 0, 1);

    void Start()
    {
        
    }


    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
        //transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, new Vector3(0, 90, 0), Time.deltaTime * tspeed);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Right") && !trigger_contact)
        {
            transform.Rotate(new Vector3(0, 90, 0));
            //transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, new Vector3(0, 90, 0), Time.deltaTime * tspeed);
            trigger_contact = true;
        }

        else if (other.gameObject.CompareTag("Left") && !trigger_contact)
        {
            transform.Rotate(new Vector3(0, -90, 0));
            //transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, new Vector3(0, -90, 0), Time.deltaTime * tspeed);
            trigger_contact = true;
        }
        else trigger_contact = false;

        if (other.gameObject.CompareTag("Shelter") && !trigger_contact)
        {
            speed = 0;
        }
    }
}
