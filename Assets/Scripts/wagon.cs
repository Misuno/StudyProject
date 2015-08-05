using UnityEngine;
using System.Collections;

public class wagon : MonoBehaviour {
	public float speed = 2f;
	public float turnAngle = 30f;
	public float timeToMove = 2f;
	Quaternion finalRotation;
	Quaternion currentRotation;
	float timer;

	// Use this for initialization
	void Start () {
		timer = Time.time;
	
		finalRotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, 0f, turnAngle));
		currentRotation = transform.rotation;

	}
	
	// Update is called once per frame
	void Update () {

		transform.rotation = Quaternion.Lerp (currentRotation, finalRotation, (Time.time - timer) / speed);


		
}
}