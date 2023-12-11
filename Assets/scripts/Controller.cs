using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Controller : MonoBehaviour
{

    [SerializeField] private Transform wallCheck;
    [SerializeField] private LayerMask wallLayer;


    private Rigidbody2D rb;
    private float move;
    private float speed = 10f;


    public bool isOnPlatform;
    public Rigidbody2D platformRb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    


    void FixedUpdate()
    {

      

        


        move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(move * speed, rb.velocity.y);


       
    
            
        



    }

 




}

