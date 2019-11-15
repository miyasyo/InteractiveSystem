using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpon : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject player;
    private float randomx1;
    private float randomx2;
    private float randomz;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(create());
        randomx1 = Random.Range(-10f, 0f);
        randomx2 = Random.Range(1, 10f);

        randomz = Random.Range(10f, 40f);
    }

    // Update is called once per frame
    void Update()
    {
    }
    private IEnumerator create()
    {
        while (true)
        {
            // 3秒毎にループします
            yield return new WaitForSeconds(3f);
            createEnemy();
        }
    }
    void createEnemy() //床を生成する
    {
        randomx1 = Random.Range(-10f, 0f);
        randomx2 = Random.Range(1, 10f);
        randomz = Random.Range(10f,30f);

        Instantiate(Enemy, new Vector3(randomx1, 0f, player.transform.position.z + randomz), Enemy.transform.rotation);
        randomz = Random.Range(40f, 60f);
        Instantiate(Enemy, new Vector3(randomx2, 0f, player.transform.position.z + randomz), Enemy.transform.rotation);

        Debug.Log(randomx1);
        Debug.Log(randomx2);
    }
}
