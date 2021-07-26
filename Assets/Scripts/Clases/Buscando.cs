using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buscando : MonoBehaviour
{

    public string [] mosntruos = new string[5] { "Frankenstein", "Dracula","Mr. Hyde", "Sascuatch", "Hombre lobo" };

    public string nombre = "";

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < mosntruos.Length; i++)
        {
            if (mosntruos[i] == nombre)
            {
                Debug.Log("el monstruo ha sido encontrado");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
