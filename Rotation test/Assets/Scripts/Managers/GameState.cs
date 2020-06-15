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
    static public int collected_food = 0;

    void Awake()
    {
        Instance = this;
    }
    public void DisplayText(){
        collected_food_text.text = collected_food.ToString();
    }
    public void CollectedFood()
    {
        collected_food++;
        DisplayText();
    }
   
    public void Shelter()
    {
        SceneManager.LoadScene("Shelter");
        Debug.Log("Shelter");
    }
    public void GameOver()
    {
        SceneManager.LoadScene("Death");
    }

}
