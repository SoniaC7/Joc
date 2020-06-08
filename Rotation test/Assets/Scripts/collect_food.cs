﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collect_food : MonoBehaviour
{
   public GameObject player;
   public GameObject coin_prefab;
   
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Food"))
        {
            coin_prefab.transform.position = player.transform.position + new Vector3(0,0,1000);
            coin_prefab.GetComponentInChildren<MeshRenderer>().enabled = true;
            coin_prefab.GetComponent<rotate_Coin>().enabled = true;
            coin_prefab.GetComponent<move_coin>().enabled = true;
            coin_prefab.GetComponent<scale_coin>().enabled = true;
            coin_prefab.GetComponent<destroy_coin>().enabled = true;
            player.GetComponent<move_camera>().points ++;
            Debug.Log(player.GetComponent<move_camera>().points);
        }
    }
}
