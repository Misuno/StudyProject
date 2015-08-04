using UnityEngine;
using System.Collections;

public class wagon : MonoBehaviour {
	public float speed, max;
	float minus = 1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
//		var pos = transform.position;
//
//		if (Mathf.Abs (pos.x) <= max) {
//			pos.x += speed * Time.deltaTime * minus;
//		} 
//		else 
//		{
//			pos.x = max * minus;
//			minus = minus * -1f;
//
//
//		}
//
//		transform.position = pos;

		float rotation = speed * Time.deltaTime;

		var angle = transform.rotation.z;
		if (angle <= max) {
//			rotation = 

		}

		transform.Rotate (0f, 0f, rotation);
	
	}
}
