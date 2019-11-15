using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createplane : MonoBehaviour
{
    public GameObject Plane; //床のprefab
    private float spon_position;
    private int repeat;
    private int createcount;
    // Start is called before the first frame update
    void Start()
    {
        spon_position = 120f;
        StartCoroutine(create());
    }

    // Update is called once per frame
    void Update()
    {
    }
    private IEnumerator create()
    {
        while (true)
        {
            // 10秒毎にループします
            yield return new WaitForSeconds(10f);
            createPlane();
        }
    }
    void createPlane() //床を生成する
    {
            Instantiate(Plane, new Vector3(Plane.transform.position.x, Plane.transform.position.y,
                spon_position), Plane.transform.rotation);
            spon_position += 120f;
            Debug.Log("test");
    }
  
}
