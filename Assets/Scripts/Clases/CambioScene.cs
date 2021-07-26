using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioScene : MonoBehaviour
{
    public bool cambio = false;
    public int timeToChange = 0;    
    public float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (cambio == true)
        {
            timer += Time.deltaTime;
            if (timer>=timeToChange)
            {
                SceneManager.LoadScene(1);
            }
        }
    }
}
