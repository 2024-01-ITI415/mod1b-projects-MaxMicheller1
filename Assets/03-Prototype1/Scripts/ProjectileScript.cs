using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
	
	[Header("Set in Inspector")]
	
	public static float bottomY = -20f;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < bottomY){
			
			Destroy( this.gameObject);
			
			// Get a refrence to the ApplePicker component of Main Camera
			//ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();
			
			//Call the public appleDestroyed() method of apScript
			//apScript.AppleDestroyed();
			
		}
    }
}

