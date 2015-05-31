using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class IntroScene : MonoBehaviour {

	void Start() {

	}
	
	public void ClickScene(int levelIndex) {
		//Application.LoadLevel (levelIndex);
		AutoFade.LoadLevel(levelIndex ,1,1,Color.black);
	}
	
	
}

