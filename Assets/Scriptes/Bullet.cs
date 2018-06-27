using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public int damage = 1; // Урон врага 
    public float speed = 10; // Скорость врага
     public GameObject tower; //  Цель врага


    // Update is called once per frame
    void Update()
    {
        if (tower != null) // если цель существует, то двигаемся к ней
        {
            transform.position = Vector3.MoveTowards(transform.position, tower.transform.position, speed * Time.deltaTime);
            transform.LookAt(tower.transform);
        }

        else
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            other.GetComponent<Health>().ChangeHealth(damage); 
            Destroy(gameObject); // уничтожаем себя
        }
    }
}
