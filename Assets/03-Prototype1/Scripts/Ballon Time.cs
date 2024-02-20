using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BallonTime : MonoBehaviour
{

		static private BallonTime S;

	
		public GameObject ballonPrefab;
		
		public float secondsBetweenBallonSpawns = 10f;

		[Header("Set in Inspector")]
	
		public Text uitPops;

		[Header("Set Dynamically")]

	
		public int shotsPopped;

	
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

		shotsPopped = 0;


    }

    // Update is called once per frame
    void Update()
    {

		// if (Goal1.goalMet1 == true){
		// 			S.shotsPopped++;
		// 			Goal1.goalMet1 = false;
		// }
        uitPops.text = "Balloons Popped: " + shotsPopped;


    }

	public static void Popped(){
		S.shotsPopped++;
	}
}
