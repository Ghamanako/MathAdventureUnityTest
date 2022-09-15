using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1 : Karakter
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            TakeDamage(20f);
            
            Destroy(collision.gameObject);
        }
    }

    
}
