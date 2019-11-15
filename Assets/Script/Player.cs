using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject trans_player;
    void Update()
    {
        trans_player.transform.position =
          new Vector3(Mathf.Clamp(trans_player.transform.position.x, -10, 10), 3.8f, trans_player.transform.position.z);

        trans_player.transform.Translate(0, 0.2f/2, 0.1679f/2);
       
        if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(0.5f, 0f, 0f);
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(-0.5f, 0f, 0f);
            }
       
    }
    void OnTriggerEnter(Collider other) 
    {
        //衝突判定
        if (other.gameObject.tag == "Enemy")
        {
            //相手のタグがBallならば、自分を消す
            Destroy(other.gameObject);
            Debug.Log("当たった！");
        }
    }

}
