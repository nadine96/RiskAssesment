using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {

	public GameObject Plaza;
	public GameObject Jail;
	public GameObject Interrogation1;
	public GameObject Interrogation2;
	public GameObject car;

	public GameObject mirror1;
	public GameObject mirror2;
	public GameObject opaqueMirror1;
	public GameObject opaqueMirror2;

	public AudioSource jailSounds;
	public AudioSource plazaSounds;

	public Material fadeMat;
	public Material fadeMat2;

	public SpriteRenderer Emblematic;
	public SpriteRenderer Propublica;

	public float scene1Length = 20f;

	// Use this for initialization
	void Start () {
		Invoke ("opening", 2.0f);
		Invoke ("fadeToScene2", scene1Length);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void opening() {
		StartCoroutine (FadeInBegin(1.0f, 2.0f));
		Invoke ("openingFinish", 6.0f);
	}

	void openingFinish() {
		opaqueMirror1.SetActive (false);
		opaqueMirror2.SetActive (false);
		StartCoroutine (FadeOutBegin(0.0f, 2.0f));
		Invoke ("FixAlpha", 2.0f);
	}

	void FixAlpha() {
		mirror1.SetActive (false);
		mirror2.SetActive (false);
		Color newColor = fadeMat2.color;
		newColor.a = 1f;
		fadeMat2.color = newColor;
	}

	void fadeToScene2 () {
		StartCoroutine (FadeTo (1f, 1f));
		Invoke ("switchActives", 1f);
	}

	void switchActives() {
		Plaza.SetActive (true);
		Jail.SetActive(true);
		car.SetActive (true);
		Interrogation1.SetActive (false);
		Interrogation2.SetActive (false);
		StartCoroutine (FadeTo (0f, 1f));
		Invoke ("playSound", 1f);
	}

	void playSound () {
		jailSounds.Play ();
		plazaSounds.Play ();
	}

	IEnumerator FadeTo(float aVal, float aTime) {
		//float alpha = enableObject.GetComponent<Renderer> ().material.color.a;
		float alpha = fadeMat.color.a;
		for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / aTime) {
			//Color newColor = enableObject.GetComponent<Renderer> ().material.color;
			Color newColor = fadeMat.color;
			newColor.a = Mathf.Lerp (alpha, aVal, t);
			//enableObject.GetComponent<Renderer> ().material.color = newColor;
			fadeMat.color = newColor;
			yield return null;
		}
	}

	IEnumerator FadeInBegin(float aVal, float aTime) {
		//float alpha = enableObject.GetComponent<Renderer> ().material.color.a;
		//float alpha = fadeMat2.color.a;
		float alpha2 = Emblematic.color.a;
		float alpha3 = Propublica.color.a;
		for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / aTime) {
			//Color newColor = enableObject.GetComponent<Renderer> ().material.color;
			//Color newColor = fadeMat2.color;
			Color newColor2 = Emblematic.color;
			Color newColor3 = Propublica.color;
			//newColor.a = Mathf.Lerp (alpha, aVal, t);
			newColor2.a = Mathf.Lerp (alpha2, aVal, t);
			newColor3.a = Mathf.Lerp (alpha3, aVal, t);
			//enableObject.GetComponent<Renderer> ().material.color = newColor;
			//fadeMat2.color = newColor;
			Emblematic.color = newColor2;
			Propublica.color = newColor3;
			yield return null;
		}
	}

	IEnumerator FadeOutBegin(float aVal, float aTime) {
		//float alpha = enableObject.GetComponent<Renderer> ().material.color.a;
		float alpha = fadeMat2.color.a;
		float alpha2 = Emblematic.color.a;
		float alpha3 = Propublica.color.a;
		for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / aTime) {
			//Color newColor = enableObject.GetComponent<Renderer> ().material.color;
			Color newColor = fadeMat2.color;
			Color newColor2 = Emblematic.color;
			Color newColor3 = Propublica.color;
			newColor.a = Mathf.Lerp (alpha, aVal, t);
			newColor2.a = Mathf.Lerp (alpha2, aVal, t);
			newColor3.a = Mathf.Lerp (alpha3, aVal, t);
			//enableObject.GetComponent<Renderer> ().material.color = newColor;
			fadeMat2.color = newColor;
			Emblematic.color = newColor2;
			Propublica.color = newColor3;
			yield return null;
		}
	}
}
