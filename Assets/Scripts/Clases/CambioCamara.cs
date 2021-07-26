using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioCamara : MonoBehaviour
{
    public Camera camara1;
    public Camera camara2;

    // Start is called before the first frame update
    void Start()
    {
        camara1.enabled = true;
        camara2.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        CameraSwitch();
    }

    void CameraSwitch()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            camara1.enabled = false;

            camara2.enabled = true;
        }
        else if (Input.GetKey(KeyCode.Alpha2))
        {
            camara1.enabled = true;

            camara2.enabled = false;
        }
    }

}
