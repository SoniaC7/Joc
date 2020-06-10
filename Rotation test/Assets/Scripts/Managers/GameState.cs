using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour
{
    public static GameState Instance;
    public Text collected_food_text;
    [HideInInspector]
    public int collected_food;

    void Awake()
    {
        Instance = this;
    }

    public void CollectedFood()
    {
        collected_food++;
        collected_food_text.text = collected_food.ToString();
    }
    public void Shelter()
    {
        Debug.Log("Shelter");
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
