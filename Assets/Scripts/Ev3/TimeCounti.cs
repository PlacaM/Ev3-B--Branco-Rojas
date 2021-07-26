using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeCounti : MonoBehaviour
{
    
    public float timer = 0f;
    public Text t;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        t.text = timer.ToString("00:00");

        if (timer<=0)
        {
            SceneManager.LoadScene(3);
        }

    }
}
