using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{

    public int minSecs = 1;
    public int maxSecs = 5;

    public GameObject  objeto = null;

    public float timer = 0f;
    public int spawnTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        spawnTime = Random.Range(minSecs, maxSecs);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnTime)
        {
            Instantiate(objeto,transform);
            timer = 0;
            spawnTime = Random.Range(minSecs,maxSecs);
        }
    }
}
