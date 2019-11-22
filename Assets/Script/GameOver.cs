using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    private GameObject Game;
    private int sig;
    // Start is called before the first frame update
    void Start()
    {
        sig = Player.signal;
        Game = GameObject.Find("GameOver");
        Game.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(sig == 1)
        {
            Time.timeScale = 0;
            Game.SetActive(true);
        }
    }
}
