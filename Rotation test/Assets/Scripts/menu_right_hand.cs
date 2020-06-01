using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_right_hand : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Menu_Play"))
        {
            SceneManager.LoadScene("Level_One");
        }
    }
}
