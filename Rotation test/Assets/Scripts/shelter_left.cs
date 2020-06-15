using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class shelter_left : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Menu_Quit"))
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
