using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {

	public AudioSource sentence1;
	public AudioSource sentence2;
	public AudioSource sentence3;
	public AudioSource sentence4;
	public AudioSource sentence5;
	public AudioSource sentence6;
	public AudioSource sentence7;

	public float sentence1Start = 2f;
	public float sentence2Start = 12f;
	public float sentence3Start = 20f;
	public float sentence4Start = 28f;
	public float sentence5Start = 36f;
	public float sentence6Start = 42f;
	public float sentence7Start = 52f;

	// Use this for initialization
	void Start () {
		Invoke ("playSentence1", sentence1Start);
		Invoke ("playSentence2", sentence2Start);
		Invoke ("playSentence3", sentence3Start);
		Invoke ("playSentence4", sentence4Start);
		Invoke ("playSentence5", sentence5Start);
		Invoke ("playSentence6", sentence6Start);
		Invoke ("playSentence7", sentence7Start);

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void playSentence1() {
		sentence1.Play ();
	}

	void playSentence2() {
		sentence2.Play ();
	}

	void playSentence3() {
		sentence3.Play ();
	}

	void playSentence4() {
		sentence4.Play ();
	}

	void playSentence5() {
		sentence5.Play ();
	}

	void playSentence6() {
		sentence6.Play ();
	}

	void playSentence7() {
		sentence7.Play ();
	}
}
