using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(this.gameObject.transform.position.z + 120f <= Player.transform.position.z)
        {
            Destroy(this.gameObject);
            Debug.Log("通り過ぎたよ");
        }
    }
}
