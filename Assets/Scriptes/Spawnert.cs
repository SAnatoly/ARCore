using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnert : MonoBehaviour {

    public GameObject spawnObject;
    public float spawnspeed = 1;
    public float spawnRadius = 1;

	void Start ()
    {
        StartCoroutine(Spawn());
	}
	
    IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnspeed);

            Vector3 spawnPosition = new Vector3(transform.position.x + Random.Range(-spawnRadius, spawnRadius), 
                transform.position.y, 
                transform.position.z + Random.Range(-spawnRadius, spawnRadius));
            Instantiate(spawnObject, spawnPosition, transform.rotation);
        }
    }

	// Update is called once per frame
	void Update () {
		
	}
}
