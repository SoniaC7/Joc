using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_coin : MonoBehaviour
{
    public float timeDestroy;
    void Start()
    {
        Destroy(gameObject, timeDestroy);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
