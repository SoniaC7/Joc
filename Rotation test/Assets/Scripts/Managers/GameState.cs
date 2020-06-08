using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour
{
   public static GameState Instance;
   [HideInInspector]
   public int collected_food;

    void Awake()
    {
        Instance = this;
    }

    public void CollectedFood()
    {
        collected_food++;
    }
    private void GameOver()
    {

    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
