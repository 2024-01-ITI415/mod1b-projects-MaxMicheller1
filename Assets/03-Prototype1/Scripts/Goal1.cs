using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal1 : MonoBehaviour
{
	//static public bool 	goalMet = false;

	void OnCollisionEnter( Collision coll ) {                         // a

        // Find out what hit this basket

        GameObject collidedWith = coll.gameObject;                    // b

        if ( collidedWith.tag == "Projectile1" ) {                          // c

            Destroy( collidedWith );

        }

    }
		
			
		
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
