using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_terra : MonoBehaviour
{
    public float speed;
    public GameObject player;

    private Vector3 direction = new Vector3(0, 0, -1);

    void Start()
    {

    }

    void Update()
    {
        if(player.GetComponent<move_camera>().dead == true) speed = 0;
        transform.Translate(direction * speed * Time.deltaTime);

        if (player.GetComponent<move_camera>().turn == "left") { turn_left(); player.GetComponent<move_camera>().turn = "no"; }
        if (player.GetComponent<move_camera>().turn == "right") {turn_right(); player.GetComponent<move_camera>().turn = "no"; }
    }

    void turn_left()
    {
        transform.RotateAround(player.transform.position, new Vector3(0, 1, 0), 90);
        if (direction.Equals(new Vector3(0, 0, -1))) direction = new Vector3(1, 0, 0);
        else if (direction.Equals(new Vector3(1, 0, 0))) direction = new Vector3(0, 0, 1);
        else if (direction.Equals(new Vector3(0, 0, 1))) direction = new Vector3(-1, 0, 0);
        else if (direction.Equals(new Vector3(-1, 0, 0))) direction = new Vector3(0, 0, -1);
    }

    void turn_right()
    {
        transform.RotateAround(player.transform.position, new Vector3(0, 1, 0), -90);
        if (direction.Equals(new Vector3(1, 0, 0))) direction = new Vector3(0, 0, -1);
        else if (direction.Equals(new Vector3(0, 0, 1))) direction = new Vector3(1, 0, 0);
        else if (direction.Equals(new Vector3(-1, 0, 0))) direction = new Vector3(0, 0, 1);
        else if (direction.Equals(new Vector3(0, 0, -1))) direction = new Vector3(-1, 0, 0);
    }
}
