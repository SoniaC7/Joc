using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collect_food : MonoBehaviour
{
   public GameObject player;
   public float coin_offset;
   public GameObject coin_prefab;
   private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Food"))
        {
            Instantiate(coin_prefab,other.transform.position + new Vector3(0, coin_offset,0), Quaternion.identity);
            player.GetComponent<move_camera>().points ++ ;
            Debug.Log(player.GetComponent<move_camera>().points);
        }
    }
}
