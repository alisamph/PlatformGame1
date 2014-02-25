using UnityEngine;
using System.Collections;

public class lilguy : MonoBehaviour {
	
	float speed = 10f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		Transform player = GetComponent<Transform>();
		float deltaPosition = speed * Time.deltaTime;
		
		if (Input.GetKey (KeyCode.RightArrow)) {
			player.Translate(-deltaPosition, 0, 0);
		}
		
		if (Input.GetKey (KeyCode.LeftArrow)) {
			player.Translate(deltaPosition, 0, 0);
		}
		
		if (Input.GetKey (KeyCode.UpArrow)) {
			player.Translate(0, 0, -deltaPosition);
		}
		
		if (Input.GetKey (KeyCode.DownArrow)) {
			player.Translate(0, 0, deltaPosition);
		}
		
	}
}
