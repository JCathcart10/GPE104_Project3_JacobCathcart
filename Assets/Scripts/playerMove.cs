using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    private Rigidbody2D rb;// makes rigidbody variable
    public float speed = 1.0f;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();// assigns the Rigidbody to the rb variable
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal") * speed;
        float v = Input.GetAxisRaw("Vertical") * speed;

        if (h > 0.0f && v == 0.0f) // if player is moving right
        {
            rb.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f); //player faces right
        }
      
        if (h > 0.0f && v > 0.0f)// if player is moving up and right
        {
            rb.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 45.0f);//player faces upper right
        }

        if (h == 0.0f && v > 0.0f)// if player is moving up
        {
            rb.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 90.0f);//player faces up
        }

        if (h < 0.0f && v > 0.0f)// if player is moving up and left
        {
            rb.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 135.0f);//player faces upper left
        }

        if (h < 0.0f && v == 0.0f)// if player is moving left
        {
            rb.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 180.0f);//player faces left
        }

        if (h < 0.0f && v < 0.0f)// if player is moving down and left
        {
            rb.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 225.0f);//player faces lower left
        }

        if (h == 0.0f && v < 0.0f)// if player is moving down
        {
            rb.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 270.0f);//player faces down
        }

        if (h > 0.0f && v < 0.0f)// if player is moving down and right
        {
            rb.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 315.0f);//player faces lower right
        }

        

            transform.position += new Vector3 (h, v, 0.0f);
    }
}
