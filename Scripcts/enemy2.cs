using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy2 : Karakter
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            TakeDamage(40f);
            
            Destroy(collision.gameObject);
        }
    }
}
