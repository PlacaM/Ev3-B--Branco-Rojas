using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objeto = null;
    public float timer = 0f;
    public float timeToSpawn = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= timeToSpawn)
        {
            Instantiate(objeto, new Vector3(transform.position.x, transform.position.y, 0),Quaternion.identity );
            timer = 0f;
            Debug.Log("spawneo algo");
        }
    }
}
