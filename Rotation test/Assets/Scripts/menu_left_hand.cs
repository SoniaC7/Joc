using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu_left_hand : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Menu_Quit"))
        {
            Application.Quit();
        }
    }
}
