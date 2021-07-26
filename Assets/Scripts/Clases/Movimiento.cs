using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float speed;
    public float rZ;
    public int score = 0;
    public Rigidbody2D rB;


    public void AddForce()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
       rB = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        //Movimiento 

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.up * Time.deltaTime * speed;
            Debug.Log("Arriba");
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.up * Time.deltaTime * speed;
            Debug.Log("Abajo");
        }


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rB.AddForce(Vector2.left);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rB.AddForce(Vector2.right);
        }




        //Rotacion 

        //if (Input.GetKey(KeyCode.D))
        //{
        //    transform.Rotate(0, 0, -rZ); 

        //    Debug.Log("Derecha");
        //}

        //if (Input.GetKey(KeyCode.A))
        //{
        //    transform.Rotate(0, 0, rZ);
        //    Debug.Log("Izquierda");
        //}     

    }



    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.CompareTag("Enemy"))
    //    {
    //        Destroy(this.gameObject);
    //        Debug.Log("Tu nave ha sido destruida");
    //    }
    //}

    //public void AddScore(int points)
    //{
    //    score += points;
    //    Debug.Log(score);
    //}

}
