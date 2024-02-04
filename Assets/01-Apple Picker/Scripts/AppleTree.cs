using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
	// Prefab for instantiating apples
	public GameObject applePrefab;
	
	// Speed at which the AppleTree moves
	public float speed = 10f;
	
	// Distance where AppleTree turns around
	public float leftAndRightEdge = 20f;
	
	// Chance that the AppleTree will change directions
	public float chanceToChangeDirections = 0.02f;
	
	//Rate at which Apples will be instantiated
	public float secondsBetweenAppleDrops = 1f;
	
    // Start is called before the first frame update
    void Start(){
		
        //Dropping apples every secondsBetweenAppleDrops
		Invoke("DropApple", 2f);
    }
	
	void DropApple(){
		
		GameObject apple = Instantiate<GameObject>(applePrefab);
		
		apple.transform.position = transform.position;
		
		Invoke("DropApple", secondsBetweenAppleDrops);
		
	}

    // Update is called once per frame
    void Update()
    {
        // Basic Movement
		Vector3 pos = transform.position;
		
		pos.x += speed * Time.deltaTime;
		
		transform.position = pos;
		
		// Changing Direction
		if(pos.x < -leftAndRightEdge){
			
			speed = Mathf.Abs(speed); // Move right
			
		}else if (pos.x > leftAndRightEdge){
			
			speed = -Mathf.Abs(speed); // Move leftAndRightEdge
			
		}
    }
	
	void FixedUpdate(){
		
		//Changing Direction Randomly in a time based format.
		
		if (Random.value < chanceToChangeDirections){
			
			speed *= -1; // Change direction
		}
	}
}
