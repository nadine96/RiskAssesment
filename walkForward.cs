using UnityEngine;
using System.Collections;

public class walkForward : MonoBehaviour {

	public float walkspeed = .1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z - walkspeed);
	}
}
