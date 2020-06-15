using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public static Sound Instance; 
    public AudioClip Player_dead; 
    public AudioClip Collected_food; 
   // public AudioClip sheepDroppedClip; 
    private Vector3 cameraPosition; 
    void Awake()
    {
        Instance = this;
        cameraPosition = Camera.main.transform.position;
    }

    private void PlaySound(AudioClip clip)
    {
        AudioSource.PlayClipAtPoint(clip,cameraPosition,1f);
    }
    public void PlayCollectedFood()
    {
        PlaySound(Collected_food);
    }

    public void PlayerDead()
    {
        PlaySound(Player_dead);
        GameState.Instance.GameOver();
    }
}
