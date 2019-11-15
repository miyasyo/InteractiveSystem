using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public GameObject countdown;
    public float totalTime;
    int seconds;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        totalTime -= Time.deltaTime;
        seconds = (int)totalTime;
        countdown.GetComponent<TextMesh>().text = seconds.ToString();
        if(totalTime <= 1f)
        {
            FlashGame.scenecount = 2;
        }
    }
}
