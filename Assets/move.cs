using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

    Rigidbody2D rb;
    SpriteRenderer sr;
   
    private float speed = 5f;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
       

    }

    // Update is called once per frame
    void Update() {
        //Fncion para darle velocidad a la nave
        float movX = Input.acceleration.x;
        rb.transform.Translate(Vector2.right * speed * movX *
        Time.deltaTime);

    }
}
