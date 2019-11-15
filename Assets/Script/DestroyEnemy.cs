using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy: MonoBehaviour
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
        if (this.gameObject.transform.position.z + 2f <= Player.transform.position.z)
        {
            Destroy(this.gameObject);
        }
    }
   
}
