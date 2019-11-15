using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FlashGame : MonoBehaviour
{
    public static int scenecount = 0;
    public GameObject GameTitle;
    public GameObject GameScene;
    public GameObject counttimer;
    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject four;
    public GameObject five;
    public GameObject six;
    public GameObject seven;
    public GameObject eight;
    public GameObject nine;
    public GameObject start;
    public GameObject Q1;
    public GameObject Q2;
    public GameObject Q3;
    public GameObject Answer;
    bool oneplay = false;
    bool twoplay = false;
    bool threeplay = false;


    public int sum;
    private int randamnum;
    // Start is called before the first frame update
    void Start()
    {
        sum = 0;
        scenecount = 0;
        GameScene.SetActive(false);
        counttimer.SetActive(false);
        one.SetActive(false);
        two.SetActive(false);
        three.SetActive(false);
        four.SetActive(false);
        five.SetActive(false);
        six.SetActive(false);
        seven.SetActive(false);
        eight.SetActive(false);
        nine.SetActive(false);
        start.SetActive(false);
        Q1.SetActive(false);
        Q2.SetActive(false);
        Q3.SetActive(false);
        Answer.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("scene = " + scenecount);
        if (Input.GetKeyDown(KeyCode.A))
        {
            GameTitle.SetActive(false);
            GameScene.SetActive(true);
            counttimer.SetActive(true);
            scenecount = 1;
        }
        if (scenecount == 2)
        {
            counttimer.SetActive(false);
            start.SetActive(true);
            Q1.SetActive(true);
            Invoke("FlashStart", 1f);
            
           
        }
        if(scenecount == 3)
        {
            randamnum = Random.Range(1, 9);
            Debug.Log("sum=" + sum);

            if (!oneplay)
            {
                oneplay = true;
                if (randamnum == 1)
                {
                    Debug.Log("check");
                    Invoke("FlashOne", 1f);
                    Invoke("FlashOne_del", 2f);
                }
                if (randamnum == 2)
                {
                    Invoke("FlashTwo", 1f);
                    Invoke("FlashTwo_del", 2f);
                }
                if (randamnum == 3)
                {
                    Invoke("FlashThree", 1f);
                    Invoke("FlashThree_del", 2f);
                }
                if (randamnum == 4)
                {
                    Invoke("FlashFour", 1f);
                    Invoke("FlashFour_del", 2f);
                    
                }
                if (randamnum == 5)
                {
                    Invoke("FlashFive", 1f);
                    Invoke("FlashFive_del", 2f);
                   
                }
                if (randamnum == 6)
                {
                    Invoke("FlashSix", 1f);
                    Invoke("FlashSix_del", 2f);
                   
                }
                if (randamnum == 7)
                {
                    Invoke("FlashSeven", 1f);
                    Invoke("FlashSeven_del", 2f);
                   
                }
                if (randamnum == 8)
                {
                    Invoke("FlashEight", 1f);
                    Invoke("FlashEight_del", 2f);
                   
                }
                if (randamnum == 9)
                {
                    Invoke("FlashNine", 1f);
                    Invoke("FlashNine_del", 2f);
                }
              
            }
        }
        if (scenecount == 4)
        {
            randamnum = Random.Range(1, 9);
            if (!twoplay)
            {
                twoplay = true;
                if (randamnum == 1)
                {
                    Debug.Log("check");
                    Invoke("FlashOne", 1f);
                    Invoke("FlashOne_del", 2f);
                }
                if (randamnum == 2)
                {
                    Invoke("FlashTwo", 1f);
                    Invoke("FlashTwo_del", 2f);
                }
                if (randamnum == 3)
                {
                    Invoke("FlashThree", 1f);
                    Invoke("FlashThree_del", 2f);
                }
                if (randamnum == 4)
                {
                    Invoke("FlashFour", 1f);
                    Invoke("FlashFour_del", 2f);
                }
                if (randamnum == 5)
                {
                    Invoke("FlashFive", 1f);
                    Invoke("FlashFive_del", 2f);
                }
                if (randamnum == 6)
                {
                    Invoke("FlashSix", 1f);
                    Invoke("FlashSix_del", 2f);
                }
                if (randamnum == 7)
                {
                    Invoke("FlashSeven", 1f);
                    Invoke("FlashSeven_del", 2f);
                }
                if (randamnum == 8)
                {
                    Invoke("FlashEight", 1f);
                    Invoke("FlashEight_del", 2f);
                }
                if (randamnum == 9)
                {
                    Invoke("FlashNine", 1f);
                    Invoke("FlashNine_del", 2f);
                }
             //   scenecount = 5;
            }
           
        }
        if (scenecount == 5)
        {
            randamnum = Random.Range(1, 9);
            if (!threeplay)
            {
                threeplay = true;
                if (randamnum == 1)
                {
                    Debug.Log("check");
                    Invoke("FlashOne", 1f);
                    Invoke("FlashOne_del", 2f);
                }
                if (randamnum == 2)
                {
                    Invoke("FlashTwo", 1f);
                    Invoke("FlashTwo_del", 2f);
                }
                if (randamnum == 3)
                {
                    Invoke("FlashThree", 1f);
                    Invoke("FlashThree_del", 2f);
                }
                if (randamnum == 4)
                {
                    Invoke("FlashFour", 1f);
                    Invoke("FlashFour_del", 2f);
                }
                if (randamnum == 5)
                {
                    Invoke("FlashFive", 1f);
                    Invoke("FlashFive_del", 2f);
                }
                if (randamnum == 6)
                {
                    Invoke("FlashSix", 1f);
                    Invoke("FlashSix_del", 2f);
                }
                if (randamnum == 7)
                {
                    Invoke("FlashSeven", 1f);
                    Invoke("FlashSeven_del", 2f);
                }
                if (randamnum == 8)
                {
                    Invoke("FlashEight", 1f);
                    Invoke("FlashEight_del", 2f);
                }
                if (randamnum == 9)
                {
                    Invoke("FlashNine", 1f);
                    Invoke("FlashNine_del", 2f);
                }
            }
        }
        if (scenecount == 6)
        {
            Debug.Log(sum);
            Answer.SetActive(true);
        }
        
    }
    void FlashOne()
    {
        one.SetActive(true);
        sum = sum + 1;
       
    }
    void FlashOne_del()
    {
        one.SetActive(false);
        scenecount += 1;
    }
    void FlashTwo()
    {
        two.SetActive(true);
        sum = sum + 2;
       
    }
    void FlashTwo_del()
    {
        two.SetActive(false);
        scenecount += 1;
    }
    void FlashThree()
    {
        three.SetActive(true);
        sum += 3;
       
    }
    void FlashThree_del()
    {
        three.SetActive(false);
        scenecount += 1;
    }
    void FlashFour()
    {
        four.SetActive(true);
        sum += 4;
       
    }
    void FlashFour_del()
    {
        four.SetActive(false);
        scenecount += 1;
    }
    void FlashFive()
    {
        five.SetActive(true);
        sum += 5;
        
    }
    void FlashFive_del()
    {
        five.SetActive(false);
        scenecount += 1;
    }
    void FlashSix()
    {
        six.SetActive(true);
        sum += 6;
       
    }

    void FlashSix_del()
    {
        six.SetActive(false);
        scenecount += 1;
    }
    void FlashSeven()
    {
        seven.SetActive(true);
        sum += 7;
       
    }
    void FlashSeven_del()
    {
        seven.SetActive(false);
        scenecount += 1;
    }
    void FlashEight()
    {
        eight.SetActive(true);
        sum += 8;
       
    }
    void FlashEight_del()
    {
        eight.SetActive(false);
        scenecount += 1;
    }
    void FlashNine()
    {
        nine.SetActive(true);
        sum += 9;
       
    }
    void FlashNine_del()
    {
        nine.SetActive(false);
        scenecount += 1;
    }
    void FlashStart()
    {
        scenecount = 3;
        start.SetActive(false);

    }
}
