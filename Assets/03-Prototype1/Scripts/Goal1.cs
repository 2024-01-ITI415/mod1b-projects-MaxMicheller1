using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal1 : MonoBehaviour
{
	//static public bool 	goalMet = false;

	void OnTriggerEnter(Collider other) {
		// when the trigger is hit by something
		// check to see if it's a Projectile 
		if (other.gameObject.tag == "Projectile1") {
			// if so, set goalMet = true
			Destroy (other);
		
			
			



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
