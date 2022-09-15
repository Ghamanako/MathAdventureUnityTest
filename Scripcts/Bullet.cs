using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    private float Speed = 30f;
    private Rigidbody2D rb;
  
    private void Start()
    {
      
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * Speed;
    }

}