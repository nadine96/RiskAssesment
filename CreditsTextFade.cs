using UnityEngine;
using System.Collections;
using TMPro;

public class CreditsTextFade : MonoBehaviour {

	public TextMeshPro text;

	public float fadeInTime = 1.0f;
	public float fadeOutTime = 5.0f;
	// Use this for initialization
	void Start () {
		Invoke ("fadeIn", fadeInTime);
		Invoke ("fadeOut", fadeOutTime);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void fadeIn () {
		StartCoroutine (FadeTo(1.0f, 1.0f));
	}

	void fadeOut() {
		StartCoroutine (FadeTo(0.0f, 1.0f));
	}

	IEnumerator FadeTo(float aVal, float aTime) {
		//float alpha = enableObject.GetComponent<Renderer> ().material.color.a;
		float alpha = text.color.a;
		for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / aTime) {
			//Color newColor = enableObject.GetComponent<Renderer> ().material.color;
			Color newColor = text.color;
			newColor.a = Mathf.Lerp (alpha, aVal, t);
			//enableObject.GetComponent<Renderer> ().material.color = newColor;
			text.color = newColor;
			yield return null;
		}
	}

}
