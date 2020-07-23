using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controllador : MonoBehaviour
{
    public float speed=2f;
    private Rigibody2D rb2d;
    void Start()
    {
        rb2d= GetComponent<Rigibody2D>(); //buscamos rigidbiody
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        float h= Input.GetAxis("Horizontal");//capturamos si esta apretando para la derecha
        rb2d.AddForce(Vector2.right *speed*h);// se mueve segun la direccion
    }
}
