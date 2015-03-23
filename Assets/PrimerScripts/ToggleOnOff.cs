using UnityEngine;
using System.Collections;

//a visbility switch for the GUI when play button is pressed.
public class ToggleOnOff : MonoBehaviour {
	
	bool visibility = true;
	public GameObject textCanvas;
	
	public GameObject fpCamera, birdEyeCamera;
	
	// Use this for initialization
	void Start () {
		textCanvas.SetActive (visibility);

		fpCamera.SetActive(false);
		birdEyeCamera.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void OffTogglePushed(){
		visibility = !visibility;
		
		textCanvas.SetActive(visibility);
		
		fpCamera.SetActive(true);
		birdEyeCamera.SetActive(false);
	}
	
	public void OnTogglePushed(){
		visibility = !visibility;
		
		textCanvas.SetActive(visibility);
		fpCamera.SetActive(false);
		birdEyeCamera.SetActive(true);
	}
}
