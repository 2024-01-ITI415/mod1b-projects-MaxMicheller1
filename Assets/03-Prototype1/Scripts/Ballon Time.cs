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
		
		Vector3 pos = transform.position;
		
		pos.x = 0;
		pos.y = 0;

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
