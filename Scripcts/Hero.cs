using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : Karakter
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "BulletBuaya")
        {
            TakeDamage(10f);
           
            Destroy(collision.gameObject);
        }

        if (collision.tag == "BulletKura")
        {
            TakeDamage(5);
           
            Destroy(collision.gameObject);
        }
    }

}
