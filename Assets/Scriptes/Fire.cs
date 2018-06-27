using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject bullet;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        // проверяем включен ли режим стрельбы, касаний больше 0, первое касание началось
        if (GameController.instance.isFire && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) ;
        {
            // создаём луч в точке касания
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit; // объект пересечения с лучом
            if(Physics.Raycast(ray, out hit) && hit.collider.tag == "Emeny") // запускаем луч
            {
                var b = Instantiate(bullet, transform.position, transform.rotation);
                b.GetComponent<Bullet>().tower = hit.collider.gameObject;
            }
        }
	}
}
