using UnityEngine;
using System.Collections;

public class Train : MonoBehaviour {
	public float speed = 60F;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var pos = transform.position;
		pos.z += speed * Time.deltaTime;
		transform.position = pos;
	
	}
}
