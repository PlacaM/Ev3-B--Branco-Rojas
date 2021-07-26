using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Probando : MonoBehaviour
{

    public int a = 0;
    public int b = 0;
    public int total = 0;

    public bool check;

    // Start is called before the first frame update
    void Start()
    {
        if (check == true)
        {
            total = a*b;
        }
        else if(check == false)
        {
            total = a/b;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
