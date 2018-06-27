using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public int health = 100;
    public TextMesh healthText;
    public bool isTower;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void ChangeHealth(int value)
    {
        health -= value;
        healthText.text =  health.ToString();
        if( health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
        if (isTower)
        {
            GameController.instance.Lose();
        }
    }
}
