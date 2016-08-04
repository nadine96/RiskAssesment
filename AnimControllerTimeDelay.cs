using UnityEngine;
using System.Collections;

public class AnimControllerTimeDelay : MonoBehaviour {

	public float idleTime = 14f;

	Animator animator;

	private bool triggered = false;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {
		if (!triggered) {
			triggered = true;
			Invoke ("setParam", idleTime);
		}
	}

	void setParam() {
		animator.SetBool ("delay", true);
		Invoke ("turnOff", .3f);
		triggered = false;
	}

	void turnOff() {
		animator.SetBool ("delay", false);
	}
}