using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collect_food : MonoBehaviour
{
   public GameObject player;
   private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Food"))
        {
            player.GetComponent<move_camera>().points ++ ;
            Debug.Log(player.GetComponent<move_camera>().points);
        }
    }
}
