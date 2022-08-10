using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    public TextMeshProUGUI Score;
    int p1 = 0 ;
    [HideInInspector] public bool play;
    // Start is called before the first frame update
    void Start()
    {
        play = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(play);
        if (play)
        {
            Scoring();
        }
        else
        {
            return;
        }
    }

    void Scoring()
    {
        p1 += 1;
        Score.text = p1.ToString();
    }

    public bool Play
    {
        set
        {
            this.play = value;
        }
    }


}
