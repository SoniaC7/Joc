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
            Sound.Instance.PlayCollectedFood();
            GameState.Instance.CollectedFood();
            Debug.Log(GameState.collected_food);
            other.gameObject.SetActive(false);
        }
    }
}
