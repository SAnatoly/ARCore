using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int damage = 2; // Урон врага 
    public float speed = 10; // Скорость врага
    GameObject tower; //  Цель врага
    

    void Start ()
    {
        tower = GameObject.FindGameObjectWithTag("Tower");
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (tower != null) // если цель существует, то двигаемся к ней
        {
            transform.position = Vector3.MoveTowards(transform.position, tower.transform.position, speed * Time.deltaTime);
            transform.LookAt(tower.transform);
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Tower")
        {
            other.GetComponent<Health>().ChangeHealth(damage); // получает скрипт башни и меняем значение жизни в соответствии с уроном врага
            Destroy(gameObject); // уничтожаем себя
        }
    }
}
