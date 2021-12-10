using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score;
    public static GameManager inst;
    [SerializeField] Text scoreText;
    public GameObject completeLevelUI;
    public void IncrementScore ()
    {
        score++;
        scoreText.text = "SCORE: " + score;
    }
    private void Awake ()
    {
        inst = this;
    }
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
