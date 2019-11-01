using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject trans_player;
    void Update()
    {
        
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(1, 0, 0);
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(-1, 0, 0);
            }
        trans_player.transform.position =
            new Vector3(Mathf.Clamp(trans_player.transform.position.x, -10, 10), 4.7f, 0);
      
    }
   
}
