using UnityEngine;
using System.Collections;

public class scrolling : MonoBehaviour {

	public int creditSpeed = 3;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.up * Time.deltaTime * creditSpeed, Space.World);
	}
}
