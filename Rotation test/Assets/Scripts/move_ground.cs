using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_ground : MonoBehaviour
{
    public float speed;
    public GameObject player;

    private Vector3 direction = new Vector3(0, 0, -1);

    void Start()
    {

    }

    void Update()
    {
        if(player.GetComponent<player_controller>().dead == true) speed = 0;
        transform.Translate(direction * speed * Time.deltaTime);

        if (player.GetComponent<player_controller>().turn == "left") { turn_left(); player.GetComponent<player_controller>().turn = "no"; }
        if (player.GetComponent<player_controller>().turn == "right") {turn_right(); player.GetComponent<player_controller>().turn = "no"; }
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
