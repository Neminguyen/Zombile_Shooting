using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject player;
    public GameObject playButton;
    public GameObject gameOver;

    private void Awake()
    {
        instance = this;
    }

    public void Play()
    {

    }

    public void Pause()
    {

    }

    public void GameOver()
    {

    }
}
