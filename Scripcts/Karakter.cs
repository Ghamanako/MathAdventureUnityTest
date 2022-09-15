using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Karakter : MonoBehaviour, IDamageAble
{
    [SerializeField] private string Name;
    [SerializeField] private float maxHealthPoint;
    [SerializeField] private float intervalAttack;
    private float startTimeAttack;
    private float healthPoint;

    [SerializeField] private GameObject bullet;
    public Image HpImage;

    // Start is called before the first frame update
    private void Start()
    {
        startTimeAttack = intervalAttack;
        healthPoint = maxHealthPoint;
    }

    // Update is called once per frame
    private void Update()
    {

       

        Attack();

    }

    protected virtual void Attack()
    {
        if (intervalAttack < 0)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            intervalAttack = startTimeAttack;
        }
        else
        {
            intervalAttack -= Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

    }

    public virtual void TakeDamage(float damage)
    {
        healthPoint -= damage;
        HpImage.fillAmount = healthPoint / maxHealthPoint;
        if (healthPoint <= 0)
            Destroy(gameObject);

    }
    
    

    


}
