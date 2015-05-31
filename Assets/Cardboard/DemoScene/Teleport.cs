// Copyright 2014 Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(Collider))]
public class Teleport : MonoBehaviour {
  private Vector3 startingPosition;
  private bool showText = false;

  void Start() {
	startingPosition = transform.localPosition;
	transform.localPosition += new Vector3 (0, 10.0F, 0);
    SetGazedAt(false);
  }

  public void SetGazedAt(bool gazedAt) {
    GetComponent<Renderer>().material.color = gazedAt ? Color.green : Color.red;
  }

	public void PopUp() {
		transform.localPosition = startingPosition;
		//transform.rotation = Quaternion.Euler(2.60551e-11F, 325F, 180F);
		Debug.Log ("PopUp");
	}
	public void GoAway() {
		transform.localPosition += new Vector3 (0, 10.0F, 0);
		Debug.Log ("GoAway");
	}
	
	public void Reset() {
    transform.localPosition = startingPosition;
  }

  public void ToggleVRMode() {
    Cardboard.SDK.VRModeEnabled = !Cardboard.SDK.VRModeEnabled;
  }

  public void TeleportRandomly() {
		showText = true;
  }

	void OnGUI()
	{
		if(showText)
		{
				showText = false;
		}
	}
}
