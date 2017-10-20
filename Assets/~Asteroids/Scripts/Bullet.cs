using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{	
    public string triggerTag = "Asteroid";
    // Update is called once per frame
    void OnTriggerEnter2D (Collider2D col)
    {
	if(col.tag == triggerTag)
        {
            Destroy(gameObject);
            Destroy(col.gameObject);
        }	
	}
}
