using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

using UnityEngine.UI;
using UnityEngine;

public class PlayPouseController : MonoBehaviour
{
    public ScoreController score;
    public GameObject GameOverPanel;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pause()
    {
        score.Play = false;
        Time.timeScale = 0f;
        Debug.Log("pause");
    }


    public void PlayGame()
    {
        Debug.Log("Play");
        score.Play = true;
        Time.timeScale = 1.0f;
    }

    public void RePlay()
    {
        GameOverPanel.SetActive(false);
        Debug.Log("Play");
        score.Play = true;
        Time.timeScale = 1.0f;
    }
}
