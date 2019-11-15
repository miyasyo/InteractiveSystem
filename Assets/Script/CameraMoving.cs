using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoving : MonoBehaviour
{
    public Camera Playercamera;
    private int rotationx; //カメラの上下角度
    private int count; //カメラの切り替えタイミング
    // Start is called before the first frame update
    void Start()
    {
        count = 1;
        rotationx = 50;
    }

    // Update is called once per frame
    void Update()
    {
        InvokeRepeating("moveup", 5, 10);
        InvokeRepeating("movedown", 7, 10);

        if (count == 0)
        {
            if (rotationx >= 0)
            {
                rotationx -= 8;
            }else
            {
                return;
            }
        }else
        {
            if (rotationx <= 50)
            {
                rotationx += 8;
            }else
            {
                return;
            }
        }
        Playercamera.transform.rotation = Quaternion.Euler(rotationx, 0, 0);
    }
    void moveup()
    {
        count = 0;
    }
    void movedown()
    {
        count = 1;
    }
}
