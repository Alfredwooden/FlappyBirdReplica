using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetButtonDown("Fire1"))
        {
            rb.AddForce(new Vector2(0f, 2f));
        }
        else{
            rb.AddForce(new Vector2(0f, 0f));
        }
        
    }
}
