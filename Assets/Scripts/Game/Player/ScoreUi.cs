using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUi : MonoBehaviour
{
    public Text Score;
    private int scoreNum =  0;

    // Start is called before the first frame update
    void Start()
    {
        Score.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = "Score: " + scoreNum;
    }

    public void IncreaseScore()
    {
        scoreNum++;
    }
}
