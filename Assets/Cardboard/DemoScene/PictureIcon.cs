using UnityEngine;
using System.Collections;

public class PictureIcon : MonoBehaviour {
	private Vector3 startingSize;

	// Use this for initialization
	void Start () {
		startingSize = transform.localScale;
		SetFocus(false);
	
	}

	public void SetFocus(bool gazedAt) {
		if (gazedAt) {
			transform.localScale += new Vector3 (0.1F, 0.1F, 0.1F);
			Debug.Log (transform.localScale);
		} else {
			transform.localScale = startingSize;
		}
		Debug.Log (GetComponent<Renderer> ().transform.localScale);
	}
	
}