using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate_Coin : MonoBehaviour
{
    public Vector3 rotationSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime );
    }
}
