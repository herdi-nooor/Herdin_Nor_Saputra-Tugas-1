using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    public Text Score;
    // Start is called before the first frame update
    void Start()
    {
        int p1;
    }

    // Update is called once per frame
    void Update()
    {
        p1 += 15;
        Score.text = p1.ToString();
    }
}
