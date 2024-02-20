using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallonTime : MonoBehaviour
{
	
		public GameObject ballonPrefab;
		
		public float secondsBetweenBallonSpawns = 10f;

	
	void CreateBallon(){
		
		GameObject ballon = Instantiate<GameObject>(ballonPrefab);
		
		ballon.transform.position = transform.position;
		
		Vector3 pos = this.gameObject.transform.position;

		pos.x = Random.value * 25;
		pos.y = Random.value * 18;
		pos.y -= 6;

		if (Random.value < 0.5f){
			pos.x = -pos.x;
		}

		ballon.transform.position = pos;

		Invoke("CreateBallon", secondsBetweenBallonSpawns);
		
	}
	
    // Start is called before the first frame update
    void Start()
    {
		Invoke("CreateBallon", 2f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
