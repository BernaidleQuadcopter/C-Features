using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Arrays
{
    public class Powerup_Speed : MonoBehaviour
    {
        public float modifier = 2f;

        // Collision Detection
        void OnTriggerEnter(Collider col)
        {
            // Detect collision with player
            Player p = col.GetComponent<Player>();
            if(p != null)
            {
                // Add Modifier to force
                p.force *= modifier;
                // Destroyer powerup 
                Destroy(gameObject);
            }
        }

    }
}
